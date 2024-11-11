using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PRG272_Project
{
    public sealed partial class StudentManagementForm : Form
    {
        public StudentManagementForm()
        {
            InitializeComponent();
            
            //Change the font family for the form
            this.Font = new Font(familyName: "Segoe UI", emSize: 9);

            ShowAllStudents();

            ShowReport();


        }

        private void ShowAllStudents()
        {
            //Load the students to display on the grid
            dataGridStudents.DataSource = DataHandler.LoadStudentsFromTextFile();
            dataGridViewStudents.DataSource = DataHandler.LoadStudentsFromTextFile();

            // Ensure we select the first cell if there are students to display
            if (dataGridStudents.Rows.Count > 0)
            {
                dataGridStudents.CurrentCell = dataGridStudents.Rows[0].Cells[0];
            }

            UpdateNavigationButtons();
        }

        private void ShowStudents(List<Student> students)
        {
            dataGridStudents.DataSource = students;

            // Ensure we select the first cell if there are students to display
            if (dataGridStudents.Rows.Count > 0)
            {
                dataGridStudents.CurrentCell = dataGridStudents.Rows[0].Cells[0];
            }

            UpdateNavigationButtons();
        }

        private void ShowReport()
        {
            // Displaying report
            txtTotal.Text = $"{DataHandler.LoadStudentsFromTextFile().Count()}";

            // Calculate the average age safely, handling empty lists
            decimal averageAge = DataHandler.LoadStudentsFromTextFile().Any() ? DataHandler.LoadStudentsFromTextFile().Average(student => student.Age) : 0;
            txtAverage.Text = $"{averageAge:F2}";
            // ensures the user cannot edit the textbox
            txtTotal.Enabled = false;
            txtAverage.Enabled = false;
        }

        //Enable/Disable nav buttons based on logic
        private void UpdateNavigationButtons()
        {
            // Ensure there are rows in the data grid before accessing the current cell
            if (dataGridStudents.Rows.Count > 0 && dataGridStudents.CurrentCell != null)
            {
                int currentRowIndex = dataGridStudents.CurrentCell.RowIndex;
                int lastRowIndex = dataGridStudents.Rows.Count - 1;
                btnNavigatePrev.Enabled = currentRowIndex > 0; // Enable if not on first row
                btnNavigateNext.Enabled = currentRowIndex < lastRowIndex; // Enable if not on last row
            }
            else
            {
                // Disable both buttons if no rows or if current cell is null
                btnNavigatePrev.Enabled = false;
                btnNavigateNext.Enabled = false;
            }
        }

        private void btnNavigateFirst_Click(object sender, EventArgs e)
        {
            //We can only navigate if there are rows in the data grid
            if (dataGridStudents.Rows.Count > 0)
            {
                //Set current cell to first row, first cell
                dataGridStudents.CurrentCell = dataGridStudents.Rows[0].Cells[0];
                UpdateNavigationButtons();
            }
        }

        private void btnNavigateLast_Click(object sender, EventArgs e)
        {
            //We can only navigate if there are rows in the data grid
            if (dataGridStudents.Rows.Count > 0)
            {
                int lastRowIndex = dataGridStudents.Rows.Count - 1;

                //Set current cell to last row, first cell
                dataGridStudents.CurrentCell = dataGridStudents.Rows[lastRowIndex].Cells[0];
                UpdateNavigationButtons();
            }
        }

        private void btnNavigateNext_Click(object sender, EventArgs e)
        {
            int lastRowIndex = dataGridStudents.Rows.Count - 1;

            // Check if there are rows and that we’re not already on the last row
            if (dataGridStudents.CurrentCell != null && dataGridStudents.CurrentCell.RowIndex < lastRowIndex)
            {
                // Move to the next row in the same column
                int nextRowIndex = dataGridStudents.CurrentCell.RowIndex + 1;
                dataGridStudents.CurrentCell = dataGridStudents.Rows[nextRowIndex].Cells[dataGridStudents.CurrentCell.ColumnIndex];
                UpdateNavigationButtons();
            }
        }

        private void btnNavigatePrev_Click(object sender, EventArgs e)
        {
            // Check if there are rows and that we’re not already on the first row
            if (dataGridStudents.CurrentCell != null && dataGridStudents.CurrentCell.RowIndex > 0)
            {
                // Move to the previous row in the same column
                int prevRowIndex = dataGridStudents.CurrentCell.RowIndex - 1;
                dataGridStudents.CurrentCell = dataGridStudents.Rows[prevRowIndex].Cells[dataGridStudents.CurrentCell.ColumnIndex];
                UpdateNavigationButtons();
            }
        }

        private void dataGridStudents_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //If user manually navigates, also update the navigation buttons
            UpdateNavigationButtons();
        }

        private void btnSearchStudent_Click(object sender, EventArgs e)
        {
            string searchText = txtSearchStudent.Text.Trim().ToLower();
            List <Student> students = DataHandler.LoadStudentsFromTextFile();

            if (string.IsNullOrEmpty(searchText))
            {
                ShowAllStudents();
            }
            else
            {
                //Filter the data based on the search (here we search by all fields)
                List<Student> filteredStudents = students.Where((student) =>
                    student.Name.ToLower().Contains(searchText) || student.Surname.ToLower().Contains(searchText)
                    || student.StudentId.ToLower().Contains(searchText) || student.Course.ToLower().Contains(searchText) ||
                    student.Age.ToString(CultureInfo.InvariantCulture).Contains(searchText)).ToList();
                ShowStudents(filteredStudents);
            }
        }

        //Major pain getting the Age and Course Working

        private void btnAddNewStudent_Click(object sender, EventArgs e)
        {
            // error handling for ensuring all input fields are filled out
            if (string.IsNullOrWhiteSpace(txtNewStudentId.Text) ||
                string.IsNullOrWhiteSpace(txtNewStudentName.Text) ||
                string.IsNullOrWhiteSpace(txtNewStudentSurname.Text) ||
                string.IsNullOrWhiteSpace(cmbNewStudentCourse.Text))
            {
                MessageBox.Show("Please fill out all fields before adding a student.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string studentId = ValidID(txtNewStudentId.Text); // valid ID's have 6 numbers
            string studentName = ValidName(txtNewStudentName.Text); // valid names don't contain any numbers
            string studentSurname = ValidName(txtNewStudentSurname.Text);
            decimal studentAge = sedNewStudentAge.Value;
            string studentCourse = cmbNewStudentCourse.Text;
            if (studentName == null || studentSurname == null || studentId == null) 
            {
                txtNewStudentId.Text = "";
                txtNewStudentName.Text = "";
                txtNewStudentSurname.Text = "";
                cmbNewStudentCourse.Text = "";
                return;
            }
            else
            {
                Student newStudent = new Student(studentId, studentName, studentSurname, studentAge, studentCourse);

                newStudent.SaveToTextFile();

                ShowReport();

                txtNewStudentId.Text = "";
                txtNewStudentName.Text = "";
                txtNewStudentSurname.Text = "";
                cmbNewStudentCourse.Text = "";
            }
        }

        private void btnRefreshTableData_Click(object sender, EventArgs e)
        {
            ShowAllStudents();
        }


        //update and delete starts here.
        private void btnUpdateStudent_Click(object sender, EventArgs e)
        {
            if (dataGridViewStudents.CurrentRow != null)
            {
                // error handling for ensuring all input fields are filled out
                if (string.IsNullOrWhiteSpace(txtUpdateStudentName.Text) ||
                    string.IsNullOrWhiteSpace(txtUpdateStudentSurname.Text) ||
                    string.IsNullOrWhiteSpace(cmbUpdateStudentCourse.Text))
                {
                    MessageBox.Show("Please fill out all fields before updating.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                DataGridViewRow row = dataGridViewStudents.CurrentRow;

                string studentId = row.Cells["StudentId"].Value.ToString();
                string studentName = txtUpdateStudentName.Text;
                string studentSurname = txtUpdateStudentSurname.Text;
                decimal studentAge = nudUpdateStudentAge.Value;
                string studentCourse = cmbUpdateStudentCourse.Text;

                Student updatedStudent = new Student(studentId, studentName, studentSurname, studentAge, studentCourse);
                updatedStudent.UpdateStudentInTextFile();

                ShowAllStudents();
                ShowReport();
            }
            else
            {
                MessageBox.Show("No student selected for updating.", "Selection Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnDeleteStudent_Click(object sender, EventArgs e)
        {

            if (dataGridViewStudents.CurrentRow != null)
            {
                DataGridViewRow row = dataGridViewStudents.CurrentRow;
                string studentId = row.Cells["StudentId"].Value.ToString();

                DialogResult result = MessageBox.Show("Are you sure you want to delete this student?", "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (result == DialogResult.Yes)
                {
                    Student.DeleteStudentFromTextFile(studentId);

                    ShowAllStudents();
                    ShowReport();
                }
            }
        }

        private string ValidID(string studentID)
        {
            if(studentID.Length != 6)
            {
                MessageBox.Show("Invalid ID. Does not contain 6 digits", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return null;
            }
            else
            {
                return studentID;
            }
            
        }

        private string ValidName(string name)
        {
            foreach (char character in name)
            {
                if (char.IsDigit(character))
                {
                    MessageBox.Show("Invalid. Name or Surname contains a number.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return null; // Return null if number is found.
                }
            }
            return name;
        }

        private void dataGridViewStudents_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0) // Ensure a valid row is selected
            {
                DataGridViewRow row = dataGridViewStudents.Rows[e.RowIndex];

                // Load data from selected row into update fields
                txtUpdateStudentName.Text = row.Cells["Name"].Value.ToString();
                txtUpdateStudentSurname.Text = row.Cells["Surname"].Value.ToString();
                nudUpdateStudentAge.Value = Convert.ToDecimal(row.Cells["Age"].Value);
                cmbUpdateStudentCourse.Text = row.Cells["Course"].Value.ToString();
            }
        }
    }
}
