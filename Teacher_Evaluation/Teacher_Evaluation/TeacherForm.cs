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
    public partial class TeacherForm : Form
    {

        static string databasePath = System.IO.Path.Combine(Application.StartupPath, "Teacher_Evaluation_Database.accdb");
        private static string connectionString = $@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source={databasePath}";

        public TeacherForm()
        {
            InitializeComponent();
            this.Resize += TeacherForm_Resize;
            LoadForm();
        }

        public void LoadForm()
        {
            try
            {

                string query = "SELECT * FROM Prof";


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

        private void button1_Click(object sender, EventArgs e)
        {
            AddTeacher add = new AddTeacher();
            add.Show();
        }

        private void TeacherForm_Load(object sender, EventArgs e)
        {

        }

        private void TeacherForm_Resize(object sender, EventArgs e)
        {
            panel1.Width = this.ClientSize.Width;
            panel1.Height = this.ClientSize.Height;

            dataGridView1.Dock = DockStyle.Fill;

        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                using (OleDbConnection connection = new OleDbConnection(connectionString))
                {
                    connection.Open();

                    string query = "SELECT * FROM Prof";

                    using (OleDbCommand command = new OleDbCommand(query, connection))
                    using (OleDbDataReader reader = command.ExecuteReader())
                    {

                        string outputPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "ProfTable.txt");

                        using (StreamWriter writer = new StreamWriter(outputPath))
                        {
                            
                            for (int i = 0; i < reader.FieldCount; i++)
                            {
                                writer.Write(reader.GetName(i) + "\t");
                            }
                            writer.WriteLine();

                            while (reader.Read())
                            {
                                for (int i = 0; i < reader.FieldCount; i++)
                                {
                                    writer.Write(reader[i].ToString() + "\t");
                                }
                                writer.WriteLine();
                            }
                        }
                    }
                }

                MessageBox.Show("Data exported successfully to text file.");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}");
            }
        }
    }
}
