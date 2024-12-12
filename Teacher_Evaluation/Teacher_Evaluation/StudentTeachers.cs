using ClassLibrary1;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

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
                string status = teacher.Status;
                var row = dataGridView1.Rows[dataGridView1.Rows.Add(teacher.Subject, teacher.ProfID)];
                if (status == "Done")
                {
                    row.DefaultCellStyle.BackColor = System.Drawing.Color.Green;
                }
            }
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow selectedRow = dataGridView1.Rows[e.RowIndex];
            string profID = selectedRow.Cells["Teacher"].Value.ToString();
            string status = null;
            foreach (var teacher in StudentTeacherData.studentTeacherData[studentID])
            {
                if (teacher.ProfID == profID)
                {
                    status = teacher.Status;
                    break;
                }
            }
            if (status == "Done")
            {
                return;
            }

            string teacherSubject = selectedRow.Cells["Subject"].Value.ToString();
            Form2 form2 = new Form2(profID, teacherSubject, studentID);
            form2.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
