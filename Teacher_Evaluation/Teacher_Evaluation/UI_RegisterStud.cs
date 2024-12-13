using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using ClassLibrary1;
using Services;
namespace Teacher_Evaluation
{
    public partial class UI_RegisterStud : Form
    {
        public UI_RegisterStud()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Validation validation = new Validation();
            RegistrationClass registration = new RegistrationClass();
            LoginForm loginForm = new LoginForm();

            if (!validation.validID(textBox6.Text))
            {
                notif1.Visible = true;
                notif1.Text = "Account Not Found";
            }
            if (!validation.checkpassword(textBox7.Text, textBox6.Text))
            {
                notif2.Visible = true;
                notif2.Text = "Wrong Password";
            }
            if (!validation.validpaassword(textBox8.Text))
            {
                notif3.Visible = true;
                notif3.Text = "Password must be 8+ characters with uppercase, lowercase, number, and (@$!%*?&).";
            }
            if (validation.validID(textBox6.Text) && (validation.validpaassword(textBox8.Text)) && (validation.checkpassword(textBox7.Text, textBox6.Text)))
            {
                Student student = new Student(textBox6.Text, validation.encryptpassword(textBox8.Text), StudentDataHolder.Students[textBox6.Text].Email, "Student");
                RegistrationClass.Update(student);
                loginForm.Show();
                this.Close();
            }

        }

        private void UI_RegisterStud_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            LoginForm loginForm = new LoginForm();
            loginForm.Show();
            this.Close();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                textBox7.UseSystemPasswordChar = false;
                textBox8.UseSystemPasswordChar = false;
            }
            else
            {
                textBox7.UseSystemPasswordChar = true;
                textBox8.UseSystemPasswordChar = true;
            }
        }

        private void notif_Click(object sender, EventArgs e)
        {

        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
