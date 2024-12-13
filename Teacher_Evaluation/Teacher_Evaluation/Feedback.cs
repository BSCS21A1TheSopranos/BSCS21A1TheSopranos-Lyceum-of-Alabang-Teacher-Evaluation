using ClassLibrary1;
using Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Teacher_Evaluation
{
    public partial class Feedback : Form
    {

        private string teacherid;
        private string teachername;
        private string studentid;


    public Feedback(string teacherid, string teachername, string studentid)
    {
                this.teacherid = teacherid;
                this.teachername = teachername;
                this.studentid = studentid;
                InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string inputText = textBox1.Text;
            string sentiment = AnalyzeSentiment(inputText);

            if (sentiment == "Unable to determine sentiment due to meaningless input")
            {
                MessageBox.Show("The input text is meaningless. Please try again with valid input.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                string currentDateTime = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
                StudentTeacherData.UpdateStatusInDictionary(studentid, teacherid);
                TeacherFeedbackService.AddFeedback(teacherid, textBox1.Text, sentiment, currentDateTime);
                StudentTeachers form1 = new StudentTeachers(studentid);
                form1.Show();
                this.Close();
            }
            
        }

        private string AnalyzeSentiment(string text)
        {
            try
            {
                string currentDirectory = Directory.GetCurrentDirectory();

                string outputDirectory = Path.Combine(currentDirectory, "Resources");


                string pythonPath = Path.Combine(outputDirectory, "python.exe");
                string sentimentPath = Path.Combine(outputDirectory, "sentiment.exe");


                var psi = new ProcessStartInfo
                {
                    FileName = sentimentPath,
                    Arguments = $"\"{text}\"",
                    RedirectStandardOutput = true,
                    UseShellExecute = false,
                    CreateNoWindow = true
                };

                using (var process = Process.Start(psi))
                using (var reader = process.StandardOutput)
                {
                    string result = reader.ReadToEnd();
                    return result.Trim();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
                return "Error: " + ex.Message;
            }
        }

        private void Feedback_Load(object sender, EventArgs e)
        {

        }
    }
}
