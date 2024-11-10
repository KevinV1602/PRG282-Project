using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PRG282_Project.PresentationLayer
{
    internal class SearchStudent
    {
        string filePath = @"C:\Users\dariu\source\repos\PRG282-Project\PRG282 Project\StudentLayer\students.txt";
        public int searchStudent(string ID) 
        {
            int count = 0;
            try 
            {
                List<string> lines = new List<string>();
                lines = File.ReadAllLines(filePath).ToList();


                ID = ID.Substring(1, ID.Length - 1);
                int num = Convert.ToInt32(ID);
                

                foreach (string line in lines)
                {

                    string ListID = line;
                    ListID = ListID.Substring(1, ListID.IndexOf(",") - 1);
                    if (ID.Trim() == ListID)
                    {
                        break;
                    }                 
                    count++;
                    if (count == lines.Count)
                    {
                        MessageBox.Show("Student not found");
                    }
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message + "file not found");
            }


            return count;
        }

    }
}
