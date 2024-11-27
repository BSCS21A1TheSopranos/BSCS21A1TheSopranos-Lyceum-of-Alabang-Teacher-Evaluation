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
            //repository = new JsonDataSaveandRetrieve(jsonStudentsFilePath, jsonAdminsFilePath, jsonTeachersFilePath, jsonStudentsTeachersFilePath);
            repository = new MSAcessDataSaveandRetrieve();
            StudentDataHolder.LoadStudents(repository);
            AdminDataHolder.LoadAdmin(repository);
            TeacherDataHolder.LoadTeacher(repository);
            StudentTeacherData.LoadStudentsTeachers(repository);
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
                    NavigationService navigationService = new NavigationService();
                    navigationService.NavigateToForm(login.GetRole(), textBox5.Text);
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

    }
    public class NavigationService
    {
        public void NavigateToForm(string role, string username)
        {
            if (role == "Admin")
            {
                Admin admin = new Admin();
                admin.Show();
            }
            else if (role == "Student")
            {
                StudentTeachers form = new StudentTeachers(username);
                form.Show();
            }
        }
    }

}
