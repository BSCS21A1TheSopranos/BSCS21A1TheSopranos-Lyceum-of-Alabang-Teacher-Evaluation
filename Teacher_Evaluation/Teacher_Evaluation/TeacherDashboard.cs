using ClassLibrary1;
using Microsoft.VisualBasic.Logging;
using Services;
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
    public partial class TeacherDashboard : Form
    {
        private string profId;
        public TeacherDashboard(string profId)
        {
            InitializeComponent();
            this.profId = profId;
            label10.Text = StudentTeacherData.CountStudentsByProfessor(profId);
            label11.Text = StudentTeacherData.CountStatusDoneForProfessor(profId);
            label12.Text = StudentTeacherData.CountUniqueSubjectsForProfessor(profId);
            label13.Text = TeacherFeedbackService.CalculateCreditPoints(profId);
            label14.Text = TeacherDataHolder.GetTeacherNameByProfID(profId);
            if (TeacherFeedbackService.feedbacksdata.ContainsKey(profId))
            {
                foreach (var feedbackEntry in TeacherFeedbackService.feedbacksdata[profId])
                {
                    dataGridView1.Rows.Add(feedbackEntry);
                }
            }

        }


        private void panel9_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult response = MessageBox.Show(
            "Are you sure that you want to exit the application?",
            "EXIT THE APP",
            MessageBoxButtons.YesNo,
            MessageBoxIcon.Question
);

            if (response == DialogResult.Yes)
            {
                LoginForm loginForm = new LoginForm();
                this.Hide();
                loginForm.ShowDialog();
            }

        }

        private void TeacherDashboard_Load(object sender, EventArgs e)
        {

        }

        private void panel8_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label14_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
