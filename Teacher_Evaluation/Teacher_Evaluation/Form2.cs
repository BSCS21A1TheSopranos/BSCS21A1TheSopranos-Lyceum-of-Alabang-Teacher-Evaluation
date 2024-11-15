using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Teacher_Evaluation
{
    public partial class Form2 : Form
    {
        private string teacherid;
        private string teachername;
        private string studentid;

        public Form2(string teacherid, string teachername, string studentid)
        {
            this.teacherid = teacherid;
            this.teachername = teachername;
            this.studentid = studentid;
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            DatabaseConnection.InsertEvaluation(teacherid, teachername, textBox1.Text);
            Form1 form1 = new Form1(studentid);
            form1.Show();
            this.Close();
        }
    }
}
