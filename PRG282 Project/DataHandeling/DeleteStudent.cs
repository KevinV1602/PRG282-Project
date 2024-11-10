using System;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using PRG282_Project.StudentLayer;

namespace PRG282_Project.DataHandeling
{
    internal class DeleteStudent
    {
        private DataGridView dataGridViewStudents;
        private ViewAllStudents viewAllStudents;
        private readonly string path = @"C:\Users\squis\source\repos\PRG282-Project\PRG282 Project\StudentLayer\students.txt"; // Define the file path here

        // Constructor to initialize DataGridView and ViewAllStudents set
        public DeleteStudent(DataGridView dataGridView, ViewAllStudents viewAllStudentsInstance)
        {
            dataGridViewStudents = dataGridView;
            viewAllStudents = viewAllStudentsInstance;
        }

        public void DeleteSelectedStudent()
        {
            if (dataGridViewStudents.SelectedRows.Count > 0)
            {
                var selectedRow = dataGridViewStudents.SelectedRows[0];// Must select row first and then Delete Button
                string studentId = selectedRow.Cells["ID"].Value?.ToString(); //Use ID

                var confirmResult = MessageBox.Show(  // Conformation from User 
                    "Are you sure you want to delete this student?",
                    "Confirm Delete",
                    MessageBoxButtons.YesNo);

                if (confirmResult == DialogResult.Yes)
                {
                    if (!File.Exists(path))
                    {
                        MessageBox.Show("The students.txt file was not found.");
                        return;
                    }

                    string[] studentRecords = File.ReadAllLines(path); //Remove student
                    var updatedRecords = studentRecords
                        .Where(record => !record.StartsWith(studentId + ","))
                        .ToArray();

                    File.WriteAllLines(path, updatedRecords);  // Update Count on Student.txt file. Refreshed

                    // Refresh DataGridView
                    viewAllStudents.DisplayStudents();
                }
            }
            else
            {
                MessageBox.Show("Please select a student to delete.");  // Must Select to Delete
            }
        }
    }
}
