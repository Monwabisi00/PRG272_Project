using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace PRG272_Project
{
    internal class Student
    {
        public string StudentId { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public decimal Age { get; set; }
        public string Course { get; set; }

        private const string StudentsTextFilePath = DataHandler.StudentsTextFilePath;
        private const string SummaryTextFilePath = DataHandler.SummaryTextFilePath;

        public Student(string studentId, string name, string surname, decimal age, string course)
        {
            StudentId = studentId;
            Name = name;
            Surname = surname;
            Age = age;
            Course = course;
        }

        public override string ToString()
        {
            return $"{StudentId},{Name},{Surname},{Age},{Course}";
        }

        public void SaveToTextFile()
        {
            try
            {
                // Append to file if it exists and has data otherwise overwrite/create a file
                using (StreamWriter streamWriter = File.Exists(StudentsTextFilePath) && new FileInfo(StudentsTextFilePath).Length > 0
                    ? File.AppendText(StudentsTextFilePath) : new StreamWriter(StudentsTextFilePath))
                {
                    streamWriter.WriteLine(ToString());
                }

                using (StreamWriter streamWriter = File.Exists(SummaryTextFilePath) && new FileInfo(SummaryTextFilePath).Length > 0
                    ? File.CreateText(SummaryTextFilePath) : new StreamWriter(SummaryTextFilePath))
                {
                    List<Student> students = DataHandler.LoadStudentsFromTextFile();
                    string total = $"{students.Count()}";

                    // Calculate the average age safely, handling empty lists, and rounding to 2 decimal places
                    decimal averageAge = students.Any() ? Math.Round(students.Average(student => student.Age), 2) : 0;

                    streamWriter.WriteLine($"Total Students: {total}, Average Student Age: {averageAge}");
                }

                // Show success message
                MessageBox.Show(text: "Student information saved successfully!", caption: "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                // Show error message
                MessageBox.Show(text: $"Something went wrong when saving the student: {ex.Message}", caption: "Oops", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
      
        }

        //Uodates and deleting section-J
        public void UpdateStudentInTextFile()
        {
            try
            {
                List<Student> students = DataHandler.LoadStudentsFromTextFile();
                var existingStudent = students.FirstOrDefault(s => s.StudentId == this.StudentId);

                if (existingStudent != null)
                {
                    existingStudent.Name = this.Name;
                    existingStudent.Surname = this.Surname;
                    existingStudent.Age = this.Age;
                    existingStudent.Course = this.Course;

                    DataHandler.SaveStudentsToTextFile(students);

                    MessageBox.Show("Student information updated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Student not found!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error updating student: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public static void DeleteStudentFromTextFile(string studentId)
        {
            try
            {
                List<Student> students = DataHandler.LoadStudentsFromTextFile();
                var studentToDelete = students.FirstOrDefault(s => s.StudentId == studentId);

                if (studentToDelete != null)
                {
                    students.Remove(studentToDelete);

                    DataHandler.SaveStudentsToTextFile(students);

                    MessageBox.Show("Student deleted successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Student not found!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error deleting student: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

    }
}
