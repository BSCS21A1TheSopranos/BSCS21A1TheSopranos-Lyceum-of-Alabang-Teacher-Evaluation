namespace Teacher_Evaluation
{
    partial class MapStudentsTeachers
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
            components = new System.ComponentModel.Container();
            bindingSource1 = new BindingSource(components);
            dataGridView1 = new DataGridView();
            TeachersName = new DataGridViewTextBoxColumn();
            ProfID = new DataGridViewTextBoxColumn();
            Subject = new DataGridViewTextBoxColumn();
            textBox1 = new TextBox();
            textBox3 = new TextBox();
            button1 = new Button();
            label1 = new Label();
            label2 = new Label();
            panel1 = new Panel();
            panel2 = new Panel();
            panel3 = new Panel();
            button2 = new Button();
            label3 = new Label();
            ((System.ComponentModel.ISupportInitialize)bindingSource1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { TeachersName, ProfID, Subject });
            dataGridView1.Location = new Point(364, 111);
            dataGridView1.Margin = new Padding(3, 2, 3, 2);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(324, 299);
            dataGridView1.TabIndex = 0;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // TeachersName
            // 
            TeachersName.HeaderText = "Column1";
            TeachersName.MinimumWidth = 6;
            TeachersName.Name = "TeachersName";
            // 
            // ProfID
            // 
            ProfID.HeaderText = "Column1";
            ProfID.MinimumWidth = 6;
            ProfID.Name = "ProfID";
            // 
            // Subject
            // 
            Subject.HeaderText = "Column1";
            Subject.MinimumWidth = 6;
            Subject.Name = "Subject";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(129, 171);
            textBox1.Margin = new Padding(3, 2, 3, 2);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(194, 23);
            textBox1.TabIndex = 1;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(129, 255);
            textBox3.Margin = new Padding(3, 2, 3, 2);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(194, 23);
            textBox3.TabIndex = 3;
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.Location = new Point(205, 347);
            button1.Margin = new Padding(3, 2, 3, 2);
            button1.Name = "button1";
            button1.Size = new Size(118, 44);
            button1.TabIndex = 4;
            button1.Text = "Submit";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(45, 171);
            label1.Name = "label1";
            label1.Size = new Size(64, 15);
            label1.TabIndex = 5;
            label1.Text = "Teacher ID:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(47, 258);
            label2.Name = "label2";
            label2.Size = new Size(49, 15);
            label2.TabIndex = 6;
            label2.Text = "Subject:";
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(31, 51, 92);
            panel1.Controls.Add(label3);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(700, 75);
            panel1.TabIndex = 7;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(243, 196, 27);
            panel2.Dock = DockStyle.Bottom;
            panel2.Location = new Point(0, 432);
            panel2.Name = "panel2";
            panel2.Size = new Size(700, 11);
            panel2.TabIndex = 8;
            // 
            // panel3
            // 
            panel3.BackColor = Color.FromArgb(243, 196, 27);
            panel3.Dock = DockStyle.Top;
            panel3.Location = new Point(0, 75);
            panel3.Name = "panel3";
            panel3.Size = new Size(700, 15);
            panel3.TabIndex = 9;
            // 
            // button2
            // 
            button2.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button2.Location = new Point(45, 347);
            button2.Margin = new Padding(3, 2, 3, 2);
            button2.Name = "button2";
            button2.Size = new Size(118, 44);
            button2.TabIndex = 10;
            button2.Text = "Cancel";
            button2.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 21.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = SystemColors.ButtonHighlight;
            label3.Location = new Point(182, 18);
            label3.Name = "label3";
            label3.Size = new Size(344, 40);
            label3.TabIndex = 0;
            label3.Text = "Map Student to Teacher";
            // 
            // MapStudentsTeachers
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(700, 443);
            Controls.Add(button2);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(button1);
            Controls.Add(textBox3);
            Controls.Add(textBox1);
            Controls.Add(dataGridView1);
            Margin = new Padding(3, 2, 3, 2);
            Name = "MapStudentsTeachers";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)bindingSource1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private BindingSource bindingSource1;
        private DataGridView dataGridView1;
        private TextBox textBox1;
        private TextBox textBox3;
        private Button button1;
        private Label label1;
        private Label label2;
        private DataGridViewTextBoxColumn TeachersName;
        private DataGridViewTextBoxColumn ProfID;
        private DataGridViewTextBoxColumn Subject;
        private Panel panel1;
        private Panel panel2;
        private Panel panel3;
        private Button button2;
        private Label label3;
    }
}