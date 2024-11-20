namespace Teacher_Evaluation
{
    partial class AddTeacher
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
            label2 = new Label();
            textBox3 = new TextBox();
            label3 = new Label();
            textBox4 = new TextBox();
            label4 = new Label();
            textBox5 = new TextBox();
            label5 = new Label();
            textBox6 = new TextBox();
            label6 = new Label();
            label1 = new Label();
            buttonAdd = new Button();
            button1 = new Button();
            SuspendLayout();
            // 
            // textBox2
            // 
            textBox2.Location = new Point(253, 102);
            textBox2.Multiline = true;
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(185, 21);
            textBox2.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(107, 102);
            label2.Name = "label2";
            label2.Size = new Size(100, 21);
            label2.TabIndex = 2;
            label2.Text = "Professor ID";
            // 
            // textBox3
            // 
            textBox3.Location = new Point(253, 169);
            textBox3.Multiline = true;
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(185, 21);
            textBox3.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(107, 167);
            label3.Name = "label3";
            label3.Size = new Size(88, 21);
            label3.TabIndex = 4;
            label3.Text = "First Name";
            // 
            // textBox4
            // 
            textBox4.Location = new Point(253, 231);
            textBox4.Multiline = true;
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(185, 21);
            textBox4.TabIndex = 7;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(107, 229);
            label4.Name = "label4";
            label4.Size = new Size(86, 21);
            label4.TabIndex = 6;
            label4.Text = "Last Name";
            // 
            // textBox5
            // 
            textBox5.Location = new Point(253, 300);
            textBox5.Multiline = true;
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(185, 21);
            textBox5.TabIndex = 9;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(107, 298);
            label5.Name = "label5";
            label5.Size = new Size(106, 21);
            label5.TabIndex = 8;
            label5.Text = "Middle Initial";
            // 
            // textBox6
            // 
            textBox6.Location = new Point(253, 362);
            textBox6.Multiline = true;
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(185, 21);
            textBox6.TabIndex = 11;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(107, 360);
            label6.Name = "label6";
            label6.Size = new Size(85, 21);
            label6.TabIndex = 10;
            label6.Text = "Subject ID";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("MS Reference Sans Serif", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(191, 32);
            label1.Name = "label1";
            label1.Size = new Size(172, 26);
            label1.TabIndex = 12;
            label1.Text = "Teacher Input";
            // 
            // buttonAdd
            // 
            buttonAdd.FlatAppearance.BorderSize = 2;
            buttonAdd.FlatStyle = FlatStyle.Flat;
            buttonAdd.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonAdd.Location = new Point(135, 418);
            buttonAdd.Name = "buttonAdd";
            buttonAdd.Size = new Size(95, 46);
            buttonAdd.TabIndex = 13;
            buttonAdd.Text = "Add";
            buttonAdd.UseVisualStyleBackColor = true;
            buttonAdd.Click += buttonAdd_Click;
            // 
            // button1
            // 
            button1.FlatAppearance.BorderSize = 2;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.Location = new Point(281, 418);
            button1.Name = "button1";
            button1.Size = new Size(95, 46);
            button1.TabIndex = 13;
            button1.Text = "Cancel";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // AddTeacher
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(536, 489);
            Controls.Add(button1);
            Controls.Add(buttonAdd);
            Controls.Add(label1);
            Controls.Add(textBox6);
            Controls.Add(label6);
            Controls.Add(textBox5);
            Controls.Add(label5);
            Controls.Add(textBox4);
            Controls.Add(label4);
            Controls.Add(textBox3);
            Controls.Add(label3);
            Controls.Add(textBox2);
            Controls.Add(label2);
            FormBorderStyle = FormBorderStyle.None;
            Name = "AddTeacher";
            Text = "AddTeacher";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox2;
        private Label label2;
        private TextBox textBox3;
        private Label label3;
        private TextBox textBox4;
        private Label label4;
        private TextBox textBox5;
        private Label label5;
        private TextBox textBox6;
        private Label label6;
        private Label label1;
        private Button buttonAdd;
        private Button button1;
    }
}