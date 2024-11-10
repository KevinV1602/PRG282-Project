using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace PRG282_Project.DataHandeling
{
    public class UpdateStudentInfo
    {
        private string filePath = @"C:\Users\zoe27\source\repos\PRG282-Project\PRG282 Project\StudentLayer\students.txt";

        public void UpdateStudent(string ID, string Name, int Age, string Course)
        {
            var lines = File.ReadAllLines(filePath).ToList();
            for (int i = 0; i < lines.Count; i++)
            {
                var fields = lines[i].Split(',');
                if (fields[0].Trim() == ID)
                {
                    lines[i] = $"{ID}, {Name}, {Age}, {Course}";
                    break;
                }
            }
            File.WriteAllLines(filePath, lines);
        }
    }
    public class Student
    {
        public string ID { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public string Course { get; set; }
    }
}
