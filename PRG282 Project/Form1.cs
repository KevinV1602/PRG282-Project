
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using PRG282_Project.DataHandeling;
using PRG282_Project.StudentLayer;

namespace PRG282_Project
{
    public partial class MainForm : Form
    {/// <summary>
     /// /
     /// </summary>
        private ViewAllStudents viewAllStudents;
        private DataGridView dataGridViewStudents;

        public MainForm()
        {
            InitializeComponent();
            dataGridViewStudents = DBTable;
            // Initialize ViewAllStudents with the DataGridView instance from MainForm
            viewAllStudents = new ViewAllStudents(dataGridViewStudents);
        }

        DataTable myDataTable = new DataTable();
        private void MainForm_Load(object sender, EventArgs e)
        {


            myDataTable.Columns.Add("ID", typeof(string));
            myDataTable.Columns.Add("Name", typeof(string));
            myDataTable.Columns.Add("Age", typeof(int));
            myDataTable.Columns.Add("Course", typeof(string));

            myDataTable.Rows.Add("S001", "Jane Smith", "25", "English Literature");

            DBTable.DataSource = myDataTable;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int indexrow;
            indexrow = e.RowIndex;

            DataGridViewRow row = DBTable.Rows[indexrow];

            txName.Text = row.Cells[1].Value.ToString();
            txAge.Text = row.Cells[2].Value.ToString();
            txCourse.Text = row.Cells[3].Value.ToString();
        }


        private void btnViewStudent_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Button Clicked"); // Debug: Check if event is triggered
            viewAllStudents.DisplayStudents();
        }


        private void btnDeleteStudent_Click(object sender, EventArgs e)
        {
            // Create an instance of DeleteStudent and delete the selected student
            var deleteStudent = new DeleteStudent(dataGridViewStudents, viewAllStudents);
            deleteStudent.DeleteSelectedStudent();
        }


    }
}
