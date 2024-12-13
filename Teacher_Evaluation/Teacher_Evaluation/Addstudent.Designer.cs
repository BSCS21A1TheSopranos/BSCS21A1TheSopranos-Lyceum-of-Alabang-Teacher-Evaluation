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
            label3 = new Label();
            label1 = new Label();
            label2 = new Label();
            buttonAdd = new Button();
            notif = new Label();
            SuspendLayout();
            // 
            // textBox2
            // 
            textBox2.BorderStyle = BorderStyle.FixedSingle;
            textBox2.Location = new Point(178, 116);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(345, 23);
            textBox2.TabIndex = 4;
            // 
            // textBox1
            // 
            textBox1.BorderStyle = BorderStyle.FixedSingle;
            textBox1.Location = new Point(178, 73);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(345, 23);
            textBox1.TabIndex = 5;
            // 
            // textBox3
            // 
            textBox3.BorderStyle = BorderStyle.FixedSingle;
            textBox3.Location = new Point(178, 156);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(345, 23);
            textBox3.TabIndex = 6;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft Sans Serif", 11.25F);
            label3.Location = new Point(82, 78);
            label3.Name = "label3";
            label3.Size = new Size(80, 18);
            label3.TabIndex = 8;
            label3.Text = "Student ID:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 11.25F);
            label1.Location = new Point(113, 121);
            label1.Name = "label1";
            label1.Size = new Size(49, 18);
            label1.TabIndex = 9;
            label1.Text = "Email:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 11.25F);
            label2.Location = new Point(83, 161);
            label2.Name = "label2";
            label2.Size = new Size(79, 18);
            label2.TabIndex = 10;
            label2.Text = "Password:";
            // 
            // buttonAdd
            // 
            buttonAdd.AutoEllipsis = true;
            buttonAdd.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            buttonAdd.FlatAppearance.BorderSize = 2;
            buttonAdd.Font = new Font("Microsoft Sans Serif", 11.25F);
            buttonAdd.Location = new Point(338, 248);
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
            notif.Location = new Point(320, 46);
            notif.Name = "notif";
            notif.Size = new Size(68, 13);
            notif.TabIndex = 28;
            notif.Text = "pogi si paul";
            notif.Visible = false;
            // 
            // Addstudent
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(700, 338);
            Controls.Add(notif);
            Controls.Add(buttonAdd);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(label3);
            Controls.Add(textBox3);
            Controls.Add(textBox1);
            Controls.Add(textBox2);
            Margin = new Padding(3, 2, 3, 2);
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
        private Label label3;
        private Label label1;
        private Label label2;
        private Button buttonAdd;
        private Label notif;
    }
}