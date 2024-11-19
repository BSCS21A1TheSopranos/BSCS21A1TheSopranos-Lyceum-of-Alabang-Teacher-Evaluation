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
    public partial class Admin : Form
    {
        public Admin()
        {
            InitializeComponent();
        }

        public void LoadForm(object Form)
        {
            if (this.mainpanel.Controls.Count > 0)
                this.mainpanel.Controls.RemoveAt(0);
            Form f = Form as Form;
            f.TopLevel = false;
            f.Dock = DockStyle.Fill;
            this.mainpanel.Controls.Add(f);
            this.mainpanel.Tag = f;
            f.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            LoadForm(new StudentForm());
        }

        private void button1_Click(object sender, EventArgs e)
        {
            LoadForm(new Dashboard());
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Admin_Load(object sender, EventArgs e)
        {

        }

        private void Admin_Load_1(object sender, EventArgs e)
        {

        }

        private void mainpanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            LoadForm(new TeacherForm());
        }

        private void button4_Click(object sender, EventArgs e)
        {
            LoadForm(new Survey());
        }

        private void button5_Click(object sender, EventArgs e)
        {
            DialogResult response = MessageBox.Show(
        "Are you sure that you want to exit the application?",
        "EXIT THE APP",
        MessageBoxButtons.YesNo,
        MessageBoxIcon.Question
    );

            if (response == DialogResult.Yes)
            {
                this.Close();
            }
        }
    }
}
