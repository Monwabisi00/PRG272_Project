using System;
using System.Collections.Generic;
using System.IO;
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

                // Show success message
                MessageBox.Show(text: "Student information saved successfully!", caption: "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                // Show error message
                MessageBox.Show(text: $"Something went wrong when saving the student: {ex.Message}", caption: "Oops", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
