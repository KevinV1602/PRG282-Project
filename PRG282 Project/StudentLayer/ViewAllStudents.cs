using System;
using System.IO;
using System.Windows.Forms;
using PRG282_Project;

namespace PRG282_Project.StudentLayer
{
    internal class ViewAllStudents
    {
        private DataGridView dataGridViewStudents;

        private ViewAllStudents viewAllStudents;





        // Constructor accepting DataGridView
        public ViewAllStudents(DataGridView dataGridView)
        {
            dataGridViewStudents = dataGridView;
        }

        public void DisplayStudents()
        {


            string filePath = @"C:\Users\dariu\source\repos\PRG282-Project\PRG282 Project\StudentLayer\students.txt"; // File path


            try
            {
                // Clear existing rows and columns only if necessary
                dataGridViewStudents.Rows.Clear();
                if (dataGridViewStudents.Columns.Count == 0)
                {
                    dataGridViewStudents.Columns.Add("StudentID", "Student ID");
                    dataGridViewStudents.Columns.Add("Name", "Name");
                    dataGridViewStudents.Columns.Add("Age", "Age");
                    dataGridViewStudents.Columns.Add("Course", "Course");
                }

                if (File.Exists(filePath))
                {
                    string[] studentRecords = File.ReadAllLines(filePath);
                    MessageBox.Show($"Loaded {studentRecords.Length} records."); // Debugging: Check file content

                    foreach (string record in studentRecords)
                    {
                        string[] studentData = record.Split(',');

                        if (studentData.Length == 4)
                        {
                            dataGridViewStudents.Rows.Add(
                                studentData[0].Trim(),
                                studentData[1].Trim(),
                                studentData[2].Trim(),
                                studentData[3].Trim()
                            );
                        }
                        else
                        {
                            MessageBox.Show("Data format error: each record should have exactly four fields.");
                            break;
                        }
                    }
                }
                else
                {
                    MessageBox.Show("students.txt file not found.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred while loading students: {ex.Message}");
            }
        }
    }
}