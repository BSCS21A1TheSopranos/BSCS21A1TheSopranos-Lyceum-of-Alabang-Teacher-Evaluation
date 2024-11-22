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

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                using (OleDbConnection connection = new OleDbConnection(connectionString))
                {
                    connection.Open();

                    string query = "SELECT * FROM Students";

                    using (OleDbCommand command = new OleDbCommand(query, connection))
                    using (OleDbDataReader reader = command.ExecuteReader())
                    {

                        string outputPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "StudentsTable.txt");

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

        private void button2_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0) 
            {
                
                var value = dataGridView1.SelectedRows[0].Cells["StudentID"].Value;

                
                if (value == null || string.IsNullOrWhiteSpace(value.ToString()))
                {
                    MessageBox.Show("The selected row does not contain a valid StudentID.", "Invalid Data", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                string selectedId = value.ToString(); 

                
                var result = MessageBox.Show(
                    "Are you sure you want to delete this record?",
                    "Confirm Deletion",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Warning);

                if (result == DialogResult.Yes)
                {
                    try
                    {
                        using (OleDbConnection connection = new OleDbConnection(connectionString))
                        {
                            connection.Open();

                            string deleteQuery = "DELETE FROM Students WHERE StudentID = @StudentID";

                            using (OleDbCommand command = new OleDbCommand(deleteQuery, connection))
                            {
                                
                                command.Parameters.AddWithValue("@ProfID", selectedId);
                                int rowsAffected = command.ExecuteNonQuery();

                                if (rowsAffected > 0)
                                {
                                    MessageBox.Show("Record deleted successfully.");
                                    LoadForm();
                                }
                                else
                                {
                                    MessageBox.Show("The record could not be found or has already been deleted.");
                                }
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"An error occurred while deleting the record: {ex.Message}");
                    }
                }
            }
            else
            {
                MessageBox.Show("Please select a row to delete.");
            }
        }
    }
}
