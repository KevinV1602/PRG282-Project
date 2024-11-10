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

        static string relativePath = @"..\..\StudentLayer\students.txt";
        string fullPath = Path.GetFullPath(relativePath);

        public void UpdateStudent(string ID, string Name, int Age, string Course)
        {
            

            var lines = File.ReadAllLines(fullPath).ToList();
            for (int i = 0; i < lines.Count; i++)
            {
                var fields = lines[i].Split(',');
                if (fields[0].Trim() == ID)
                {
                    lines[i] = $"{ID}, {Name}, {Age}, {Course}";
                    break;
                }
            }
            File.WriteAllLines(fullPath, lines);
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
