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
        private readonly string filePath = "students.txt"; // Define the file path here

        // Constructor to initialize DataGridView and ViewAllStudents
        public DeleteStudent(DataGridView dataGridView, ViewAllStudents viewAllStudentsInstance)
        {
            dataGridViewStudents = dataGridView;
            viewAllStudents = viewAllStudentsInstance;
        }

        public void DeleteSelectedStudent()
        {
            if (dataGridViewStudents.SelectedRows.Count > 0)
            {
                var selectedRow = dataGridViewStudents.SelectedRows[0];
                string studentId = selectedRow.Cells["ID"].Value?.ToString();

                var confirmResult = MessageBox.Show(
                    "Are you sure you want to delete this student?",
                    "Confirm Delete",
                    MessageBoxButtons.YesNo);

                if (confirmResult == DialogResult.Yes)
                {
                    if (!File.Exists(filePath))
                    {
                        MessageBox.Show("The students.txt file was not found.");
                        return;
                    }

                    string[] studentRecords = File.ReadAllLines(filePath);
                    var updatedRecords = studentRecords
                        .Where(record => !record.StartsWith(studentId + ","))
                        .ToArray();

                    File.WriteAllLines(filePath, updatedRecords);

                    // Refresh DataGridView
                    viewAllStudents.DisplayStudents();
                }
            }
            else
            {
                MessageBox.Show("Please select a student to delete.");
            }
        }
    }
}
