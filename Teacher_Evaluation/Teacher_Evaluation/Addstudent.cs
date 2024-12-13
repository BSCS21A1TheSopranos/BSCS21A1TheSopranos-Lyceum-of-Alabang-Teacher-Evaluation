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
                if (!StudentDataHolder.Students.ContainsKey(textBox1.Text))
                {
                    if (textBox2.TextLength == 0)
                    {
                        notif.Visible = true;
                        notif.Text = ("Please fill the blank");
                    }
                    else if (textBox3.Text != textBox4.Text)
                    {
                        notif.Visible = true;
                        notif.Text = ("Password and Confirm password mismatch");
                    }
                    else
                    {
                        var newstudent = new Student(textBox1.Text, validationClass.encryptpassword(textBox3.Text), textBox2.Text, "Student");
                        StudentDataHolder.AddStudent(newstudent);
                        MSAcessDataSaveandRetrieve ms = new MSAcessDataSaveandRetrieve();
                        ms.SaveStudents();
                        notif.Visible = true;
                        notif.Text = ("Account has been Saved");
                    }
                }
                else
                {
                    notif.Visible = true;
                    notif.Text = ("Student Already Exist");
                }
            }
            else
            {
                notif.Visible = true;
                notif.Text = ("Invalid Id ####-##");
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
