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
            LoadForm(new Dashboard());
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

        private void btnMinimize_Click(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Normal)
            {
                this.WindowState = FormWindowState.Maximized;
            }
            else
            {
                this.WindowState = FormWindowState.Normal;
            }
        }

        private void panel2_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void buttonMaximize_Click(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Normal)
            {
                WindowState = FormWindowState.Maximized;
            }
            else
            {
                WindowState = FormWindowState.Normal;
            }
            if (mainpanel.Controls.Count > 0)
            {
                var form = mainpanel.Controls[0] as Form;
                if (form != null)
                {
                    form.Dock = DockStyle.Fill;
                    form.Refresh();
                }
            }
        }

        private void mainpanel_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void buttonMinimize_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void mainpanel_Resize(object sender, EventArgs e)
        {
            panel1.Width = this.ClientSize.Width;
            panel1.Height = this.ClientSize.Height;
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
                LoginForm loginForm = new LoginForm();
                this.Hide();
                loginForm.ShowDialog();
            }

        }

        private void button7_Click(object sender, EventArgs e)
        {

        }

        private void Admin_Load_2(object sender, EventArgs e)
        {
            LoadForm(new Dashboard());
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }
    }

}
