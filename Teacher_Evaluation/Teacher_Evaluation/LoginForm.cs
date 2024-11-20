using ClassLibrary1;
using Microsoft.VisualBasic.ApplicationServices;

namespace Teacher_Evaluation
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
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

        private void label8_Click(object sender, EventArgs e)
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
            UserInfo user = DatabaseConnection.UserData(textBox3.Text);

            if (user != null)
            {
                LoginClass login = new LoginClass(user.Password, user.Role, user.ID);
                if (login.checkpassword(textBox2.Text) && login.checkstudentno(textBox3.Text))
                {
                    if (user.Role == "Admin")
                    {
                        Admin admin = new Admin();
                        admin.Show();
                        this.Hide();
                    }
                    else if (user.Role == "Student")
                    {
                        Form1 form = new Form1(user.ID);
                        form.Show();
                        this.Hide();
                    }
                }
                if (!login.checkstudentno(textBox3.Text))
                {
                    textBox3.Text = "maliw";
                }
                if (!login.checkpassword(textBox2.Text))
                {
                    textBox2.Text = "malie";
                }
            }
            else
            {
                label9.Text = "User Not Found";
            }
        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                textBox2.UseSystemPasswordChar = false;
            }
            else
            {
                textBox2.UseSystemPasswordChar = true;
            }
        }
    }
}
