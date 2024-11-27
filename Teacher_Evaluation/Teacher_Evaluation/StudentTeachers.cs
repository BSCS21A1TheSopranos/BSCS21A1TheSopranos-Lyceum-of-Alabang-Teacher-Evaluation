using ClassLibrary1;
using System;
using System.Collections.Generic;
using System.Reflection.Emit;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Teacher_Evaluation
{
    public partial class StudentTeachers : Form
    {
        private string studentID;
        public StudentTeachers(string studentID)
        {
            this.studentID = studentID;
            InitializeComponent();
            foreach (var teacher in StudentTeacherData.studentTeacherData[studentID])
            {
                dataGridView1.Rows.Add(teacher.Subject, teacher.ProfID);
            }
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow selectedRow = dataGridView1.Rows[e.RowIndex];
            string teacherID = selectedRow.Cells["Teacher"].Value.ToString();
            string teacherSubject = selectedRow.Cells["Subject"].Value.ToString();
            Form2 form2 = new Form2(teacherID, teacherSubject, studentID);
            form2.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}