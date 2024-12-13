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
            if (valid.validID(textBox2.Text))
            {
                if (!TeacherDataHolder.AddTeacherToDictionary(textBox2.Text, textBox3.Text, textBox1.Text, textBox2.Text))
                {
                    label5.Visible = true;
                }


               

            }

            

            if (string.IsNullOrWhiteSpace(textBox2.Text) && string.IsNullOrWhiteSpace(textBox2.Text) && string.IsNullOrWhiteSpace(textBox3.Text) && string.IsNullOrWhiteSpace(SetPword.Text))
            {
                EmailWarning.Visible = true;
                IDwarning.Visible = true;
                NameWarning.Visible = true;
                setPass.Visible = true;

                return;
            }

          
            if (string.IsNullOrWhiteSpace(textBox2.Text))
            {
                IDwarning.Visible = false;
                return;
            }

            if (string.IsNullOrWhiteSpace(textBox3.Text))
            {
                NameWarning.Visible = false;
                return;
            }

            if (string.IsNullOrWhiteSpace(textBox2.Text))
            {
                EmailWarning.Visible = false;
                return;
            }

            if(!string.IsNullOrWhiteSpace(textBox2.Text) && !string.IsNullOrWhiteSpace(textBox3.Text) && !string.IsNullOrWhiteSpace(textBox1.Text) && !string.IsNullOrWhiteSpace (SetPword.Text))
            {
                MSAcessDataSaveandRetrieve mS = new MSAcessDataSaveandRetrieve();
                mS.SaveAllTeachers();


                TeacherAdded?.Invoke();
                this.Close();
            }






        }

        private void AddTeacher_Load(object sender, EventArgs e)
        {

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

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void IDwarning_Click(object sender, EventArgs e)
        {

        }

        private void NameWarning_Click(object sender, EventArgs e)
        {

        }

        private void EmailWarning_Click(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            setPass.Visible = false;
            return;
        }
    }
}
