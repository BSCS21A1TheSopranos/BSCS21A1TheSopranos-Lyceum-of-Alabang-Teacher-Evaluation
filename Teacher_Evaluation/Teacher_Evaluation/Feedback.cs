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
        public Feedback()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string inputText = textBox1.Text;
            string sentiment = AnalyzeSentiment(inputText);
            label3.Text = sentiment;
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
    }
}
