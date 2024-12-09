﻿namespace Teacher_Evaluation
{
    partial class StudentTeachers
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
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
            dataGridView1 = new DataGridView();
            button1 = new Button();
            Subject = new DataGridViewTextBoxColumn();
            Teacher = new DataGridViewTextBoxColumn();
            TeacherName = new DataGridViewTextBoxColumn();
            TeachersID = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Subject, Teacher, TeacherName, TeachersID });
            dataGridView1.Dock = DockStyle.Fill;
            dataGridView1.Location = new Point(0, 0);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.Size = new Size(800, 450);
            dataGridView1.TabIndex = 0;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            dataGridView1.CellDoubleClick += dataGridView1_CellDoubleClick;
            // 
            // button1
            // 
            button1.Location = new Point(706, 421);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 1;
            button1.Text = "Log Out";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // Subject
            // 
            Subject.HeaderText = "Subject";
            Subject.MinimumWidth = 6;
            Subject.Name = "Subject";
            Subject.ReadOnly = true;
            // 
            // Teacher
            // 
            Teacher.HeaderText = "Teacher";
            Teacher.MinimumWidth = 6;
            Teacher.Name = "Teacher";
            Teacher.ReadOnly = true;
            Teacher.Visible = false;
            // 
            // TeacherName
            // 
            TeacherName.HeaderText = "Teachers";
            TeacherName.MinimumWidth = 6;
            TeacherName.Name = "TeacherName";
            TeacherName.ReadOnly = true;
            // 
            // TeachersID
            // 
            TeachersID.HeaderText = "Column1";
            TeachersID.MinimumWidth = 6;
            TeachersID.Name = "TeachersID";
            TeachersID.ReadOnly = true;
            TeachersID.Visible = false;
            // 
            // StudentTeachers
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button1);
            Controls.Add(dataGridView1);
            Name = "StudentTeachers";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dataGridView1;
        private Button button1;
        private DataGridViewTextBoxColumn Subject;
        private DataGridViewTextBoxColumn Teacher;
        private DataGridViewTextBoxColumn TeacherName;
        private DataGridViewTextBoxColumn TeachersID;
    }
}