using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PRG272_Project
{
    internal static class DataHandler
    {
        public const string StudentsTextFilePath = "students.txt";
        public const string SummaryTextFilePath = "summary.txt";

        public static List<Student> LoadStudentsFromTextFile()
        {
            List<Student> students = new List<Student>();

            if (File.Exists(StudentsTextFilePath))
            {
                // Get all lines from the text file
                string[] lines = File.ReadAllLines(StudentsTextFilePath);

                // Loop through each line and extract the student data
                foreach (string line in lines)
                {
                    string[] parts = line.Split(','); // Data is comma separated
                    if (parts.Length == 5 && int.TryParse(parts[3], out int age)) // Validate age conversion
                    {
                        students.Add(new Student(parts[0], name: parts[1], surname: parts[2], age, course: parts[4]));
                    }
                    else
                    {
                        // Log the error without interrupting the process
                        MessageBox.Show(text: $"Invalid data found: {line}", caption: "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
            }
            else
            {
                MessageBox.Show(text: "Student text file not found.", caption: "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            return students;
        }

        //Students Saved-J
        public static void SaveStudentsToTextFile(List<Student> students)
        {
            using (StreamWriter writer = new StreamWriter(StudentsTextFilePath))
            {
                foreach (Student student in students)
                {
                    writer.WriteLine(student.ToString());
                }
            }
        }

    }
}
