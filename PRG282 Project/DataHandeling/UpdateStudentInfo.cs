using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PRG282_Project.DataHandeling
{
    public class Student
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public string Course { get; set; }
    }
    
    public class UpdateStudentInfo
    {

        public static Student GetUpdatedStudentFromUser()
        {
            return new Student {Id = "S001",  Name = "John Doe", Age = 20, Course = "maths" };
        }

        public static void UpdateStudentInGrid(DataGridView dataGridViewStudents, Student updatedStudent)
        {

           
            foreach (DataGridViewRow row in dataGridViewStudents.Rows)
            {
                

                if (row.Cells["ID"].Value != null && (string)row.Cells["ID"].Value == updatedStudent.Id)
                {
                    row.Cells["Name"].Value = updatedStudent.Name;
                    row.Cells["Age"].Value = updatedStudent.Age;
                    row.Cells["Course"].Value = updatedStudent.Course;
                    break; // Exit the loop once the row is found and updated
                }


            }

          
        }

    }

}
