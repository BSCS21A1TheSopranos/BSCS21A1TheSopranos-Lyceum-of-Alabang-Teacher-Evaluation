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
            button1 = new Button();
            SuspendLayout();
            // 
            // textBox2
            // 
            textBox2.BorderStyle = BorderStyle.FixedSingle;
            textBox2.Location = new Point(203, 155);
            textBox2.Margin = new Padding(3, 4, 3, 4);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(394, 27);
            textBox2.TabIndex = 4;
            // 
            // textBox1
            // 
            textBox1.BorderStyle = BorderStyle.FixedSingle;
            textBox1.Location = new Point(203, 97);
            textBox1.Margin = new Padding(3, 4, 3, 4);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(394, 27);
            textBox1.TabIndex = 5;
            // 
            // textBox3
            // 
            textBox3.BorderStyle = BorderStyle.FixedSingle;
            textBox3.Location = new Point(203, 208);
            textBox3.Margin = new Padding(3, 4, 3, 4);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(394, 27);
            textBox3.TabIndex = 6;
            // 
            // textBox4
            // 
            textBox4.BorderStyle = BorderStyle.FixedSingle;
            textBox4.Location = new Point(203, 261);
            textBox4.Margin = new Padding(3, 4, 3, 4);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(394, 27);
            textBox4.TabIndex = 7;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft Sans Serif", 11.25F);
            label3.Location = new Point(94, 104);
            label3.Name = "label3";
            label3.Size = new Size(101, 24);
            label3.TabIndex = 8;
            label3.Text = "Student ID:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 11.25F);
            label1.Location = new Point(129, 161);
            label1.Name = "label1";
            label1.Size = new Size(62, 24);
            label1.TabIndex = 9;
            label1.Text = "Email:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 11.25F);
            label2.Location = new Point(95, 215);
            label2.Name = "label2";
            label2.Size = new Size(97, 24);
            label2.TabIndex = 10;
            label2.Text = "Password:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Microsoft Sans Serif", 11.25F);
            label4.Location = new Point(30, 268);
            label4.Name = "label4";
            label4.Size = new Size(167, 24);
            label4.TabIndex = 11;
            label4.Text = "Confrim Password:";
            // 
            // buttonAdd
            // 
            buttonAdd.AutoEllipsis = true;
            buttonAdd.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            buttonAdd.FlatAppearance.BorderSize = 2;
            buttonAdd.Font = new Font("Microsoft Sans Serif", 11.25F);
            buttonAdd.Location = new Point(441, 327);
            buttonAdd.Margin = new Padding(3, 4, 3, 4);
            buttonAdd.Name = "buttonAdd";
            buttonAdd.Size = new Size(156, 39);
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
            notif.Location = new Point(366, 61);
            notif.Name = "notif";
            notif.Size = new Size(77, 17);
            notif.TabIndex = 28;
            notif.Text = "pogi si paul";
            notif.Visible = false;
            // 
            // button1
            // 
            button1.AutoEllipsis = true;
            button1.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            button1.FlatAppearance.BorderSize = 2;
            button1.Font = new Font("Microsoft Sans Serif", 11.25F);
            button1.Location = new Point(203, 327);
            button1.Margin = new Padding(3, 4, 3, 4);
            button1.Name = "button1";
            button1.Size = new Size(157, 39);
            button1.TabIndex = 29;
            button1.Text = "Close";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // Addstudent
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 451);
            Controls.Add(button1);
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
            Name = "Addstudent";
            Text = "Form1";
            Load += Addstudent_Load;
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
        private Button button1;
    }
}