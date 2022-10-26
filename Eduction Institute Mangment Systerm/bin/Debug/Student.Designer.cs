namespace Eduction_Institute_Mangment_Systerm
{
    partial class student
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(student));
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_add_student = new FontAwesome.Sharp.IconButton();
            this.btn_Update = new FontAwesome.Sharp.IconButton();
            this.btn_student_view = new FontAwesome.Sharp.IconButton();
            this.student_panel = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            this.student_panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(204)))), ((int)(((byte)(0)))));
            this.panel1.Controls.Add(this.btn_add_student);
            this.panel1.Controls.Add(this.btn_Update);
            this.panel1.Controls.Add(this.btn_student_view);
            this.panel1.Location = new System.Drawing.Point(-3, 7);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1758, 57);
            this.panel1.TabIndex = 25;
            // 
            // btn_add_student
            // 
            this.btn_add_student.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_add_student.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(204)))), ((int)(((byte)(0)))));
            this.btn_add_student.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_add_student.FlatAppearance.BorderSize = 0;
            this.btn_add_student.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_add_student.Font = new System.Drawing.Font("Microsoft Tai Le", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_add_student.ForeColor = System.Drawing.Color.Black;
            this.btn_add_student.IconChar = FontAwesome.Sharp.IconChar.UserPlus;
            this.btn_add_student.IconColor = System.Drawing.Color.Black;
            this.btn_add_student.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btn_add_student.IconSize = 50;
            this.btn_add_student.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_add_student.Location = new System.Drawing.Point(671, 3);
            this.btn_add_student.Name = "btn_add_student";
            this.btn_add_student.Size = new System.Drawing.Size(174, 51);
            this.btn_add_student.TabIndex = 2;
            this.btn_add_student.Text = "Add Student";
            this.btn_add_student.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_add_student.UseVisualStyleBackColor = false;
            this.btn_add_student.Click += new System.EventHandler(this.btn_add_student_Click);
            // 
            // btn_Update
            // 
            this.btn_Update.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_Update.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(204)))), ((int)(((byte)(0)))));
            this.btn_Update.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Update.FlatAppearance.BorderSize = 0;
            this.btn_Update.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Update.Font = new System.Drawing.Font("Microsoft Tai Le", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Update.ForeColor = System.Drawing.Color.Black;
            this.btn_Update.IconChar = FontAwesome.Sharp.IconChar.Edit;
            this.btn_Update.IconColor = System.Drawing.Color.Black;
            this.btn_Update.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btn_Update.IconSize = 50;
            this.btn_Update.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Update.Location = new System.Drawing.Point(851, 3);
            this.btn_Update.Name = "btn_Update";
            this.btn_Update.Size = new System.Drawing.Size(120, 51);
            this.btn_Update.TabIndex = 3;
            this.btn_Update.Text = "Update";
            this.btn_Update.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_Update.UseVisualStyleBackColor = false;
            this.btn_Update.Click += new System.EventHandler(this.btn_student_edit_Click);
            // 
            // btn_student_view
            // 
            this.btn_student_view.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_student_view.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(204)))), ((int)(((byte)(0)))));
            this.btn_student_view.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_student_view.FlatAppearance.BorderSize = 0;
            this.btn_student_view.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_student_view.Font = new System.Drawing.Font("Microsoft Tai Le", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_student_view.ForeColor = System.Drawing.Color.Black;
            this.btn_student_view.IconChar = FontAwesome.Sharp.IconChar.AddressCard;
            this.btn_student_view.IconColor = System.Drawing.Color.Black;
            this.btn_student_view.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btn_student_view.IconSize = 50;
            this.btn_student_view.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_student_view.Location = new System.Drawing.Point(977, 3);
            this.btn_student_view.Name = "btn_student_view";
            this.btn_student_view.Size = new System.Drawing.Size(111, 51);
            this.btn_student_view.TabIndex = 5;
            this.btn_student_view.Text = "View";
            this.btn_student_view.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_student_view.UseVisualStyleBackColor = false;
            this.btn_student_view.Click += new System.EventHandler(this.btn_student_view_Click);
            // 
            // student_panel
            // 
            this.student_panel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.student_panel.BackColor = System.Drawing.Color.White;
            this.student_panel.Controls.Add(this.pictureBox1);
            this.student_panel.Location = new System.Drawing.Point(6, 76);
            this.student_panel.Name = "student_panel";
            this.student_panel.Size = new System.Drawing.Size(1738, 693);
            this.student_panel.TabIndex = 26;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(539, 6);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(676, 687);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // student
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(1748, 781);
            this.Controls.Add(this.student_panel);
            this.Controls.Add(this.panel1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "student";
            this.Text = "Student";
            this.Load += new System.EventHandler(this.student_Load);
            this.panel1.ResumeLayout(false);
            this.student_panel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private FontAwesome.Sharp.IconButton btn_add_student;
        private FontAwesome.Sharp.IconButton btn_Update;
        private FontAwesome.Sharp.IconButton btn_student_view;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel student_panel;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}