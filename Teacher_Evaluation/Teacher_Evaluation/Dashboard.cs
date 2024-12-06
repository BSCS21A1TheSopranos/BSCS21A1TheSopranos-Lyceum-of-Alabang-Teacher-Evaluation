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
    public partial class Dashboard : Form
    {

        static string databasePath = System.IO.Path.Combine(Application.StartupPath, "Teacher_Evaluation_Database.accdb");
        private static string connectionString = $@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source={databasePath}";

        public Dashboard()
        {
            InitializeComponent();
            LoadDashboardData();
        }

        private void LoadDashboardData()
        {
            try
            {
                // SQL query to count all students and done students
                string query = "SELECT COUNT(*) AS TotalStudents, " +
                               "SUM(IIF(Done=True, 1, 0)) AS DoneStudents " +
                               "FROM Students"; // Assuming the table is 'Students' and the column 'Done' is a boolean

                using (OleDbConnection connection = new OleDbConnection(connectionString))
                {
                    OleDbDataAdapter adapter = new OleDbDataAdapter(query, connection);
                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);

                    // If there's data in the result
                    if (dataTable.Rows.Count > 0)
                    {
                        // Get total student count
                        int totalStudents = Convert.ToInt32(dataTable.Rows[0]["TotalStudents"]);
                        // Get count of done students
                        int doneStudents = Convert.ToInt32(dataTable.Rows[0]["DoneStudents"]);

                        // Update the labels with the retrieved values
                        stdCount.Text = $"{totalStudents}";  // Label for total students
                        doneStd.Text = $"{doneStudents}";      // Label for done students
                    }
                    else
                    {
                        MessageBox.Show("No data available in the database.");
                    }
                }
            }
            catch (Exception ex)
            {
                // Show any errors that occur
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void Dashboard_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
