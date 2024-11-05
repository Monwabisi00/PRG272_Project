using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
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
        }

        private void ShowAllStudents()
        {
            //Load the students to display on the grid
            dataGridStudents.DataSource = DataHandler.LoadStudentsFromTextFile();

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

        private void btnAddNewStudent_Click(object sender, EventArgs e)
        {
            string studentId = txtNewStudentId.Text;
            string studentName = txtNewStudentName.Text;
            string studentSurname = txtNewStudentSurname.Text;
            decimal studentAge = sedNewStudentAge.Value;
            string studentCourse = cmbNewStudentCourse.Text;

            Student newStudent = new Student(studentId, studentName, studentSurname, studentAge, studentCourse);

            newStudent.SaveToTextFile();
        }

        private void btnRefreshTableData_Click(object sender, EventArgs e)
        {
            ShowAllStudents();
        }
    }
}
