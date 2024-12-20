﻿using ClassLibrary1;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Teacher_Evaluation
{
    public partial class StudentForm : Form
    {

        public StudentForm()
        {
            InitializeComponent();
            foreach (var student in StudentDataHolder.Students)
            {
                dataGridView1.Rows.Add(student.Value.StudentID, student.Value.Email, "Cute");
            }
        }

        private void StudentForm_Load(object sender, EventArgs e)
        {
            dataGridView1.DefaultCellStyle.SelectionBackColor = Color.FromArgb(31, 51, 92);
            dataGridView1.DefaultCellStyle.SelectionForeColor = Color.White;
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Addstudent addstudent = new Addstudent();
            addstudent.ShowDialog();
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow selectedRow = dataGridView1.Rows[e.RowIndex];
            string profID = selectedRow.Cells["StudentID"].Value.ToString();
            MapStudentsTeachers mapStudentsTeachers = new MapStudentsTeachers(profID);
            mapStudentsTeachers.Show();
            this.Hide();

        }
    }
}
