namespace Teacher_Evaluation
{
    partial class LoginForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            textBox1 = new TextBox();
            label2 = new Label();
            label3 = new Label();
            textBox2 = new TextBox();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            button1 = new Button();
            button2 = new Button();
            label8 = new Label();
            textBox3 = new TextBox();
            label4 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(348, 9);
            label1.Name = "label1";
            label1.Size = new Size(315, 33);
            label1.TabIndex = 0;
            label1.Text = "TEACHER EVALUATION";
            label1.Click += label1_Click;
            // 
            // textBox1
            // 
            textBox1.BackColor = SystemColors.InactiveCaption;
            textBox1.Location = new Point(461, 120);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(329, 32);
            textBox1.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = SystemColors.ActiveCaption;
            label2.Font = new Font("Times New Roman", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = SystemColors.ActiveCaptionText;
            label2.Location = new Point(222, 187);
            label2.Name = "label2";
            label2.Size = new Size(205, 33);
            label2.TabIndex = 2;
            label2.Text = "Student Number:";
            label2.Click += label2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Times New Roman", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(224, 249);
            label3.Name = "label3";
            label3.Size = new Size(129, 33);
            label3.TabIndex = 3;
            label3.Text = "Password:";
            // 
            // textBox2
            // 
            textBox2.BackColor = SystemColors.InactiveCaption;
            textBox2.Location = new Point(461, 249);
            textBox2.Multiline = true;
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(329, 33);
            textBox2.TabIndex = 4;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 7.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.Red;
            label5.Location = new Point(543, 155);
            label5.Name = "label5";
            label5.Size = new Size(160, 17);
            label5.TabIndex = 7;
            label5.Text = "*This is Required to Fill up";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 7.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.Red;
            label6.Location = new Point(543, 285);
            label6.Name = "label6";
            label6.Size = new Size(160, 17);
            label6.TabIndex = 8;
            label6.Text = "*This is Required to Fill up";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 7.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label7.ForeColor = Color.Red;
            label7.Location = new Point(555, 221);
            label7.Name = "label7";
            label7.Size = new Size(129, 17);
            label7.TabIndex = 9;
            label7.Text = "*Please Select Above\r\n";
            // 
            // button1
            // 
            button1.BackColor = Color.AliceBlue;
            button1.BackgroundImageLayout = ImageLayout.Center;
            button1.Font = new Font("Arial Rounded MT Bold", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button1.ForeColor = Color.Black;
            button1.Location = new Point(500, 409);
            button1.Name = "button1";
            button1.Size = new Size(290, 33);
            button1.TabIndex = 10;
            button1.Text = "REGISTER";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.AliceBlue;
            button2.BackgroundImageLayout = ImageLayout.Center;
            button2.Font = new Font("Arial Rounded MT Bold", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button2.ForeColor = Color.Black;
            button2.Location = new Point(224, 335);
            button2.Name = "button2";
            button2.Size = new Size(566, 42);
            button2.TabIndex = 11;
            button2.Text = "NEXT";
            button2.UseVisualStyleBackColor = false;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Times New Roman", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label8.Location = new Point(224, 408);
            label8.Name = "label8";
            label8.Size = new Size(270, 33);
            label8.TabIndex = 12;
            label8.Text = "Doesn't Have Account?";
            label8.Click += label8_Click;
            // 
            // textBox3
            // 
            textBox3.BackColor = SystemColors.InactiveCaption;
            textBox3.Location = new Point(461, 187);
            textBox3.Multiline = true;
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(329, 33);
            textBox3.TabIndex = 13;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = SystemColors.ActiveCaption;
            label4.Font = new Font("Times New Roman", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.ForeColor = SystemColors.ActiveCaptionText;
            label4.Location = new Point(222, 119);
            label4.Name = "label4";
            label4.Size = new Size(132, 33);
            label4.TabIndex = 14;
            label4.Text = "Username:";
            // 
            // LoginForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            BackColor = SystemColors.ActiveCaption;
            BackgroundImage = Properties.Resources.OIP;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1022, 509);
            Controls.Add(label4);
            Controls.Add(textBox3);
            Controls.Add(label8);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(textBox2);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(textBox1);
            Controls.Add(label1);
            Name = "LoginForm";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox textBox1;
        private Label label2;
        private Label label3;
        private TextBox textBox2;
        private Label label5;
        private Label label6;
        private Label label7;
        private Button button1;
        private Button button2;
        private Label label8;
        private TextBox textBox3;
        private Label label4;
    }
}
