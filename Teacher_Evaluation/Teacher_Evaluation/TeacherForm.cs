using ClassLibrary1;
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
            LoadTeacherData();

        }



        private void button1_Click(object sender, EventArgs e)
        {
            AddTeacher add = new AddTeacher();
            add.TeacherAdded += OnTeacherAdded;
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

        private void OnTeacherAdded()
        {
            LoadTeacherData(); // Reload the data grid
        }

        private void LoadTeacherData()
        {
            dataGridView1.Rows.Clear(); // Clear existing rows
            foreach (var teacher in TeacherDataHolder.Teachers)
            {
                dataGridView1.Rows.Add(teacher.Value.ProfID, teacher.Value.Name, teacher.Value.Email);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Delete delete = new Delete();
            delete.ShowDialog();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
