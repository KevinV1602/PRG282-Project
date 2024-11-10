using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;

namespace PRG282_Project.StudentLayer
{
    internal class SummaryReport
    {
        string filePath = @"C:\Users\dariu\source\repos\PRG282-Project\PRG282 Project\StudentLayer\Summary.txt";
        string filePathStudent = @"C:\Users\dariu\source\repos\PRG282-Project\PRG282 Project\StudentLayer\students.txt";
        public void Summary() 
        {
            List<string> linesStudent = new List<string>();
            List<string> lines = new List<string>();
            if (File.Exists(filePath)) 
            {
             
                lines = File.ReadAllLines(filePath).ToList();

                
                linesStudent = File.ReadAllLines(filePathStudent).ToList();
            }
            
            int count = linesStudent.Count;
            int allAge = 0;
            decimal avgAge = 0;
            foreach (var item in linesStudent)
            {
                string getAge = item.Substring(item.IndexOf(",")+1 , item.Length - item.IndexOf(",")-1);
                getAge = getAge.Substring(getAge.IndexOf(",")+1, 3); 
               
               
                allAge +=  Convert.ToInt32(getAge.Trim());
            }
            
            avgAge = allAge/count;
           
            lines.Add($"{count}, {avgAge}");
            File.WriteAllLines(filePath, lines);
            MessageBox.Show($"This many students {count}\r The avarage age is {avgAge}");
        }
        
    }
}
