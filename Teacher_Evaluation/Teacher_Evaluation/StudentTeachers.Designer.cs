namespace Teacher_Evaluation
{
    partial class StudentTeachers
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            dataGridView1 = new DataGridView();
            button1 = new Button();
            pictureBox1 = new PictureBox();
            label1 = new Label();
            pictureBox2 = new PictureBox();
            Subject = new DataGridViewTextBoxColumn();
            Teacher = new DataGridViewTextBoxColumn();
            TeacherName = new DataGridViewTextBoxColumn();
            TeachersID = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.Font = new Font("Segoe UI Historic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Subject, Teacher, TeacherName, TeachersID });
            dataGridView1.Location = new Point(12, 89);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.Size = new Size(983, 399);
            dataGridView1.TabIndex = 0;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            dataGridView1.CellDoubleClick += dataGridView1_CellDoubleClick;
            // 
            // button1
            // 
            button1.BackColor = SystemColors.ButtonFace;
            button1.Cursor = Cursors.Hand;
            button1.Font = new Font("Segoe UI Historic", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.Location = new Point(790, 494);
            button1.Name = "button1";
            button1.Size = new Size(205, 53);
            button1.TabIndex = 1;
            button1.Text = "SIGN OUT";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.FromArgb(232, 188, 27);
            pictureBox1.Location = new Point(-21, -1);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(1446, 84);
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.FromArgb(232, 188, 27);
            label1.Font = new Font("Segoe UI Historic", 22.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(67, 15);
            label1.Name = "label1";
            label1.Size = new Size(301, 50);
            label1.TabIndex = 3;
            label1.Text = "STUDENT FORM";
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = Color.FromArgb(232, 188, 27);
            pictureBox2.BackgroundImage = Properties.Resources.Registration_form__100_x_100_px___1_;
            pictureBox2.BackgroundImageLayout = ImageLayout.Center;
            pictureBox2.Location = new Point(12, 12);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(49, 57);
            pictureBox2.TabIndex = 4;
            pictureBox2.TabStop = false;
            // 
            // Subject
            // 
            Subject.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            Subject.Frozen = true;
            Subject.HeaderText = "Subjects";
            Subject.MaxInputLength = 30767;
            Subject.MinimumWidth = 6;
            Subject.Name = "Subject";
            Subject.ReadOnly = true;
            Subject.Width = 465;
            // 
            // Teacher
            // 
            Teacher.HeaderText = "Teacher";
            Teacher.MinimumWidth = 6;
            Teacher.Name = "Teacher";
            Teacher.ReadOnly = true;
            Teacher.Visible = false;
            // 
            // TeacherName
            // 
            TeacherName.HeaderText = "Teachers";
            TeacherName.MinimumWidth = 6;
            TeacherName.Name = "TeacherName";
            TeacherName.ReadOnly = true;
            // 
            // TeachersID
            // 
            TeachersID.HeaderText = "Column1";
            TeachersID.MinimumWidth = 6;
            TeachersID.Name = "TeachersID";
            TeachersID.ReadOnly = true;
            TeachersID.Visible = false;
            // 
            // StudentTeachers
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(31, 51, 92);
            ClientSize = new Size(1007, 559);
            Controls.Add(pictureBox2);
            Controls.Add(label1);
            Controls.Add(button1);
            Controls.Add(dataGridView1);
            Controls.Add(pictureBox1);
            Name = "StudentTeachers";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private Button button1;
        private PictureBox pictureBox1;
        private Label label1;
        private PictureBox pictureBox2;
        private DataGridViewTextBoxColumn Subject;
        private DataGridViewTextBoxColumn Teacher;
        private DataGridViewTextBoxColumn TeacherName;
        private DataGridViewTextBoxColumn TeachersID;
    }
}