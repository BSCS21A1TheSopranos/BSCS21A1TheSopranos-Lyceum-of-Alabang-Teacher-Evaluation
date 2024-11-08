using ClassLibrary1;

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
            
            LoginClass login = new LoginClass();
            if (login.checkusername(textBox1.Text) && login.checkpassword(textBox2.Text) && login.checkstudentno(textBox3.Text))
            {
                this.Close();
            }
            if (!login.checkusername(textBox1.Text)){
                textBox1.Text = "maliq";
            }
            if (!login.checkstudentno(textBox3.Text)) {
                textBox3.Text = "maliw";
            }
            if (!login.checkpassword(textBox2.Text)) {
                textBox2.Text = "malie";
            }
        }
    }
}
