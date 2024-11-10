using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;
using PRG282_Project.StudentLayer;


namespace PRG282_Project.DataHandeling
{
    internal class AddNewStudent
    {
        private ViewAllStudents viewAllStudents;
        public AddNewStudent(ViewAllStudents viewAllStudentsInstance) 
        {
            viewAllStudents = viewAllStudentsInstance;
        }

   

        ViewAllStudents ViewAllStudents;  
        public void AddStudent(string name, string age, string course)
        {
            string fullPath = @"StudentLayer\students.txt";
            
            

            try
            {
                
                    if (File.Exists(path))
                    {

                        List<string> lines = new List<string>();
                        lines = File.ReadAllLines(fullPath).ToList();
                        lines.Add($"{getNewID()}, {name}, {age}, {course}");
                        File.WriteAllLines(fullPath, lines);

                        MessageBox.Show("Student Added");

                    }
                    else
                    {
                        MessageBox.Show("students.txt file not found.");
                    }



                }
                else 
                {
                    MessageBox.Show("Please enter a vaild age");
                }





            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message + "file not found");
            }
            viewAllStudents.DisplayStudents();
        }

        public string getNewID()
        {
            string fullPath = @"StudentLayer\students.txt";

            string newID = "";
            try
            {
                List<string> lines = new List<string>();
                lines = File.ReadAllLines(fullPath).ToList();
                string lastline = lines[lines.Count - 1];
                lastline = lastline.Substring(1, lastline.IndexOf(",") - 1);
                int num = Convert.ToInt32(lastline);
                newID = "S" + Convert.ToString(++num);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message+"file not found");

            }

            return newID;
        }

        
    }
}
