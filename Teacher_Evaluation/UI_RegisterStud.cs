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
            Student student = new Student(textBox1.Text, textBox3.Text, textBox2.Text);
            RegistrationClass registration = new RegistrationClass();
            LoginForm loginForm = new LoginForm();

            if (!registration.validstudentNo(student))
            {
                textBox3.Text = "Invalid Format. It must be ####-##";

            }
            if (!registration.validpaassword(student))
            {
                textBox2.Text = "Minimum of 8 characters with at least one uppercase, lowercase, number, and special character (@, $, !, %, *, ?, &).";
            }
            if (registration.validstudentNo(student) && (registration.validpaassword(student)))
            {
                registration.encryptpassword(student);
                DatabaseConnection.RegisterPassword(student.StudentNumber, student.Password);
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

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                textBox2.UseSystemPasswordChar = false;
                textBox4.UseSystemPasswordChar = false;
            }
            else
            {
                textBox2.UseSystemPasswordChar = true;
                textBox4.UseSystemPasswordChar = true;
            }
        }
    }
}
