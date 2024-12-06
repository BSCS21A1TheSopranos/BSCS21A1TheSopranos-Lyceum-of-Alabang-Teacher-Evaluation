using ClassLibrary1;
using System;
using System.Collections.Generic;
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
            UpdateStatusInDictionary(studentid, teacherid);
            StudentTeachers form1 = new StudentTeachers(studentid);
            MSAcessDataSaveandRetrieve mSAcessDataSaveandRetrieve = new MSAcessDataSaveandRetrieve();
            mSAcessDataSaveandRetrieve.SaveStudentsTeachers();
            form1.Show();
            this.Close();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
        }
        void UpdateStatusInDictionary(string studentId, string teacherId)
        {
            if (StudentTeacherData.studentTeacherData.ContainsKey(studentId))
            {
                var teacherRecords = StudentTeacherData.studentTeacherData[studentId];
                for (int i = 0; i < teacherRecords.Count; i++)
                {
                    if (teacherRecords[i].ProfID == teacherId)
                    {
                        teacherRecords[i] = (teacherRecords[i].ProfID, teacherRecords[i].Subject, "Done");
                        break;
                    }
                }
            }
        }
    }
}
