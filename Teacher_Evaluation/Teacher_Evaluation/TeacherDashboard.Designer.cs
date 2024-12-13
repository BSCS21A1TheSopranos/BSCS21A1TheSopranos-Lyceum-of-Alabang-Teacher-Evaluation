namespace Teacher_Evaluation
{
    partial class TeacherDashboard
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
            panel1 = new Panel();
            label14 = new Label();
            label1 = new Label();
            panel2 = new Panel();
            label2 = new Label();
            panel3 = new Panel();
            panel10 = new Panel();
            button1 = new Button();
            tableLayoutPanel2 = new TableLayoutPanel();
            panel8 = new Panel();
            dataGridView1 = new DataGridView();
            FeedBack = new DataGridViewTextBoxColumn();
            label8 = new Label();
            tableLayoutPanel1 = new TableLayoutPanel();
            panel4 = new Panel();
            label10 = new Label();
            label7 = new Label();
            label3 = new Label();
            panel5 = new Panel();
            label11 = new Label();
            label4 = new Label();
            panel6 = new Panel();
            label12 = new Label();
            label5 = new Label();
            panel7 = new Panel();
            label13 = new Label();
            label6 = new Label();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            panel10.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            panel8.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            tableLayoutPanel1.SuspendLayout();
            panel4.SuspendLayout();
            panel5.SuspendLayout();
            panel6.SuspendLayout();
            panel7.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(31, 51, 92);
            panel1.Controls.Add(label14);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(819, 76);
            panel1.TabIndex = 0;
            panel1.Paint += panel1_Paint;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label14.ForeColor = SystemColors.ButtonHighlight;
            label14.Location = new Point(212, 22);
            label14.Name = "label14";
            label14.Size = new Size(112, 37);
            label14.TabIndex = 1;
            label14.Text = "label14";
            label14.Click += label14_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.Control;
            label1.Location = new Point(12, 22);
            label1.Name = "label1";
            label1.Size = new Size(211, 37);
            label1.TabIndex = 0;
            label1.Text = "Welcome, Prof.";
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(232, 188, 27);
            panel2.Controls.Add(label2);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 76);
            panel2.Name = "panel2";
            panel2.Size = new Size(819, 34);
            panel2.TabIndex = 1;
            panel2.Paint += panel2_Paint;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.None;
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(368, 7);
            label2.Name = "label2";
            label2.Size = new Size(103, 20);
            label2.TabIndex = 0;
            label2.Text = "DASHBOARD";
            label2.Click += label2_Click;
            // 
            // panel3
            // 
            panel3.Controls.Add(tableLayoutPanel2);
            panel3.Controls.Add(tableLayoutPanel1);
            panel3.Dock = DockStyle.Top;
            panel3.Location = new Point(0, 110);
            panel3.Name = "panel3";
            panel3.Padding = new Padding(10);
            panel3.Size = new Size(819, 399);
            panel3.TabIndex = 2;
            panel3.Paint += panel3_Paint;
            // 
            // panel10
            // 
            panel10.BackColor = Color.FromArgb(232, 188, 27);
            panel10.Controls.Add(button1);
            panel10.Dock = DockStyle.Bottom;
            panel10.Location = new Point(0, 512);
            panel10.Name = "panel10";
            panel10.Size = new Size(819, 41);
            panel10.TabIndex = 3;
            // 
            // button1
            // 
            button1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            button1.BackColor = Color.Transparent;
            button1.FlatAppearance.BorderSize = 2;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.ForeColor = Color.Black;
            button1.Location = new Point(362, 3);
            button1.Name = "button1";
            button1.Size = new Size(109, 35);
            button1.TabIndex = 2;
            button1.Text = "Log Out";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 1;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 18F));
            tableLayoutPanel2.Controls.Add(panel8, 0, 0);
            tableLayoutPanel2.Dock = DockStyle.Top;
            tableLayoutPanel2.Location = new Point(10, 159);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 1;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel2.Size = new Size(799, 230);
            tableLayoutPanel2.TabIndex = 1;
            // 
            // panel8
            // 
            panel8.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel8.BackColor = SystemColors.ButtonHighlight;
            panel8.Controls.Add(dataGridView1);
            panel8.Controls.Add(label8);
            panel8.Location = new Point(3, 3);
            panel8.Name = "panel8";
            panel8.Size = new Size(793, 224);
            panel8.TabIndex = 0;
            panel8.Paint += panel8_Paint;
            // 
            // dataGridView1
            // 
            dataGridView1.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { FeedBack });
            dataGridView1.Location = new Point(8, 29);
            dataGridView1.Margin = new Padding(3, 2, 3, 2);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(772, 183);
            dataGridView1.TabIndex = 1;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // FeedBack
            // 
            FeedBack.HeaderText = "Feedbacks";
            FeedBack.MinimumWidth = 6;
            FeedBack.Name = "FeedBack";
            // 
            // label8
            // 
            label8.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.Location = new Point(302, 2);
            label8.Name = "label8";
            label8.Size = new Size(179, 25);
            label8.TabIndex = 0;
            label8.Text = "General Evaluation";
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 4;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.Controls.Add(panel4, 0, 0);
            tableLayoutPanel1.Controls.Add(panel5, 1, 0);
            tableLayoutPanel1.Controls.Add(panel6, 2, 0);
            tableLayoutPanel1.Controls.Add(panel7, 3, 0);
            tableLayoutPanel1.Dock = DockStyle.Top;
            tableLayoutPanel1.Location = new Point(10, 10);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Size = new Size(799, 149);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // panel4
            // 
            panel4.BackColor = Color.FromArgb(31, 51, 92);
            panel4.Controls.Add(label10);
            panel4.Controls.Add(label7);
            panel4.Controls.Add(label3);
            panel4.Dock = DockStyle.Top;
            panel4.Location = new Point(3, 3);
            panel4.Name = "panel4";
            panel4.Padding = new Padding(5);
            panel4.Size = new Size(193, 121);
            panel4.TabIndex = 0;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label10.ForeColor = SystemColors.ButtonHighlight;
            label10.Location = new Point(8, 56);
            label10.Name = "label10";
            label10.Size = new Size(128, 45);
            label10.TabIndex = 2;
            label10.Text = "label10";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Dock = DockStyle.Fill;
            label7.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.ForeColor = SystemColors.ButtonHighlight;
            label7.Location = new Point(5, 5);
            label7.Name = "label7";
            label7.Size = new Size(159, 30);
            label7.TabIndex = 1;
            label7.Text = "Total Students:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Dock = DockStyle.Fill;
            label3.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = SystemColors.ButtonHighlight;
            label3.Location = new Point(5, 5);
            label3.Name = "label3";
            label3.Size = new Size(159, 30);
            label3.TabIndex = 0;
            label3.Text = "Total Students:";
            // 
            // panel5
            // 
            panel5.BackColor = Color.FromArgb(31, 51, 92);
            panel5.Controls.Add(label11);
            panel5.Controls.Add(label4);
            panel5.Dock = DockStyle.Top;
            panel5.Location = new Point(202, 3);
            panel5.Name = "panel5";
            panel5.Padding = new Padding(5);
            panel5.Size = new Size(193, 121);
            panel5.TabIndex = 1;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label11.ForeColor = SystemColors.ButtonHighlight;
            label11.Location = new Point(8, 58);
            label11.Name = "label11";
            label11.Size = new Size(128, 45);
            label11.TabIndex = 2;
            label11.Text = "label11";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Dock = DockStyle.Fill;
            label4.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = SystemColors.ButtonHighlight;
            label4.Location = new Point(5, 5);
            label4.Name = "label4";
            label4.Size = new Size(163, 30);
            label4.TabIndex = 1;
            label4.Text = "Done Students:";
            // 
            // panel6
            // 
            panel6.BackColor = Color.FromArgb(31, 51, 92);
            panel6.Controls.Add(label12);
            panel6.Controls.Add(label5);
            panel6.Dock = DockStyle.Top;
            panel6.Location = new Point(401, 3);
            panel6.Name = "panel6";
            panel6.Padding = new Padding(5);
            panel6.Size = new Size(193, 121);
            panel6.TabIndex = 2;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label12.ForeColor = SystemColors.ButtonHighlight;
            label12.Location = new Point(8, 58);
            label12.Name = "label12";
            label12.Size = new Size(128, 45);
            label12.TabIndex = 3;
            label12.Text = "label12";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Dock = DockStyle.Fill;
            label5.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.ForeColor = SystemColors.ButtonHighlight;
            label5.Location = new Point(5, 5);
            label5.Name = "label5";
            label5.Size = new Size(155, 30);
            label5.TabIndex = 2;
            label5.Text = "Total Subjects:";
            // 
            // panel7
            // 
            panel7.BackColor = Color.FromArgb(31, 51, 92);
            panel7.Controls.Add(label13);
            panel7.Controls.Add(label6);
            panel7.Dock = DockStyle.Top;
            panel7.Location = new Point(600, 3);
            panel7.Name = "panel7";
            panel7.Padding = new Padding(5);
            panel7.Size = new Size(196, 121);
            panel7.TabIndex = 3;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label13.ForeColor = SystemColors.ButtonHighlight;
            label13.Location = new Point(8, 58);
            label13.Name = "label13";
            label13.Size = new Size(128, 45);
            label13.TabIndex = 4;
            label13.Text = "label13";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Dock = DockStyle.Fill;
            label6.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.ForeColor = SystemColors.ButtonHighlight;
            label6.Location = new Point(5, 5);
            label6.Name = "label6";
            label6.Size = new Size(138, 30);
            label6.TabIndex = 3;
            label6.Text = "Credit Score:";
            // 
            // TeacherDashboard
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(819, 553);
            Controls.Add(panel10);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "TeacherDashboard";
            Text = "TeacherDashboard";
            Load += TeacherDashboard_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel3.ResumeLayout(false);
            panel10.ResumeLayout(false);
            tableLayoutPanel2.ResumeLayout(false);
            panel8.ResumeLayout(false);
            panel8.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            tableLayoutPanel1.ResumeLayout(false);
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            panel6.ResumeLayout(false);
            panel6.PerformLayout();
            panel7.ResumeLayout(false);
            panel7.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private Panel panel3;
        private Label label1;
        private Label label2;
        private TableLayoutPanel tableLayoutPanel1;
        private Panel panel4;
        private Panel panel5;
        private Panel panel6;
        private Panel panel7;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private TableLayoutPanel tableLayoutPanel2;
        private Label label7;
        private Panel panel8;
        private Label label8;
        private Button button1;
        private Panel panel10;
        private Label label10;
        private Label label11;
        private Label label12;
        private Label label13;
        private Label label14;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn FeedBack;
    }
}