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

namespace Teacher_Evaluation
{
    public partial class StudentForm : Form
    {

        static string databasePath = System.IO.Path.Combine(Application.StartupPath, "Teacher_Evaluation_Database.accdb");
        private static string connectionString = $@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source={databasePath}";

        public StudentForm()
        {
            InitializeComponent();
            LoadForm();
        }

        public void LoadForm()
        {
            try
            {

                string query = "SELECT * FROM Students";


                using (OleDbConnection connection = new OleDbConnection(connectionString))
                {

                    OleDbDataAdapter adapter = new OleDbDataAdapter(query, connection);


                    DataTable dataTable = new DataTable();


                    adapter.Fill(dataTable);


                    dataGridView1.DataSource = dataTable;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void StudentForm_Load(object sender, EventArgs e)
        {

        }
    }
}
