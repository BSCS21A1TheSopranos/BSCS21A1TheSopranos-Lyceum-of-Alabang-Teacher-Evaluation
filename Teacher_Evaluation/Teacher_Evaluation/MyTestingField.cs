using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ClassLibrary1;

namespace Teacher_Evaluation
{
    public partial class MyTestingField : Form
    {
        public MyTestingField()
        {
            InitializeComponent();
            IDataSaveandRetrieve repository;
            //string jsonStudentsFilePath = System.IO.Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "..", "..", "..", "..", "students.json");
            //repository = new JsonDataSaveandRetrieve(jsonStudentsFilePath);
            string databasePath = System.IO.Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "..", "..", "..", "..", "Teacher_Evaluation_Database.accdb");
            repository = new MSAcessDataSaveandRetrieve(databasePath);
            StudentDataHolder.LoadStudents(repository);
            foreach (var student in StudentDataHolder.Students)
            {
                dataGridView1.Rows.Add(student.Value.StudentID, student.Value.Password, student.Value.Email);
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            LoginForm login = new LoginForm();
            login.ShowDialog();
            this.Hide();
        }
    }
}
