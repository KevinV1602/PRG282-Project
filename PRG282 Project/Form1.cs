
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
            
        }

        DataTable myDataTable = new DataTable();
        private void MainForm_Load(object sender, EventArgs e)
        {


            myDataTable.Columns.Add("ID", typeof(string));
            myDataTable.Columns.Add("Name", typeof(string));
            myDataTable.Columns.Add("Age", typeof(string));
            myDataTable.Columns.Add("Course", typeof(string));

            myDataTable.Rows.Add("S001", "Jane Smith", "25", "English Literature");

            DBTable.DataSource = myDataTable;

            dataGridViewStudents = DBTable;
            // Initialize ViewAllStudents with the DataGridView instance from MainForm
            viewAllStudents = new ViewAllStudents(myDataTable);
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
            myDataTable.Clear();
            myDataTable = viewAllStudents.DisplayStudents();
            DBTable.DataSource = myDataTable;
        }


        private void btnDeleteStudent_Click(object sender, EventArgs e)
        {
            // Create an instance of DeleteStudent and delete the selected student
            var deleteStudent = new DeleteStudent(dataGridViewStudents, viewAllStudents);
            deleteStudent.DeleteSelectedStudent();
        }
        private void btnAddStudent_Click(object sender, EventArgs e)
        {
            AddNewStudent addNewStudent = new AddNewStudent();
            DialogResult Result = MessageBox.Show($"Are you sure you want to add this Student " +
                $"\rStudentID: {addNewStudent.getNewID()}\r Name: {txName.Text}\r " +
                $"Age: {txAge.Text}\r " +
                $"Course: {txCourse.Text}", "Add Student", MessageBoxButtons.OKCancel);
            if (Result == DialogResult.OK)
            {
                addNewStudent.AddStudent(txName.Text, txAge.Text, txCourse.Text);
                MessageBox.Show("Student Added");
            }
            else if (Result == DialogResult.Cancel)
            {
                MessageBox.Show("Student Add Canceled");
            }
        }

    }
}
