using PRG282_Project.DataHandeling;
using System.Windows.Forms;
using System;

namespace PRG282_Project
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        /// 
      /*  InitializeComponent();
        viewAllStudents = new ViewAllStudents(dataGridViewStudents); // Pass DataGridView to the handler
        private void btnViewStudent_Click(object sender, EventArgs e)
        {
            viewAllStudents.DisplayStudents();
        }*/

        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }


        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnAddStudent = new System.Windows.Forms.Button();
            this.btnDeleteStudent = new System.Windows.Forms.Button();
            this.btnUpdateStudent = new System.Windows.Forms.Button();
            this.btnViewStudent = new System.Windows.Forms.Button();
            this.btnSummary = new System.Windows.Forms.Button();
            this.DBTable = new System.Windows.Forms.DataGridView();
            this.txName = new System.Windows.Forms.TextBox();
            this.txAge = new System.Windows.Forms.TextBox();
            this.txCourse = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txId = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnSearch = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DBTable)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAddStudent
            // 
            this.btnAddStudent.Location = new System.Drawing.Point(28, 284);
            this.btnAddStudent.Margin = new System.Windows.Forms.Padding(2);
            this.btnAddStudent.Name = "btnAddStudent";
            this.btnAddStudent.Size = new System.Drawing.Size(148, 37);
            this.btnAddStudent.TabIndex = 0;
            this.btnAddStudent.Text = "Add Student";
            this.btnAddStudent.UseVisualStyleBackColor = true;
            this.btnAddStudent.Click += new System.EventHandler(this.btnAddStudent_Click);
            // 
            // btnDeleteStudent
            // 
            this.btnDeleteStudent.Location = new System.Drawing.Point(180, 284);
            this.btnDeleteStudent.Margin = new System.Windows.Forms.Padding(2);
            this.btnDeleteStudent.Name = "btnDeleteStudent";
            this.btnDeleteStudent.Size = new System.Drawing.Size(146, 37);
            this.btnDeleteStudent.TabIndex = 1;
            this.btnDeleteStudent.Text = "Delete Student";
            this.btnDeleteStudent.UseVisualStyleBackColor = true;
            this.btnDeleteStudent.Click += new System.EventHandler(this.btnDeleteStudent_Click);
            // 
            // btnUpdateStudent
            // 
            this.btnUpdateStudent.Location = new System.Drawing.Point(330, 284);
            this.btnUpdateStudent.Margin = new System.Windows.Forms.Padding(2);
            this.btnUpdateStudent.Name = "btnUpdateStudent";
            this.btnUpdateStudent.Size = new System.Drawing.Size(130, 37);
            this.btnUpdateStudent.TabIndex = 2;
            this.btnUpdateStudent.Text = "Update Student";
            this.btnUpdateStudent.UseVisualStyleBackColor = true;
            this.btnUpdateStudent.Click += new System.EventHandler(this.btnUpdateStudent_Click);
            // 
            // btnViewStudent
            // 
            this.btnViewStudent.Location = new System.Drawing.Point(450, 11);
            this.btnViewStudent.Margin = new System.Windows.Forms.Padding(2);
            this.btnViewStudent.Name = "btnViewStudent";
            this.btnViewStudent.Size = new System.Drawing.Size(107, 28);
            this.btnViewStudent.TabIndex = 3;
            this.btnViewStudent.Text = "View All Students";
            this.btnViewStudent.UseVisualStyleBackColor = true;
            this.btnViewStudent.Click += new System.EventHandler(this.btnViewStudent_Click);
            // 
            // btnSummary
            // 
            this.btnSummary.Location = new System.Drawing.Point(453, 53);
            this.btnSummary.Margin = new System.Windows.Forms.Padding(2);
            this.btnSummary.Name = "btnSummary";
            this.btnSummary.Size = new System.Drawing.Size(104, 29);
            this.btnSummary.TabIndex = 4;
            this.btnSummary.Text = "Summary Report";
            this.btnSummary.UseVisualStyleBackColor = true;
            this.btnSummary.Click += new System.EventHandler(this.button5_Click);
            // 
            // DBTable
            // 
            this.DBTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DBTable.Location = new System.Drawing.Point(40, 10);
            this.DBTable.Margin = new System.Windows.Forms.Padding(2);
            this.DBTable.Name = "DBTable";
            this.DBTable.RowHeadersWidth = 51;
            this.DBTable.RowTemplate.Height = 24;
            this.DBTable.Size = new System.Drawing.Size(380, 232);
            this.DBTable.TabIndex = 5;
            this.DBTable.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            this.DBTable.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // txName
            // 
            this.txName.Location = new System.Drawing.Point(450, 181);
            this.txName.Name = "txName";
            this.txName.Size = new System.Drawing.Size(100, 20);
            this.txName.TabIndex = 6;
            // 
            // txAge
            // 
            this.txAge.Location = new System.Drawing.Point(450, 220);
            this.txAge.Name = "txAge";
            this.txAge.Size = new System.Drawing.Size(100, 20);
            this.txAge.TabIndex = 7;
            // 
            // txCourse
            // 
            this.txCourse.Location = new System.Drawing.Point(450, 259);
            this.txCourse.Name = "txCourse";
            this.txCourse.Size = new System.Drawing.Size(100, 20);
            this.txCourse.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(467, 165);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Full Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(467, 204);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(26, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "Age";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(467, 243);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "Course";
            // 
            // txId
            // 
            this.txId.Location = new System.Drawing.Point(450, 100);
            this.txId.Name = "txId";
            this.txId.Size = new System.Drawing.Size(100, 20);
            this.txId.TabIndex = 12;
            this.txId.TextChanged += new System.EventHandler(this.txId_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(467, 84);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(18, 13);
            this.label4.TabIndex = 13;
            this.label4.Text = "ID";
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(450, 126);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(107, 28);
            this.btnSearch.TabIndex = 14;
            this.btnSearch.Text = "Search Student";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(582, 350);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txId);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txCourse);
            this.Controls.Add(this.txAge);
            this.Controls.Add(this.txName);
            this.Controls.Add(this.DBTable);
            this.Controls.Add(this.btnSummary);
            this.Controls.Add(this.btnViewStudent);
            this.Controls.Add(this.btnUpdateStudent);
            this.Controls.Add(this.btnDeleteStudent);
            this.Controls.Add(this.btnAddStudent);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "MainForm";
            this.Text = "StudentRecord";
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DBTable)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            throw new NotImplementedException();
        }



        #endregion

        private System.Windows.Forms.Button btnAddStudent;
        private System.Windows.Forms.Button btnDeleteStudent;
        private System.Windows.Forms.Button btnUpdateStudent;
        private System.Windows.Forms.Button btnViewStudent;
        private System.Windows.Forms.Button btnSummary;
        private System.Windows.Forms.DataGridView DBTable;
        private System.Windows.Forms.TextBox txName;
        private System.Windows.Forms.TextBox txAge;
        private System.Windows.Forms.TextBox txCourse;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private TextBox txId;
        private Label label4;
        private Button btnSearch;
    }
}

