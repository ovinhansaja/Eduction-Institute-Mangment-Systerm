namespace Eduction_Institute_Mangment_Systerm
{
    partial class Staff
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Staff));
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_add_staff = new FontAwesome.Sharp.IconButton();
            this.btn_staff_edit = new FontAwesome.Sharp.IconButton();
            this.btn_staff_view = new FontAwesome.Sharp.IconButton();
            this.staff_panel = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            this.staff_panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            resources.ApplyResources(this.panel1, "panel1");
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(204)))), ((int)(((byte)(0)))));
            this.panel1.Controls.Add(this.btn_add_staff);
            this.panel1.Controls.Add(this.btn_staff_edit);
            this.panel1.Controls.Add(this.btn_staff_view);
            this.panel1.Name = "panel1";
            // 
            // btn_add_staff
            // 
            resources.ApplyResources(this.btn_add_staff, "btn_add_staff");
            this.btn_add_staff.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(204)))), ((int)(((byte)(0)))));
            this.btn_add_staff.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_add_staff.FlatAppearance.BorderSize = 0;
            this.btn_add_staff.ForeColor = System.Drawing.Color.Black;
            this.btn_add_staff.IconChar = FontAwesome.Sharp.IconChar.UserPlus;
            this.btn_add_staff.IconColor = System.Drawing.Color.Black;
            this.btn_add_staff.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btn_add_staff.IconSize = 50;
            this.btn_add_staff.Name = "btn_add_staff";
            this.btn_add_staff.UseVisualStyleBackColor = false;
            this.btn_add_staff.Click += new System.EventHandler(this.btn_add_staff_Click);
            // 
            // btn_staff_edit
            // 
            resources.ApplyResources(this.btn_staff_edit, "btn_staff_edit");
            this.btn_staff_edit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(204)))), ((int)(((byte)(0)))));
            this.btn_staff_edit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_staff_edit.FlatAppearance.BorderSize = 0;
            this.btn_staff_edit.ForeColor = System.Drawing.Color.Black;
            this.btn_staff_edit.IconChar = FontAwesome.Sharp.IconChar.Edit;
            this.btn_staff_edit.IconColor = System.Drawing.Color.Black;
            this.btn_staff_edit.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btn_staff_edit.IconSize = 50;
            this.btn_staff_edit.Name = "btn_staff_edit";
            this.btn_staff_edit.UseVisualStyleBackColor = false;
            this.btn_staff_edit.Click += new System.EventHandler(this.btn_staff_edit_Click);
            // 
            // btn_staff_view
            // 
            resources.ApplyResources(this.btn_staff_view, "btn_staff_view");
            this.btn_staff_view.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(204)))), ((int)(((byte)(0)))));
            this.btn_staff_view.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_staff_view.FlatAppearance.BorderSize = 0;
            this.btn_staff_view.ForeColor = System.Drawing.Color.Black;
            this.btn_staff_view.IconChar = FontAwesome.Sharp.IconChar.AddressCard;
            this.btn_staff_view.IconColor = System.Drawing.Color.Black;
            this.btn_staff_view.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btn_staff_view.IconSize = 50;
            this.btn_staff_view.Name = "btn_staff_view";
            this.btn_staff_view.UseVisualStyleBackColor = false;
            this.btn_staff_view.Click += new System.EventHandler(this.btn_staff_view_Click);
            // 
            // staff_panel
            // 
            resources.ApplyResources(this.staff_panel, "staff_panel");
            this.staff_panel.Controls.Add(this.pictureBox1);
            this.staff_panel.Name = "staff_panel";
            // 
            // pictureBox1
            // 
            resources.ApplyResources(this.pictureBox1, "pictureBox1");
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.TabStop = false;
            // 
            // Staff
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.staff_panel);
            this.Controls.Add(this.panel1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Staff";
            this.panel1.ResumeLayout(false);
            this.staff_panel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private FontAwesome.Sharp.IconButton btn_staff_view;
        private FontAwesome.Sharp.IconButton btn_staff_edit;
        private FontAwesome.Sharp.IconButton btn_add_staff;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel staff_panel;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}