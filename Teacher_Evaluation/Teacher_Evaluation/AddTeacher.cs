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
            MessageBox.Show(textBox1.Text);
            MessageBox.Show(textBox2.Text);
            MessageBox.Show(textBox3.Text);
            TeacherDataHolder.AddTeacherToDictionary(textBox2.Text, textBox3.Text, textBox1.Text, textBox2.Text);
            MSAcessDataSaveandRetrieve mS = new MSAcessDataSaveandRetrieve();
            mS.SaveAllTeachers();


            TeacherAdded?.Invoke();

            this.Close();

        }

        private void AddTeacher_Load(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
