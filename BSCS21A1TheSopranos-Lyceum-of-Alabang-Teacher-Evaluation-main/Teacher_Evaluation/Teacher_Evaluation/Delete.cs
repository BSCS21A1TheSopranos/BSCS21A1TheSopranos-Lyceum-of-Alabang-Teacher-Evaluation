﻿using ClassLibrary1;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Teacher_Evaluation
{
    public partial class Delete : Form
    {
        public Delete()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Delete_Load(object sender, EventArgs e)
        {
            
        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            foreach (var teacher in StudentTeacherData.studentTeacherData["2022-18"])
            {
                MessageBox.Show(teacher.Subject, teacher.ProfID);
            }
            TeacherDataHolder.DeleteTeacherFromDictionary(textBox1.Text);
            MSAcessDataSaveandRetrieve ms = new MSAcessDataSaveandRetrieve();
            ms.SaveAllTeachers();
            foreach (var teacher in StudentTeacherData.studentTeacherData["2022-18"])
            {
            MessageBox.Show(teacher.Subject, teacher.ProfID);
            }
        }
    }
}
