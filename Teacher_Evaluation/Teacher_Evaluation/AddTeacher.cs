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
    public partial class AddTeacher : Form
    {

        static string databasePath = System.IO.Path.Combine(Application.StartupPath, "Teacher_Evaluation_Database.accdb");
        private static string connectionString = $@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source={databasePath}";

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
            string professorId = textBox2.Text.Trim();
            string firstName = textBox3.Text.Trim();
            string lastName = textBox4.Text.Trim();
            string middleInitial = textBox5.Text.Trim();
            string subjectId = textBox6.Text.Trim();

            // Validate the inputs
            if (string.IsNullOrEmpty(professorId) || string.IsNullOrEmpty(firstName) ||
                string.IsNullOrEmpty(lastName) || string.IsNullOrEmpty(middleInitial) ||
                string.IsNullOrEmpty(subjectId))
            {
                MessageBox.Show("All fields must be filled out.");
                return;
            }


            try
            {
                using (OleDbConnection connection = new OleDbConnection(connectionString))
                {
                    connection.Open();
                    string query = "INSERT INTO Prof ([ProfID], [First Name], [Last Name], [MI], [SubjectID]) " +
                                   "VALUES (?, ?, ?, ?, ?)";

                    using (OleDbCommand command = new OleDbCommand(query, connection))
                    {
                        // Add parameters to the command
                        command.Parameters.Add(new OleDbParameter("@ProfID", professorId));
                        command.Parameters.Add(new OleDbParameter("@First Name", firstName));
                        command.Parameters.Add(new OleDbParameter("@Last Name", lastName));
                        command.Parameters.Add(new OleDbParameter("@MI", middleInitial));
                        command.Parameters.Add(new OleDbParameter("@SubjectID", subjectId));

                        // Execute the query
                        int rowsAffected = command.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Teacher data added successfully.");
                            this.Close(); // Close the form after adding the data
                        }
                        else
                        {
                            MessageBox.Show("Failed to add data.");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void AddTeacher_Load(object sender, EventArgs e)
        {

        }
    }
}
