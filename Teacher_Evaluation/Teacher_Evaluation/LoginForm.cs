using ClassLibrary1;
using Microsoft.VisualBasic.ApplicationServices;
using System.Windows.Forms;

namespace Teacher_Evaluation
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
            IDataSaveandRetrieve repository;
            string jsonStudentsFilePath = System.IO.Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "..", "..", "..", "..", "students.json");
            string jsonAdminsFilePath = System.IO.Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "..", "..", "..", "..", "admin.json");
            string jsonTeachersFilePath = System.IO.Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "..", "..", "..", "..", "teachers.json");
            repository = new JsonDataSaveandRetrieve(jsonStudentsFilePath, jsonAdminsFilePath, jsonTeachersFilePath);
            //string databasePath = System.IO.Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "..", "..", "..", "..", "Teacher_Evaluation_Database.accdb");
            //repository = new MSAcessDataSaveandRetrieve(databasePath);
            StudentDataHolder.LoadStudents(repository);
            AdminDataHolder.LoadAdmin(repository);
            TeacherDataHolder.LoadTeacher(repository);
            foreach (var teacher in TeacherDataHolder.Teachers)
            {
                MessageBox.Show($"{teacher.Value.ProfID} {teacher.Value.Password} {teacher.Value.Email}");
            }

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
            LoginClass login = new LoginClass(textBox5.Text);

            if (login.checkStudent())
            {
                if (login.checkpassword(textBox6.Text))
                {
                    if (login.GetRole() == "Admin")
                    {
                        Admin admin = new Admin();
                        admin.Show();
                        this.Hide();
                    }
                    else if (login.GetRole() == "Student")
                    {
                        Form1 form = new Form1(textBox5.Text);
                        form.Show();
                        this.Hide();
                    }
                }
                if (!login.checkpassword(textBox6.Text))
                {
                    MessageBox.Show("Mali Password");
                }
            }
            else
            {
                MessageBox.Show("Wala");
            }
        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label13_Click(object sender, EventArgs e)
        {

        }
    }
}
