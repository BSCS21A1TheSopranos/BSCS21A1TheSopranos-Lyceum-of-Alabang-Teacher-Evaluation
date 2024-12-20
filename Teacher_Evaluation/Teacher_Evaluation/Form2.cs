﻿using ClassLibrary1;
using Services;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Teacher_Evaluation
{
    public partial class Form2 : Form
    {
        private string teacherid;
        private string teachername;
        private string studentid;

        public Form2(string teacherid, string teachername, string studentid)
        {
            this.teacherid = teacherid;
            this.teachername = teachername;
            this.studentid = studentid;
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string currentDateTime = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
            StudentTeacherData.UpdateStatusInDictionary(studentid, teacherid);
            TeacherFeedbackService.AddFeedback(teacherid, textBox1.Text, studentid, currentDateTime);
            StudentTeachers form1 = new StudentTeachers(studentid);
            form1.Show();
            this.Close();
        }


        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
