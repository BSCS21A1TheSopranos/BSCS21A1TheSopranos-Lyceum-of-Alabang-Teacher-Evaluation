using ClassLibrary1;
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
    public partial class Addstudent : Form
    {
        public Addstudent()
        {
            InitializeComponent();
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {

            Validation validationClass = new Validation();
            if (validationClass.validID(textBox1.Text))
            {
                if (textBox3.Text != textBox4.Text)
                {
                    notif.Text = ("Password and Confirm Password Mismatch");
                }
                else
                {
                    var newstudent = new Student(textBox1.Text, validationClass.encryptpassword(textBox3.Text), textBox2.Text, "Student");
                    StudentDataHolder.AddStudent(newstudent);
                    MSAcessDataSaveandRetrieve ms = new MSAcessDataSaveandRetrieve();
                    ms.SaveStudents();
                }
            }
        }

        private void Addstudent_Load(object sender, EventArgs e)
        {

        }

        private void notif_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
