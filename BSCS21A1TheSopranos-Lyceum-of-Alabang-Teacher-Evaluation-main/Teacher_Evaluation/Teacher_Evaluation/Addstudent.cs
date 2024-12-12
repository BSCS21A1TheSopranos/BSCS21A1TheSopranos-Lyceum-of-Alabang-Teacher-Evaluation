using ClassLibrary1;
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
    public partial class Addstudent : Form
    {
        public Addstudent()
        {
            InitializeComponent();
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            var newstudent = new Student(textBox1.Text, textBox3.Text, textBox2.Text, "Student");
            StudentDataHolder.AddStudent(newstudent);
            MSAcessDataSaveandRetrieve ms = new MSAcessDataSaveandRetrieve();
            ms.SaveStudents();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
