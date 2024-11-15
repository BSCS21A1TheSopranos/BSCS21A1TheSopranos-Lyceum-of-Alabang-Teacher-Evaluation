using System;
using System.Collections.Generic;
using System.Reflection.Emit;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Teacher_Evaluation
{
    public partial class Form1 : Form
    {
        public Form1(string studentID)
        {
            InitializeComponent();
            List<TeacherInfo> teachers = DatabaseConnection.GetStudentTeachers(studentID);
            foreach (var teacher in teachers)
            {
                dataGridView1.Rows.Add(teacher.Subject, teacher.Name);
            }
        }
    }
}
