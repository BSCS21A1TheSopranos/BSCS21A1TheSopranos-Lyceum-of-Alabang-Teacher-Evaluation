using System;
using System.Collections.Generic;
using System.Reflection.Emit;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Teacher_Evaluation
{
    public partial class Form1 : Form
    {
        private string studentID;
        public Form1(string studentID)
        {
            this.studentID = studentID;
            InitializeComponent();
            List<TeacherInfo> teachers = DatabaseConnection.GetStudentTeachers(studentID);
            foreach (var teacher in teachers)
            {
                dataGridView1.Rows.Add(teacher.Subject, teacher.Name, teacher.TeacherID);
            }
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
                DataGridViewRow selectedRow = dataGridView1.Rows[e.RowIndex];
                string teacherID = selectedRow.Cells["TeachersID"].Value.ToString();
                string teacherSubject = selectedRow.Cells["Subject"].Value.ToString();
                Form2 form2 = new Form2(teacherID, teacherSubject, studentID);
                form2.Show();
                this.Hide();
        }
    }
}
