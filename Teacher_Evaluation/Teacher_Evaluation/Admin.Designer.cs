namespace Teacher_Evaluation
{
    partial class Admin
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
            mainpanel = new Panel();
            label1 = new Label();
            button5 = new Button();
            panel1 = new Panel();
            button3 = new Button();
            button2 = new Button();
            button1 = new Button();
            pictureBox1 = new PictureBox();
            panel2 = new Panel();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // mainpanel
            // 
            mainpanel.Location = new Point(280, 39);
            mainpanel.Name = "mainpanel";
            mainpanel.Size = new Size(735, 666);
            mainpanel.TabIndex = 2;
            mainpanel.Paint += mainpanel_Paint_1;
            mainpanel.Resize += mainpanel_Resize;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Left;
            label1.AutoSize = true;
            label1.BackColor = Color.FromArgb(31, 51, 92);
            label1.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ControlLightLight;
            label1.Location = new Point(79, 167);
            label1.Name = "label1";
            label1.Size = new Size(133, 45);
            label1.TabIndex = 1;
            label1.Text = "ADMIN";
            // 
            // button5
            // 
            button5.Anchor = AnchorStyles.Left;
            button5.Cursor = Cursors.Hand;
            button5.FlatAppearance.BorderSize = 2;
            button5.FlatStyle = FlatStyle.Flat;
            button5.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button5.ForeColor = SystemColors.Control;
            button5.Location = new Point(79, 554);
            button5.Name = "button5";
            button5.Size = new Size(121, 58);
            button5.TabIndex = 1;
            button5.Text = "Log Out";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(31, 51, 92);
            panel1.Controls.Add(button5);
            panel1.Controls.Add(button3);
            panel1.Controls.Add(button2);
            panel1.Controls.Add(button1);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(pictureBox1);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(280, 661);
            panel1.TabIndex = 0;
            // 
            // button3
            // 
            button3.Anchor = AnchorStyles.Left;
            button3.BackColor = Color.FromArgb(31, 51, 92);
            button3.Cursor = Cursors.Hand;
            button3.FlatAppearance.BorderSize = 0;
            button3.FlatStyle = FlatStyle.Flat;
            button3.Font = new Font("Segoe UI Symbol", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button3.ForeColor = SystemColors.ButtonFace;
            button3.Image = Properties.Resources.teacher;
            button3.ImageAlign = ContentAlignment.MiddleLeft;
            button3.Location = new Point(26, 409);
            button3.Name = "button3";
            button3.Size = new Size(254, 55);
            button3.TabIndex = 3;
            button3.Text = "Teachers";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // button2
            // 
            button2.Anchor = AnchorStyles.Left;
            button2.BackColor = Color.FromArgb(31, 51, 92);
            button2.Cursor = Cursors.Hand;
            button2.FlatAppearance.BorderSize = 0;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Segoe UI Symbol", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button2.ForeColor = SystemColors.ButtonFace;
            button2.Image = Properties.Resources.student;
            button2.ImageAlign = ContentAlignment.MiddleLeft;
            button2.Location = new Point(26, 341);
            button2.Name = "button2";
            button2.Size = new Size(254, 55);
            button2.TabIndex = 2;
            button2.Text = "Students";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // button1
            // 
            button1.Anchor = AnchorStyles.Left;
            button1.BackColor = Color.FromArgb(31, 51, 92);
            button1.Cursor = Cursors.Hand;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Segoe UI Symbol", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.ForeColor = SystemColors.ButtonFace;
            button1.Image = Properties.Resources.home;
            button1.ImageAlign = ContentAlignment.MiddleLeft;
            button1.Location = new Point(26, 267);
            button1.Name = "button1";
            button1.Size = new Size(254, 55);
            button1.TabIndex = 1;
            button1.Text = "Dashboard";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Anchor = AnchorStyles.Left;
            pictureBox1.Image = Properties.Resources.user;
            pictureBox1.Location = new Point(88, 52);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(112, 112);
            pictureBox1.SizeMode = PictureBoxSizeMode.AutoSize;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(232, 188, 27);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(280, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(735, 33);
            panel2.TabIndex = 3;
            // 
            // Admin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1015, 661);
            Controls.Add(panel2);
            Controls.Add(mainpanel);
            Controls.Add(panel1);
            Name = "Admin";
            Text = "Admin";
            Load += Admin_Load_2;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private Panel mainpanel;
        private Label label1;
        private Button button5;
        private Panel panel1;
        private Button button3;
        private Button button2;
        private Button button1;
        private PictureBox pictureBox1;
        private Panel panel2;
    }
}