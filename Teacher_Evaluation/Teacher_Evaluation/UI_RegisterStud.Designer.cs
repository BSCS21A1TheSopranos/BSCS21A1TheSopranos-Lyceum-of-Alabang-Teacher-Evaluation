namespace Teacher_Evaluation
{
    partial class UI_RegisterStud
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
            button1 = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            SuspendLayout();
            // 
            // button1
            // 
            button1.BackColor = SystemColors.ActiveCaption;
            button1.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.Location = new Point(410, 386);
            button1.Name = "button1";
            button1.Size = new Size(529, 47);
            button1.TabIndex = 0;
            button1.Text = "REGISTER";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = SystemColors.ActiveCaption;
            label1.Font = new Font("Times New Roman", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(486, 9);
            label1.Name = "label1";
            label1.Size = new Size(388, 32);
            label1.TabIndex = 1;
            label1.Text = "STUDENT REGISTER FORM";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = SystemColors.ActiveCaption;
            label2.Font = new Font("Times New Roman", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(410, 178);
            label2.Name = "label2";
            label2.Size = new Size(165, 26);
            label2.TabIndex = 2;
            label2.Text = "Enter Username:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = SystemColors.ActiveCaption;
            label3.Font = new Font("Times New Roman", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(410, 249);
            label3.Name = "label3";
            label3.Size = new Size(226, 26);
            label3.TabIndex = 3;
            label3.Text = "Enter Student Number:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = SystemColors.ActiveCaption;
            label4.Font = new Font("Times New Roman", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(410, 320);
            label4.Name = "label4";
            label4.Size = new Size(163, 26);
            label4.TabIndex = 4;
            label4.Text = "Enter Password:";
            // 
            // textBox1
            // 
            textBox1.BackColor = SystemColors.ActiveCaption;
            textBox1.Location = new Point(696, 178);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(243, 26);
            textBox1.TabIndex = 5;
            // 
            // textBox2
            // 
            textBox2.BackColor = SystemColors.ActiveCaption;
            textBox2.Location = new Point(696, 320);
            textBox2.Multiline = true;
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(243, 26);
            textBox2.TabIndex = 6;
            // 
            // textBox3
            // 
            textBox3.BackColor = SystemColors.ActiveCaption;
            textBox3.Location = new Point(696, 249);
            textBox3.Multiline = true;
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(243, 26);
            textBox3.TabIndex = 7;
            // 
            // UI_RegisterStud
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.OIP;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1364, 629);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(button1);
            Name = "UI_RegisterStud";
            Text = "UI_RegisterStud";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
    }
}