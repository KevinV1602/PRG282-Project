﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace PRG282_Project.DataHandeling
{
    internal class AddNewStudent
    {
       // string path = @"C:\Users\dariu\source\repos\PRG282-Project\PRG282 Project\StudentLayer\students.txt";
        string path = @"C:\Users\squis\source\repos\PRG282-Project\PRG282 Project\StudentLayer\students.txt";

        public void AddStudent(string name, string age, string course)
        {
            try
            {
                List<string> lines = new List<string>();
                lines = File.ReadAllLines(path).ToList();
                lines.Add($"{getNewID()}, {name}, {age}, {course}");
                File.WriteAllLines(path, lines);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message + "file not found");
            }
        }

        public string getNewID()
        {
            string newID = "";
            try
            {
                List<string> lines = new List<string>();
                lines = File.ReadAllLines(path).ToList();
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

        public List<string> Read()
        {
            List<string> lines = new List<string>();
            try
            {                
                lines = File.ReadAllLines(path).ToList();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message + "file not found");
            }
            
            return lines;
        }
    }
}
