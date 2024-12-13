using ClassLibrary1;
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
    public partial class MapStudentsTeachers : Form
    {
        private string studentID;
        public MapStudentsTeachers(string studentID)
        {
            InitializeComponent();
            this.studentID = studentID;
            foreach (var teacher in StudentTeacherData.studentTeacherData[studentID])
            {
                dataGridView1.Rows.Add(teacher.Subject, teacher.ProfID);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            StudentTeacherData.AddStudentTeacherRecord(studentID, textBox1.Text, textBox3.Text);
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
