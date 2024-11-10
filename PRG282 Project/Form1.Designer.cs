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
            this.StudentRecordH = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.DBTable)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAddStudent
            // 
            this.btnAddStudent.Location = new System.Drawing.Point(806, 560);
            this.btnAddStudent.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAddStudent.Name = "btnAddStudent";
            this.btnAddStudent.Size = new System.Drawing.Size(134, 48);
            this.btnAddStudent.TabIndex = 0;
            this.btnAddStudent.Text = "Add Student";
            this.btnAddStudent.UseVisualStyleBackColor = true;
            this.btnAddStudent.Click += new System.EventHandler(this.btnAddStudent_Click);
            // 
            // btnDeleteStudent
            // 
            this.btnDeleteStudent.Location = new System.Drawing.Point(420, 136);
            this.btnDeleteStudent.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnDeleteStudent.Name = "btnDeleteStudent";
            this.btnDeleteStudent.Size = new System.Drawing.Size(143, 34);
            this.btnDeleteStudent.TabIndex = 1;
            this.btnDeleteStudent.Text = "Delete Student";
            this.btnDeleteStudent.UseVisualStyleBackColor = true;
            this.btnDeleteStudent.Click += new System.EventHandler(this.btnDeleteStudent_Click);
            // 
            // btnUpdateStudent
            // 
            this.btnUpdateStudent.Location = new System.Drawing.Point(584, 136);
            this.btnUpdateStudent.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnUpdateStudent.Name = "btnUpdateStudent";
            this.btnUpdateStudent.Size = new System.Drawing.Size(143, 34);
            this.btnUpdateStudent.TabIndex = 2;
            this.btnUpdateStudent.Text = "Update Student";
            this.btnUpdateStudent.UseVisualStyleBackColor = true;
            this.btnUpdateStudent.Click += new System.EventHandler(this.btnUpdateStudent_Click);
            // 
            // btnViewStudent
            // 
            this.btnViewStudent.Location = new System.Drawing.Point(86, 138);
            this.btnViewStudent.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnViewStudent.Name = "btnViewStudent";
            this.btnViewStudent.Size = new System.Drawing.Size(143, 34);
            this.btnViewStudent.TabIndex = 3;
            this.btnViewStudent.Text = "View All Students";
            this.btnViewStudent.UseVisualStyleBackColor = true;
            this.btnViewStudent.Click += new System.EventHandler(this.btnViewStudent_Click);
            // 
            // btnSummary
            // 
            this.btnSummary.Location = new System.Drawing.Point(254, 136);
            this.btnSummary.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSummary.Name = "btnSummary";
            this.btnSummary.Size = new System.Drawing.Size(143, 36);
            this.btnSummary.TabIndex = 4;
            this.btnSummary.Text = "Summary Report";
            this.btnSummary.UseVisualStyleBackColor = true;
            this.btnSummary.Click += new System.EventHandler(this.button5_Click);
            // 
            // DBTable
            // 
            this.DBTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DBTable.Location = new System.Drawing.Point(86, 189);
            this.DBTable.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.DBTable.Name = "DBTable";
            this.DBTable.RowHeadersWidth = 51;
            this.DBTable.RowTemplate.Height = 24;
            this.DBTable.Size = new System.Drawing.Size(641, 409);
            this.DBTable.TabIndex = 5;
            this.DBTable.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            this.DBTable.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // txName
            // 
            this.txName.Location = new System.Drawing.Point(851, 394);
            this.txName.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txName.Name = "txName";
            this.txName.Size = new System.Drawing.Size(132, 22);
            this.txName.TabIndex = 6;
            this.txName.TextChanged += new System.EventHandler(this.txName_TextChanged);
            // 
            // txAge
            // 
            this.txAge.Location = new System.Drawing.Point(851, 447);
            this.txAge.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txAge.Name = "txAge";
            this.txAge.Size = new System.Drawing.Size(132, 22);
            this.txAge.TabIndex = 7;
            this.txAge.TextChanged += new System.EventHandler(this.txAge_TextChanged);
            // 
            // txCourse
            // 
            this.txCourse.Location = new System.Drawing.Point(851, 508);
            this.txCourse.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txCourse.Name = "txCourse";
            this.txCourse.Size = new System.Drawing.Size(132, 22);
            this.txCourse.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(737, 394);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 16);
            this.label1.TabIndex = 9;
            this.label1.Text = "Full Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(773, 447);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 16);
            this.label2.TabIndex = 10;
            this.label2.Text = "Age";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(755, 508);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 16);
            this.label3.TabIndex = 11;
            this.label3.Text = "Course";
            // 
            // txId
            // 
            this.txId.Location = new System.Drawing.Point(758, 260);
            this.txId.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txId.Name = "txId";
            this.txId.Size = new System.Drawing.Size(132, 22);
            this.txId.TabIndex = 12;
            this.txId.TextChanged += new System.EventHandler(this.txId_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(755, 231);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(20, 16);
            this.label4.TabIndex = 13;
            this.label4.Text = "ID";
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(912, 231);
            this.btnSearch.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(165, 51);
            this.btnSearch.TabIndex = 14;
            this.btnSearch.Text = "Search Student";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // StudentRecordH
            // 
            this.StudentRecordH.AutoSize = true;
            this.StudentRecordH.Font = new System.Drawing.Font("Microsoft Sans Serif", 28.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StudentRecordH.ForeColor = System.Drawing.SystemColors.Desktop;
            this.StudentRecordH.Location = new System.Drawing.Point(248, 53);
            this.StudentRecordH.Name = "StudentRecordH";
            this.StudentRecordH.Size = new System.Drawing.Size(453, 68);
            this.StudentRecordH.TabIndex = 15;
            this.StudentRecordH.Text = "Student Record";
            this.StudentRecordH.Click += new System.EventHandler(this.label5_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1090, 647);
            this.Controls.Add(this.StudentRecordH);
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
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "MainForm";
            this.Text = "StudentRecord";
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DBTable)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void txId_TextChanged(object sender, EventArgs e)
        {
            throw new NotImplementedException();
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
        private Label StudentRecordH;
    }
}

