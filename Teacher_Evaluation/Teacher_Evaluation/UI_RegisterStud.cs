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
            if (registration.validstudentNo(student))
            {
                LoginForm loginForm = new LoginForm();
                loginForm.Show();
                this.Close();
            }
            else {
                textBox3.Text = "Inavalid Format. must be ####-##";
            }
           
        }
    }
}
