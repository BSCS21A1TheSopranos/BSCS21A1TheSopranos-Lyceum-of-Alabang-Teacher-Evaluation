namespace Teacher_Evaluation
{
    partial class Dashboard
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
            panel1 = new Panel();
            stdCount = new Label();
            label2 = new Label();
            panel2 = new Panel();
            doneStd = new Label();
            label3 = new Label();
            panel3 = new Panel();
            teacherCount = new Label();
            label4 = new Label();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft JhengHei", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(31, 51, 92);
            label1.Location = new Point(24, 32);
            label1.Name = "label1";
            label1.Size = new Size(125, 26);
            label1.TabIndex = 0;
            label1.Text = "Dashboard";
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(31, 51, 92);
            panel1.Controls.Add(stdCount);
            panel1.Controls.Add(label2);
            panel1.Location = new Point(24, 71);
            panel1.Name = "panel1";
            panel1.Size = new Size(342, 138);
            panel1.TabIndex = 1;
            panel1.Paint += panel1_Paint;
            // 
            // stdCount
            // 
            stdCount.AutoSize = true;
            stdCount.Font = new Font("Microsoft YaHei", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            stdCount.ForeColor = SystemColors.ButtonFace;
            stdCount.Location = new Point(18, 74);
            stdCount.Name = "stdCount";
            stdCount.Size = new Size(0, 42);
            stdCount.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft YaHei", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = SystemColors.ButtonFace;
            label2.Location = new Point(18, 22);
            label2.Name = "label2";
            label2.Size = new Size(262, 42);
            label2.TabIndex = 0;
            label2.Text = "Student Count:";
            label2.Click += label2_Click;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(31, 51, 92);
            panel2.Controls.Add(doneStd);
            panel2.Controls.Add(label3);
            panel2.Location = new Point(381, 71);
            panel2.Name = "panel2";
            panel2.Size = new Size(342, 138);
            panel2.TabIndex = 2;
            panel2.Paint += panel2_Paint;
            // 
            // doneStd
            // 
            doneStd.AutoSize = true;
            doneStd.Font = new Font("Microsoft YaHei", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            doneStd.ForeColor = SystemColors.ButtonFace;
            doneStd.Location = new Point(17, 74);
            doneStd.Name = "doneStd";
            doneStd.Size = new Size(0, 42);
            doneStd.TabIndex = 1;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft YaHei", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = SystemColors.ButtonFace;
            label3.Location = new Point(17, 22);
            label3.Name = "label3";
            label3.Size = new Size(266, 42);
            label3.TabIndex = 0;
            label3.Text = "Done Students:";
            label3.Click += label3_Click;
            // 
            // panel3
            // 
            panel3.BackColor = Color.FromArgb(31, 51, 92);
            panel3.Controls.Add(teacherCount);
            panel3.Controls.Add(label4);
            panel3.Location = new Point(24, 244);
            panel3.Name = "panel3";
            panel3.Size = new Size(342, 135);
            panel3.TabIndex = 3;
            // 
            // teacherCount
            // 
            teacherCount.AutoSize = true;
            teacherCount.Font = new Font("Microsoft YaHei", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            teacherCount.ForeColor = SystemColors.ButtonFace;
            teacherCount.Location = new Point(18, 75);
            teacherCount.Name = "teacherCount";
            teacherCount.Size = new Size(38, 42);
            teacherCount.TabIndex = 3;
            teacherCount.Text = "0";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Microsoft YaHei", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = SystemColors.ButtonFace;
            label4.Location = new Point(17, 22);
            label4.Name = "label4";
            label4.Size = new Size(263, 42);
            label4.TabIndex = 2;
            label4.Text = "Teacher Count:";
            // 
            // Dashboard
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(735, 666);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Dashboard";
            Text = "Dashboard";
            Load += Dashboard_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Panel panel1;
        private Label label2;
        private Panel panel2;
        private Label label3;
        private Label stdCount;
        private Label doneStd;
        private Panel panel3;
        private Label teacherCount;
        private Label label4;
    }
}