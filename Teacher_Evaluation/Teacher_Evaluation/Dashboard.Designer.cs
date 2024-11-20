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
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(118, 30);
            label1.TabIndex = 0;
            label1.Text = "Dashboard";
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.MenuHighlight;
            panel1.Controls.Add(stdCount);
            panel1.Controls.Add(label2);
            panel1.Location = new Point(24, 71);
            panel1.Name = "panel1";
            panel1.Size = new Size(342, 138);
            panel1.TabIndex = 1;
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
            // 
            // panel2
            // 
            panel2.BackColor = SystemColors.MenuHighlight;
            panel2.Controls.Add(doneStd);
            panel2.Controls.Add(label3);
            panel2.Location = new Point(381, 71);
            panel2.Name = "panel2";
            panel2.Size = new Size(342, 138);
            panel2.TabIndex = 2;
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
            // 
            // Dashboard
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(735, 666);
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
    }
}