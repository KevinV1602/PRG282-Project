using PRG282_Project.DataHandeling;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PRG282_Project
{
    internal static class Program
    {
        //test
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            string folder = "StudentLayer";
            string fileName = "students.txt";
            string fullPath = Path.Combine(folder, fileName);

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainForm());
        }
    }
}




