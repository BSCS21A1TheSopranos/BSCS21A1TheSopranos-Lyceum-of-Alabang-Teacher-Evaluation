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
    public partial class TeacherForm : Form
    {

        public TeacherForm()
        {
            InitializeComponent();
            foreach (var teacher in TeacherDataHolder.Teachers)
            {
                dataGridView1.Rows.Add(teacher.Value.ProfID, teacher.Value.Name, teacher.Value.Email);
            }
        }

        

        private void button1_Click(object sender, EventArgs e)
        {
            AddTeacher add = new AddTeacher();
            add.Show();
        }

        private void TeacherForm_Load(object sender, EventArgs e)
        {

        }

        private void TeacherForm_Resize(object sender, EventArgs e)
        {
            panel1.Width = this.ClientSize.Width;
            panel1.Height = this.ClientSize.Height;

            dataGridView1.Dock = DockStyle.Fill;

        }

        private void button3_Click(object sender, EventArgs e)
        {
           
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }
    }
}
