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
            LoadDataGridview();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (TeacherDataHolder.Teachers.ContainsKey(textBox1.Text))
            {
                StudentTeacherData.AddStudentTeacherRecord(studentID, textBox1.Text, textBox3.Text);
                LoadDataGridview();
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void LoadDataGridview()
        {
            dataGridView1.Rows.Clear();
            foreach (var teacher in StudentTeacherData.studentTeacherData[studentID])
            {
                dataGridView1.Rows.Add(teacher.Subject, teacher.ProfID);
            }
        }

        private void MapStudentsTeachers_Load(object sender, EventArgs e)
        {
            dataGridView1.DefaultCellStyle.SelectionBackColor = Color.FromArgb(31, 51, 92);
            dataGridView1.DefaultCellStyle.SelectionForeColor = Color.White;
        }
    }
}
