using ClassLibrary1;
using Microsoft.VisualBasic.ApplicationServices;
using Services;
using System.Windows.Forms;

namespace Teacher_Evaluation
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
            IDataSaveandRetrieve repository;
            //repository = new JsonDataSaveandRetrieve();
            repository = new MSAcessDataSaveandRetrieve();
            StudentDataHolder.LoadStudents(repository);
            AdminDataHolder.LoadAdmin(repository);
            TeacherDataHolder.LoadTeacher(repository);
            StudentTeacherData.LoadStudentsTeachers(repository);
            TeacherFeedbackService.LoadStudentsTeachers(repository);
        }
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            UI_RegisterStud uI_RegisterStud = new UI_RegisterStud();
            uI_RegisterStud.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MSAcessDataSaveandRetrieve mSAcessDataSaveandRetrieve = new MSAcessDataSaveandRetrieve();
            mSAcessDataSaveandRetrieve.SaveStudents();
            LoginClass login = new LoginClass(textBox5.Text);

            if (login.checkStudent())
            {
                if (login.checkpassword(textBox6.Text))
                {
                    login.GetRoles();
                    if (login.isStudent)
                    {
                        StudentTeachers studentTeachers = new StudentTeachers(textBox5.Text);
                        studentTeachers.Show();
                        this.Hide();
                    }
                    if (login.isAdmin)
                    {
                        Admin admin = new Admin();
                        admin.Show();
                        this.Hide();
                    }
                }
                if (!login.checkpassword(textBox6.Text))
                {
                    notif.Visible = true;
                    notif.Text = "Password or Student ID mismatch";
                    textBox4.Clear();
                    textBox5.Clear();
                    textBox6.Clear();
                }
            }
            else
            {
                notif.Visible = true;
                notif.Text = "Invalid account";
                textBox4.Clear();
                textBox5.Clear();
                textBox6.Clear();
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                textBox6.UseSystemPasswordChar = false;
            }
            else
            {
                textBox6.UseSystemPasswordChar = true;
            }
        }
    }
}
