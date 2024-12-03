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
            Student student = new Student(textBox6.Text, textBox7.Text, textBox8.Text, "Student");
            RegistrationClass registration = new RegistrationClass();
            LoginForm loginForm = new LoginForm();

            if (!registration.validstudentNo(student))
            {
                textBox6.Text = "Invalid Format. It must be ####-##";
            }
            if (!registration.checkpassword(student)) {
                textBox7.Text = "Wrong Password";
            }
            if (!registration.validpaassword(textBox8.Text))
            {
                textBox8.Text = "Minimum of 8 characters with at least one uppercase, lowercase, number, and special character (@, $, !, %, *, ?, &).";
            }
            if (registration.validstudentNo(student) && (registration.validpaassword(textBox8.Text)))
            {
                registration.encryptpassword(textBox8.Text, student);
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
    }
}
