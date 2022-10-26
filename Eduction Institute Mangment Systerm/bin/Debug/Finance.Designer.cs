namespace Eduction_Institute_Mangment_Systerm
{
    partial class Finance
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Finance));
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_add_payment = new FontAwesome.Sharp.IconButton();
            this.btn_view_payment = new FontAwesome.Sharp.IconButton();
            this.finance_panel = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            this.finance_panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(204)))), ((int)(((byte)(0)))));
            this.panel1.Controls.Add(this.btn_add_payment);
            this.panel1.Controls.Add(this.btn_view_payment);
            this.panel1.Location = new System.Drawing.Point(-6, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1754, 57);
            this.panel1.TabIndex = 29;
            // 
            // btn_add_payment
            // 
            this.btn_add_payment.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_add_payment.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(204)))), ((int)(((byte)(0)))));
            this.btn_add_payment.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_add_payment.FlatAppearance.BorderSize = 0;
            this.btn_add_payment.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_add_payment.Font = new System.Drawing.Font("Microsoft Tai Le", 10.2F, System.Drawing.FontStyle.Bold);
            this.btn_add_payment.ForeColor = System.Drawing.Color.Black;
            this.btn_add_payment.IconChar = FontAwesome.Sharp.IconChar.Plus;
            this.btn_add_payment.IconColor = System.Drawing.Color.Black;
            this.btn_add_payment.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btn_add_payment.IconSize = 50;
            this.btn_add_payment.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_add_payment.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btn_add_payment.Location = new System.Drawing.Point(767, 1);
            this.btn_add_payment.Name = "btn_add_payment";
            this.btn_add_payment.Size = new System.Drawing.Size(115, 56);
            this.btn_add_payment.TabIndex = 15;
            this.btn_add_payment.Text = "Add ";
            this.btn_add_payment.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_add_payment.UseVisualStyleBackColor = false;
            this.btn_add_payment.Click += new System.EventHandler(this.btn_add_payment_Click);
            // 
            // btn_view_payment
            // 
            this.btn_view_payment.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_view_payment.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(204)))), ((int)(((byte)(0)))));
            this.btn_view_payment.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_view_payment.FlatAppearance.BorderSize = 0;
            this.btn_view_payment.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_view_payment.Font = new System.Drawing.Font("Microsoft Tai Le", 10.2F, System.Drawing.FontStyle.Bold);
            this.btn_view_payment.ForeColor = System.Drawing.Color.Black;
            this.btn_view_payment.IconChar = FontAwesome.Sharp.IconChar.Clipboard;
            this.btn_view_payment.IconColor = System.Drawing.Color.Black;
            this.btn_view_payment.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btn_view_payment.IconSize = 50;
            this.btn_view_payment.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_view_payment.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btn_view_payment.Location = new System.Drawing.Point(888, 0);
            this.btn_view_payment.Name = "btn_view_payment";
            this.btn_view_payment.Size = new System.Drawing.Size(116, 57);
            this.btn_view_payment.TabIndex = 16;
            this.btn_view_payment.Text = "View ";
            this.btn_view_payment.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_view_payment.UseVisualStyleBackColor = false;
            this.btn_view_payment.Click += new System.EventHandler(this.btn_view_payment_Click);
            // 
            // finance_panel
            // 
            this.finance_panel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.finance_panel.Controls.Add(this.pictureBox1);
            this.finance_panel.Location = new System.Drawing.Point(6, 85);
            this.finance_panel.Name = "finance_panel";
            this.finance_panel.Size = new System.Drawing.Size(1742, 692);
            this.finance_panel.TabIndex = 30;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(533, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(676, 687);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // Finance
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1748, 781);
            this.Controls.Add(this.finance_panel);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Finance";
            this.Text = "Finance";
            this.panel1.ResumeLayout(false);
            this.finance_panel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private FontAwesome.Sharp.IconButton btn_add_payment;
        private FontAwesome.Sharp.IconButton btn_view_payment;
        private System.Windows.Forms.Panel finance_panel;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}