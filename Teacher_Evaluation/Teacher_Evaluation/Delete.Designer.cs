﻿namespace Teacher_Evaluation
{
    partial class Delete
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
            label1 = new Label();
            textBox1 = new TextBox();
            button1 = new Button();
            button2 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(45, 72);
            label1.Name = "label1";
            label1.Size = new Size(117, 20);
            label1.TabIndex = 1;
            label1.Text = "Enter Teacher ID";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(168, 72);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(96, 27);
            textBox1.TabIndex = 2;
            textBox1.TextChanged += textBox1_TextChanged_1;
            // 
            // button1
            // 
            button1.Location = new Point(182, 160);
            button1.Name = "button1";
            button1.Size = new Size(117, 29);
            button1.TabIndex = 3;
            button1.Text = "DELETE";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(31, 160);
            button2.Name = "button2";
            button2.Size = new Size(117, 29);
            button2.TabIndex = 4;
            button2.Text = "CANCEL";
            button2.UseVisualStyleBackColor = true;
            // 
            // Delete
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(324, 205);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(textBox1);
            Controls.Add(label1);
            Name = "Delete";
            Text = "Delete";
            Load += Delete_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox textBox1;
        private Button button1;
        private Button button2;
    }
}