﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using ClassLibrary1;
namespace Teacher_Evaluation
{
    public partial class UI_RegisterStud : Form
    {
        public UI_RegisterStud()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Student student = new Student(textBox6.Text, textBox7.Text, textBox8.Text, "Student");
            RegistrationClass registration = new RegistrationClass();
            LoginForm loginForm = new LoginForm();

            if (!registration.validstudentNo(student))
            {
                notif1.Visible = true;
                notif1.Text = "Account Not Found";
            }
            if (!registration.checkpassword(student))
            {
                notif2.Visible = true;
                notif2.Text = "Wrong Password";
            }
            if (!registration.validpaassword(textBox8.Text))
            {
                notif3.Visible = true;
                notif3.Text = "Minimum of 8 characters";
            }
            if (registration.validstudentNo(student) && (registration.validpaassword(textBox8.Text)) && (registration.checkpassword(student)))
            {
                registration.encryptpassword(textBox8.Text, student);
                RegistrationClass.Update(student);
                loginForm.Show();
                this.Close();
            }

        }

        private void UI_RegisterStud_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            LoginForm loginForm = new LoginForm();
            loginForm.Show();
            this.Close();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                textBox7.UseSystemPasswordChar = false;
                textBox8.UseSystemPasswordChar = false;
            }
            else
            {
                textBox7.UseSystemPasswordChar = true;
                textBox8.UseSystemPasswordChar = true;
            }
        }

        private void notif_Click(object sender, EventArgs e)
        {

        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
