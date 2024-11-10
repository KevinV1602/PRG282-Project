using System;
using System.Data;
using System.IO;
using System.Windows.Forms;
using PRG282_Project;

namespace PRG282_Project.StudentLayer
{
    internal class ViewAllStudents
    {
        private DataTable dataGridViewStudents;

        private ViewAllStudents viewAllStudents;





        // Constructor accepting DataGridView
        public ViewAllStudents( DataTable dataGridView)
        {
            dataGridViewStudents = dataGridView;
        }

        public DataTable DisplayStudents()
        {

 string filePath = @"C:\Users\dariu\source\repos\PRG282-Project\PRG282 Project\StudentLayer\students.txt";

            try
            {
                // Clear existing rows and columns only if necessary
                dataGridViewStudents.Rows.Clear();
               dataGridViewStudents.Columns.Clear();
                if (dataGridViewStudents.Columns.Count == 0)
               {
                    dataGridViewStudents.Columns.Add("ID", typeof(string));
                    dataGridViewStudents.Columns.Add("Name", typeof(string));
                    dataGridViewStudents.Columns.Add("Age", typeof(string));
                    dataGridViewStudents.Columns.Add("Course", typeof(string));
                }

                if (File.Exists(filePath))
                {
                    string[] studentRecords = File.ReadAllLines(filePath);
                    
                    MessageBox.Show($"Loaded {studentRecords.Length} records."); //  Check file amount and content (Refreshing list)

                    foreach (string record in studentRecords)
                    {
                        
                        string[] studentData = record.Split(',');
                       

                        if (studentData.Length == 4)
                        {
                            dataGridViewStudents.Rows.Add(
                                studentData[0],
                                studentData[1],
                                studentData[2], 
                                studentData[3]                               
                            );
                        }
                        else
                        {
                            MessageBox.Show("Data format error: each record should have exactly four fields."); // User Validation
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
                MessageBox.Show($"An error occurred while loading students: {ex.Message}");   // Error Control
            }
            return dataGridViewStudents;
        }
    }
}