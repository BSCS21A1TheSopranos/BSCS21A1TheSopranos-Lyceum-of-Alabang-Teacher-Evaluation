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
using ClassLibrary1;
using Services;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Teacher_Evaluation
{

    public partial class AddTeacher : Form
    {

        static string databasePath = System.IO.Path.Combine(Application.StartupPath, "Teacher_Evaluation_Database.accdb");
        private static string connectionString = $@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source={databasePath}";
        public event Action TeacherAdded;
        public AddTeacher()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            Validation valid = new Validation();
            if (!string.IsNullOrWhiteSpace(textBox2.Text) && !string.IsNullOrWhiteSpace(textBox3.Text) && !string.IsNullOrWhiteSpace(textBox1.Text) && !string.IsNullOrWhiteSpace(SetPword.Text))
            {
                if (valid.validID(textBox2.Text))
                {
                    if (TeacherDataHolder.AddTeacherToDictionary(textBox2.Text, textBox3.Text, textBox1.Text, valid.encryptpassword(SetPword.Text))) { 

                        MSAcessDataSaveandRetrieve mS = new MSAcessDataSaveandRetrieve();
                        mS.SaveAllTeachers();
                        label5.Visible = true;
                        TeacherAdded?.Invoke();
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Already Exist");
                    }
                }
                else
                {
                    MessageBox.Show("Invalid Id ####-##");
                }
            }

            if(string.IsNullOrWhiteSpace(textBox2.Text) && string.IsNullOrWhiteSpace(textBox3.Text) && string.IsNullOrWhiteSpace(textBox1.Text) && string.IsNullOrWhiteSpace(SetPword.Text))
            {
                IDwarning.Visible = true;
                NameWarning.Visible = true;
                EmailWarning.Visible = true;    
                setPass.Visible = true;
            }

            else if (string.IsNullOrWhiteSpace(textBox3.Text) && string.IsNullOrWhiteSpace(textBox1.Text) && string.IsNullOrWhiteSpace(SetPword.Text))
            {
                NameWarning.Visible = true;
                EmailWarning.Visible= true;
                setPass.Visible= true;
            }

            else if(string.IsNullOrWhiteSpace(textBox1.Text) && string.IsNullOrWhiteSpace(SetPword.Text))
            {
                EmailWarning.Visible = true;
                setPass.Visible = true;
            }


            if (string.IsNullOrWhiteSpace(textBox2.Text) && string.IsNullOrWhiteSpace(textBox1.Text) && string.IsNullOrWhiteSpace(SetPword.Text))
            {
                IDwarning.Visible= true;
                EmailWarning.Visible = true;
                setPass.Visible= true;  
            }

            else if (string.IsNullOrWhiteSpace(textBox2.Text) && string.IsNullOrWhiteSpace(SetPword.Text))
            {
                IDwarning.Visible= true;
                setPass.Visible= true;
            }

            if (string.IsNullOrWhiteSpace(textBox2.Text) && string.IsNullOrWhiteSpace(textBox3.Text) && string.IsNullOrWhiteSpace(SetPword.Text))
            {
                IDwarning.Visible= true;
                NameWarning.Visible= true;
                setPass.Visible = true;
            }

            else if(string.IsNullOrWhiteSpace(textBox2.Text) && string.IsNullOrWhiteSpace(textBox3.Text))
            {
                IDwarning.Visible= true;
                NameWarning.Visible= true;
            }

            if(string.IsNullOrWhiteSpace(textBox2.Text) && string.IsNullOrWhiteSpace(textBox3.Text) && string.IsNullOrWhiteSpace(textBox1.Text))
            {
                IDwarning.Visible = true;
                NameWarning.Visible= true;
                EmailWarning.Visible= true;
            }

            

            if (string.IsNullOrWhiteSpace(textBox2.Text))
            {
                IDwarning.Visible = true;
                return;
            }

            if(string.IsNullOrWhiteSpace(textBox3.Text))
            {
                NameWarning.Visible = true;

                return;
            }

            if (string.IsNullOrWhiteSpace(textBox1.Text))
            {
                EmailWarning.Visible = true;
                return;
            }

            if (string.IsNullOrWhiteSpace(SetPword.Text))
            {
                setPass.Visible = true;

                return;
            }



        }
        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            IDwarning.Visible = false;
            return;
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            NameWarning.Visible = false;
            return;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            EmailWarning.Visible = false;
            return;
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            setPass.Visible = false;
            return;
        }
    }
}
