using System;
using System.IO;
using System.Windows.Forms;

namespace PRG282_Project.DataHandeling
{
    internal class ViewAllStudents
    {
        private DataGridView dataGridViewStudents;

        // Constructor accepting DataGridView
        public ViewAllStudents(DataGridView dataGridView)
        {
            dataGridViewStudents = dataGridView;
        }

        public void DisplayStudents()
        {
            string filePath = "students.txt";

            // Clear existing rows and columns
            dataGridViewStudents.Rows.Clear();
            dataGridViewStudents.Columns.Clear();

            // Set up DataGridView columns
            dataGridViewStudents.Columns.Add("StudentID", "Student ID");
            dataGridViewStudents.Columns.Add("Name", "Name");
            dataGridViewStudents.Columns.Add("Age", "Age");
            dataGridViewStudents.Columns.Add("Course", "Course");

            // Load data from students.txt and populate the DataGridView
            if (File.Exists(filePath))
            {
                string[] studentRecords = File.ReadAllLines(filePath);

                foreach (string record in studentRecords)
                {
                    // Assuming each record is comma-separated
                    string[] studentData = record.Split(',');

                    if (studentData.Length == 4) // Adjust according to your data format
                    {
                        dataGridViewStudents.Rows.Add(studentData[0], studentData[1], studentData[2], studentData[3]);
                    }
                }
            }
            else
            {
                MessageBox.Show("students.txt file not found.");
            }
        }
    }
}
