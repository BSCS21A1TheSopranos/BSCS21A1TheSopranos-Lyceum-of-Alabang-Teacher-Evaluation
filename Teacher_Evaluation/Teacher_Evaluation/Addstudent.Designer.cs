namespace Teacher_Evaluation
{
    partial class Addstudent
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            textBox2 = new TextBox();
            textBox1 = new TextBox();
            textBox3 = new TextBox();
            textBox4 = new TextBox();
            label3 = new Label();
            label1 = new Label();
            label2 = new Label();
            label4 = new Label();
            buttonAdd = new Button();
            notif = new Label();
            panel1 = new Panel();
            panel2 = new Panel();
            label5 = new Label();
            panel3 = new Panel();
            button1 = new Button();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // textBox2
            // 
            textBox2.BorderStyle = BorderStyle.FixedSingle;
            textBox2.Location = new Point(187, 177);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(345, 23);
            textBox2.TabIndex = 4;
            // 
            // textBox1
            // 
            textBox1.BorderStyle = BorderStyle.FixedSingle;
            textBox1.Location = new Point(187, 134);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(345, 23);
            textBox1.TabIndex = 5;
            // 
            // textBox3
            // 
            textBox3.BorderStyle = BorderStyle.FixedSingle;
            textBox3.Location = new Point(187, 217);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(345, 23);
            textBox3.TabIndex = 6;
            textBox3.UseSystemPasswordChar = true;
            // 
            // textBox4
            // 
            textBox4.BorderStyle = BorderStyle.FixedSingle;
            textBox4.Location = new Point(187, 257);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(345, 23);
            textBox4.TabIndex = 7;
            textBox4.UseSystemPasswordChar = true;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft Sans Serif", 11.25F);
            label3.Location = new Point(91, 139);
            label3.Name = "label3";
            label3.Size = new Size(80, 18);
            label3.TabIndex = 8;
            label3.Text = "Student ID:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 11.25F);
            label1.Location = new Point(121, 182);
            label1.Name = "label1";
            label1.Size = new Size(49, 18);
            label1.TabIndex = 9;
            label1.Text = "Email:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 11.25F);
            label2.Location = new Point(91, 222);
            label2.Name = "label2";
            label2.Size = new Size(79, 18);
            label2.TabIndex = 10;
            label2.Text = "Password:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Microsoft Sans Serif", 11.25F);
            label4.Location = new Point(35, 257);
            label4.Name = "label4";
            label4.Size = new Size(136, 18);
            label4.TabIndex = 11;
            label4.Text = "Confrim Password:";
            // 
            // buttonAdd
            // 
            buttonAdd.AutoEllipsis = true;
            buttonAdd.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            buttonAdd.FlatAppearance.BorderSize = 2;
            buttonAdd.Font = new Font("Microsoft Sans Serif", 11.25F);
            buttonAdd.Location = new Point(338, 305);
            buttonAdd.Name = "buttonAdd";
            buttonAdd.Size = new Size(185, 29);
            buttonAdd.TabIndex = 14;
            buttonAdd.Text = "Add now";
            buttonAdd.UseVisualStyleBackColor = true;
            buttonAdd.Click += buttonAdd_Click;
            // 
            // notif
            // 
            notif.AutoSize = true;
            notif.BackColor = SystemColors.ControlLight;
            notif.Font = new Font("Segoe UI", 7.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            notif.ForeColor = Color.Firebrick;
            notif.Location = new Point(305, 103);
            notif.Name = "notif";
            notif.Size = new Size(68, 13);
            notif.TabIndex = 28;
            notif.Text = "pogi si paul";
            notif.Visible = false;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(243, 196, 27);
            panel1.Dock = DockStyle.Bottom;
            panel1.Location = new Point(0, 376);
            panel1.Name = "panel1";
            panel1.Size = new Size(582, 10);
            panel1.TabIndex = 29;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(31, 51, 92);
            panel2.Controls.Add(label5);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(582, 58);
            panel2.TabIndex = 30;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.ForeColor = SystemColors.Control;
            label5.Location = new Point(217, 13);
            label5.Name = "label5";
            label5.Size = new Size(167, 32);
            label5.TabIndex = 0;
            label5.Text = "Add Students";
            // 
            // panel3
            // 
            panel3.BackColor = Color.FromArgb(243, 196, 27);
            panel3.Dock = DockStyle.Top;
            panel3.Location = new Point(0, 58);
            panel3.Name = "panel3";
            panel3.Size = new Size(582, 16);
            panel3.TabIndex = 31;
            // 
            // button1
            // 
            button1.AutoEllipsis = true;
            button1.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            button1.FlatAppearance.BorderSize = 2;
            button1.Font = new Font("Microsoft Sans Serif", 11.25F);
            button1.Location = new Point(107, 305);
            button1.Name = "button1";
            button1.Size = new Size(185, 29);
            button1.TabIndex = 32;
            button1.Text = "Cancel";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // Addstudent
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(582, 386);
            Controls.Add(button1);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(notif);
            Controls.Add(buttonAdd);
            Controls.Add(label4);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(label3);
            Controls.Add(textBox4);
            Controls.Add(textBox3);
            Controls.Add(textBox1);
            Controls.Add(textBox2);
            Margin = new Padding(3, 2, 3, 2);
            Name = "Addstudent";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            Load += Addstudent_Load;
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox2;
        private TextBox textBox1;
        private TextBox textBox3;
        private TextBox textBox4;
        private Label label3;
        private Label label1;
        private Label label2;
        private Label label4;
        private Button buttonAdd;
        private Label notif;
        private Panel panel1;
        private Panel panel2;
        private Panel panel3;
        private Label label5;
        private Button button1;
    }
}