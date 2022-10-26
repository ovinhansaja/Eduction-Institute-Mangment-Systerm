namespace Eduction_Institute_Mangment_Systerm
{
    partial class Menu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Menu));
            this.panel2 = new System.Windows.Forms.Panel();
            this.btn_form_max = new FontAwesome.Sharp.IconButton();
            this.btn_form_mini = new FontAwesome.Sharp.IconButton();
            this.btn_form_close = new FontAwesome.Sharp.IconButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_login_edit = new FontAwesome.Sharp.IconButton();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.btn_attendance = new FontAwesome.Sharp.IconButton();
            this.btn_staff = new FontAwesome.Sharp.IconButton();
            this.btn_gmil = new FontAwesome.Sharp.IconButton();
            this.btn_fb = new FontAwesome.Sharp.IconButton();
            this.btn_finance = new FontAwesome.Sharp.IconButton();
            this.btn_teacher = new FontAwesome.Sharp.IconButton();
            this.btn_student = new FontAwesome.Sharp.IconButton();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(204)))), ((int)(((byte)(0)))));
            this.panel2.Controls.Add(this.btn_form_max);
            this.panel2.Controls.Add(this.btn_form_mini);
            this.panel2.Controls.Add(this.btn_form_close);
            this.panel2.Location = new System.Drawing.Point(298, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1470, 49);
            this.panel2.TabIndex = 1;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            this.panel2.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel2_MouseDown);
            // 
            // btn_form_max
            // 
            this.btn_form_max.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_form_max.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_form_max.FlatAppearance.BorderSize = 0;
            this.btn_form_max.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_form_max.IconChar = FontAwesome.Sharp.IconChar.WindowMaximize;
            this.btn_form_max.IconColor = System.Drawing.Color.Black;
            this.btn_form_max.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btn_form_max.IconSize = 25;
            this.btn_form_max.Location = new System.Drawing.Point(1360, 4);
            this.btn_form_max.Name = "btn_form_max";
            this.btn_form_max.Size = new System.Drawing.Size(48, 36);
            this.btn_form_max.TabIndex = 4;
            this.btn_form_max.UseVisualStyleBackColor = true;
            this.btn_form_max.Click += new System.EventHandler(this.btn_form_max_Click);
            // 
            // btn_form_mini
            // 
            this.btn_form_mini.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_form_mini.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_form_mini.FlatAppearance.BorderSize = 0;
            this.btn_form_mini.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_form_mini.IconChar = FontAwesome.Sharp.IconChar.Minus;
            this.btn_form_mini.IconColor = System.Drawing.Color.Black;
            this.btn_form_mini.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btn_form_mini.IconSize = 25;
            this.btn_form_mini.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_form_mini.Location = new System.Drawing.Point(1310, 4);
            this.btn_form_mini.Name = "btn_form_mini";
            this.btn_form_mini.Size = new System.Drawing.Size(48, 36);
            this.btn_form_mini.TabIndex = 3;
            this.btn_form_mini.UseVisualStyleBackColor = true;
            this.btn_form_mini.Click += new System.EventHandler(this.iconButton2_Click);
            // 
            // btn_form_close
            // 
            this.btn_form_close.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_form_close.BackColor = System.Drawing.Color.Transparent;
            this.btn_form_close.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_form_close.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btn_form_close.FlatAppearance.BorderSize = 0;
            this.btn_form_close.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_form_close.IconChar = FontAwesome.Sharp.IconChar.Times;
            this.btn_form_close.IconColor = System.Drawing.Color.Black;
            this.btn_form_close.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btn_form_close.IconSize = 25;
            this.btn_form_close.Location = new System.Drawing.Point(1414, 4);
            this.btn_form_close.Name = "btn_form_close";
            this.btn_form_close.Size = new System.Drawing.Size(48, 36);
            this.btn_form_close.TabIndex = 2;
            this.btn_form_close.UseVisualStyleBackColor = false;
            this.btn_form_close.Click += new System.EventHandler(this.btn_form_close_Click);
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Location = new System.Drawing.Point(12, 128);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1748, 781);
            this.panel1.TabIndex = 1;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(536, 47);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(676, 687);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // panel3
            // 
            this.panel3.Location = new System.Drawing.Point(4, 896);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1465, 71);
            this.panel3.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Tai Le", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(568, 936);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(668, 39);
            this.label2.TabIndex = 1;
            this.label2.Text = "Vision Education Institute Mangement System";
            // 
            // btn_login_edit
            // 
            this.btn_login_edit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_login_edit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_login_edit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_login_edit.ForeColor = System.Drawing.Color.Black;
            this.btn_login_edit.IconChar = FontAwesome.Sharp.IconChar.UserCircle;
            this.btn_login_edit.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(204)))), ((int)(((byte)(0)))));
            this.btn_login_edit.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btn_login_edit.IconSize = 50;
            this.btn_login_edit.Location = new System.Drawing.Point(1685, 59);
            this.btn_login_edit.Name = "btn_login_edit";
            this.btn_login_edit.Size = new System.Drawing.Size(61, 59);
            this.btn_login_edit.TabIndex = 12;
            this.btn_login_edit.UseVisualStyleBackColor = true;
            this.btn_login_edit.Click += new System.EventHandler(this.btn_login_edit_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(41, -7);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(251, 131);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 11;
            this.pictureBox2.TabStop = false;
            // 
            // btn_attendance
            // 
            this.btn_attendance.BackColor = System.Drawing.Color.Black;
            this.btn_attendance.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_attendance.FlatAppearance.BorderSize = 0;
            this.btn_attendance.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_attendance.Font = new System.Drawing.Font("Microsoft Tai Le", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_attendance.ForeColor = System.Drawing.Color.White;
            this.btn_attendance.IconChar = FontAwesome.Sharp.IconChar.Marker;
            this.btn_attendance.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(169)))), ((int)(((byte)(60)))));
            this.btn_attendance.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btn_attendance.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_attendance.Location = new System.Drawing.Point(857, 55);
            this.btn_attendance.Name = "btn_attendance";
            this.btn_attendance.Size = new System.Drawing.Size(165, 67);
            this.btn_attendance.TabIndex = 5;
            this.btn_attendance.Text = "Attendance";
            this.btn_attendance.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_attendance.UseVisualStyleBackColor = false;
            this.btn_attendance.Click += new System.EventHandler(this.btn_attendance_Click);
            // 
            // btn_staff
            // 
            this.btn_staff.BackColor = System.Drawing.Color.Black;
            this.btn_staff.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_staff.FlatAppearance.BorderSize = 0;
            this.btn_staff.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_staff.Font = new System.Drawing.Font("Microsoft Tai Le", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_staff.ForeColor = System.Drawing.Color.White;
            this.btn_staff.IconChar = FontAwesome.Sharp.IconChar.UserFriends;
            this.btn_staff.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(169)))), ((int)(((byte)(60)))));
            this.btn_staff.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btn_staff.IconSize = 50;
            this.btn_staff.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_staff.Location = new System.Drawing.Point(593, 55);
            this.btn_staff.Name = "btn_staff";
            this.btn_staff.Size = new System.Drawing.Size(117, 67);
            this.btn_staff.TabIndex = 3;
            this.btn_staff.Text = "Staff";
            this.btn_staff.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_staff.UseVisualStyleBackColor = false;
            this.btn_staff.Click += new System.EventHandler(this.btn_staff_Click);
            // 
            // btn_gmil
            // 
            this.btn_gmil.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_gmil.BackColor = System.Drawing.Color.Black;
            this.btn_gmil.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_gmil.FlatAppearance.BorderSize = 0;
            this.btn_gmil.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_gmil.Font = new System.Drawing.Font("Microsoft Tai Le", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_gmil.ForeColor = System.Drawing.Color.White;
            this.btn_gmil.IconChar = FontAwesome.Sharp.IconChar.At;
            this.btn_gmil.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(204)))), ((int)(((byte)(0)))));
            this.btn_gmil.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btn_gmil.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_gmil.Location = new System.Drawing.Point(1556, 54);
            this.btn_gmil.Name = "btn_gmil";
            this.btn_gmil.Size = new System.Drawing.Size(123, 69);
            this.btn_gmil.TabIndex = 10;
            this.btn_gmil.Text = "Gmail";
            this.btn_gmil.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_gmil.UseVisualStyleBackColor = false;
            this.btn_gmil.Click += new System.EventHandler(this.btn_gmil_Click);
            // 
            // btn_fb
            // 
            this.btn_fb.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_fb.BackColor = System.Drawing.Color.Black;
            this.btn_fb.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_fb.FlatAppearance.BorderSize = 0;
            this.btn_fb.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_fb.Font = new System.Drawing.Font("Microsoft Tai Le", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_fb.ForeColor = System.Drawing.Color.White;
            this.btn_fb.IconChar = FontAwesome.Sharp.IconChar.Facebook;
            this.btn_fb.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(169)))), ((int)(((byte)(60)))));
            this.btn_fb.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btn_fb.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_fb.Location = new System.Drawing.Point(1402, 56);
            this.btn_fb.Name = "btn_fb";
            this.btn_fb.Size = new System.Drawing.Size(148, 69);
            this.btn_fb.TabIndex = 9;
            this.btn_fb.Text = "FaceBook";
            this.btn_fb.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_fb.UseVisualStyleBackColor = false;
            this.btn_fb.Click += new System.EventHandler(this.btn_fb_Click);
            // 
            // btn_finance
            // 
            this.btn_finance.BackColor = System.Drawing.Color.Black;
            this.btn_finance.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_finance.FlatAppearance.BorderSize = 0;
            this.btn_finance.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_finance.Font = new System.Drawing.Font("Microsoft Tai Le", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_finance.ForeColor = System.Drawing.Color.White;
            this.btn_finance.IconChar = FontAwesome.Sharp.IconChar.DollarSign;
            this.btn_finance.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(204)))), ((int)(((byte)(0)))));
            this.btn_finance.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btn_finance.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_finance.Location = new System.Drawing.Point(716, 55);
            this.btn_finance.Name = "btn_finance";
            this.btn_finance.Size = new System.Drawing.Size(135, 67);
            this.btn_finance.TabIndex = 4;
            this.btn_finance.Text = "Finance";
            this.btn_finance.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_finance.UseVisualStyleBackColor = false;
            this.btn_finance.Click += new System.EventHandler(this.btn_finance_Click);
            // 
            // btn_teacher
            // 
            this.btn_teacher.BackColor = System.Drawing.Color.Black;
            this.btn_teacher.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_teacher.FlatAppearance.BorderSize = 0;
            this.btn_teacher.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_teacher.Font = new System.Drawing.Font("Microsoft Tai Le", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_teacher.ForeColor = System.Drawing.Color.White;
            this.btn_teacher.IconChar = FontAwesome.Sharp.IconChar.ChalkboardTeacher;
            this.btn_teacher.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(204)))), ((int)(((byte)(0)))));
            this.btn_teacher.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btn_teacher.IconSize = 50;
            this.btn_teacher.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_teacher.Location = new System.Drawing.Point(443, 55);
            this.btn_teacher.Name = "btn_teacher";
            this.btn_teacher.Size = new System.Drawing.Size(144, 67);
            this.btn_teacher.TabIndex = 2;
            this.btn_teacher.Text = "Teacher";
            this.btn_teacher.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_teacher.UseVisualStyleBackColor = false;
            this.btn_teacher.Click += new System.EventHandler(this.btn_teacher_Click);
            // 
            // btn_student
            // 
            this.btn_student.BackColor = System.Drawing.Color.Black;
            this.btn_student.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btn_student.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_student.FlatAppearance.BorderSize = 0;
            this.btn_student.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_student.Font = new System.Drawing.Font("Microsoft Tai Le", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_student.ForeColor = System.Drawing.Color.White;
            this.btn_student.IconChar = FontAwesome.Sharp.IconChar.UserAlt;
            this.btn_student.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(169)))), ((int)(((byte)(60)))));
            this.btn_student.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btn_student.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_student.Location = new System.Drawing.Point(298, 55);
            this.btn_student.Name = "btn_student";
            this.btn_student.Size = new System.Drawing.Size(139, 67);
            this.btn_student.TabIndex = 1;
            this.btn_student.Text = "Student";
            this.btn_student.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_student.UseVisualStyleBackColor = false;
            this.btn_student.Click += new System.EventHandler(this.btn_student_Click);
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(1768, 1014);
            this.Controls.Add(this.btn_login_edit);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.btn_attendance);
            this.Controls.Add(this.btn_staff);
            this.Controls.Add(this.btn_gmil);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btn_fb);
            this.Controls.Add(this.btn_finance);
            this.Controls.Add(this.btn_teacher);
            this.Controls.Add(this.btn_student);
            this.Controls.Add(this.panel1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Menu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Main Menu";
            this.panel2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private FontAwesome.Sharp.IconButton btn_attendance;
        private FontAwesome.Sharp.IconButton btn_finance;
        private FontAwesome.Sharp.IconButton btn_staff;
        private FontAwesome.Sharp.IconButton btn_teacher;
        private FontAwesome.Sharp.IconButton btn_student;
        private System.Windows.Forms.Panel panel2;
        private FontAwesome.Sharp.IconButton btn_form_max;
        private FontAwesome.Sharp.IconButton btn_form_mini;
        private FontAwesome.Sharp.IconButton btn_form_close;
        private FontAwesome.Sharp.IconButton btn_gmil;
        private FontAwesome.Sharp.IconButton btn_fb;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private FontAwesome.Sharp.IconButton btn_login_edit;
    }
}

