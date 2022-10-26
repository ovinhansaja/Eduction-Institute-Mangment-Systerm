namespace Eduction_Institute_Mangment_Systerm
{
    partial class Attendance
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.Rbtn_t = new System.Windows.Forms.RadioButton();
            this.dgv_ad = new System.Windows.Forms.DataGridView();
            this.btn_at = new System.Windows.Forms.Button();
            this.txt_ad = new System.Windows.Forms.TextBox();
            this.Rbtn_s = new System.Windows.Forms.RadioButton();
            this.Rbtn_st = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_ad)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(204)))), ((int)(((byte)(0)))));
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.Rbtn_st);
            this.panel1.Controls.Add(this.Rbtn_s);
            this.panel1.Controls.Add(this.Rbtn_t);
            this.panel1.Controls.Add(this.dgv_ad);
            this.panel1.Controls.Add(this.btn_at);
            this.panel1.Controls.Add(this.txt_ad);
            this.panel1.Location = new System.Drawing.Point(61, 42);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1627, 697);
            this.panel1.TabIndex = 11;
            // 
            // Rbtn_t
            // 
            this.Rbtn_t.AutoSize = true;
            this.Rbtn_t.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Rbtn_t.Location = new System.Drawing.Point(531, 25);
            this.Rbtn_t.Name = "Rbtn_t";
            this.Rbtn_t.Size = new System.Drawing.Size(114, 30);
            this.Rbtn_t.TabIndex = 12;
            this.Rbtn_t.TabStop = true;
            this.Rbtn_t.Text = "Teacher ";
            this.Rbtn_t.UseVisualStyleBackColor = true;
            // 
            // dgv_ad
            // 
            this.dgv_ad.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgv_ad.BackgroundColor = System.Drawing.Color.White;
            this.dgv_ad.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_ad.GridColor = System.Drawing.Color.White;
            this.dgv_ad.Location = new System.Drawing.Point(0, 88);
            this.dgv_ad.Name = "dgv_ad";
            this.dgv_ad.RowTemplate.Height = 24;
            this.dgv_ad.Size = new System.Drawing.Size(1627, 577);
            this.dgv_ad.TabIndex = 11;
            // 
            // btn_at
            // 
            this.btn_at.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(204)))), ((int)(((byte)(0)))));
            this.btn_at.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_at.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_at.Font = new System.Drawing.Font("Microsoft Tai Le", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_at.Location = new System.Drawing.Point(1386, 17);
            this.btn_at.Name = "btn_at";
            this.btn_at.Size = new System.Drawing.Size(107, 37);
            this.btn_at.TabIndex = 10;
            this.btn_at.Text = "View";
            this.btn_at.UseVisualStyleBackColor = false;
            this.btn_at.Click += new System.EventHandler(this.btn_at_Click);
            // 
            // txt_ad
            // 
            this.txt_ad.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_ad.Location = new System.Drawing.Point(1071, 19);
            this.txt_ad.Name = "txt_ad";
            this.txt_ad.Size = new System.Drawing.Size(296, 33);
            this.txt_ad.TabIndex = 9;
            // 
            // Rbtn_s
            // 
            this.Rbtn_s.AutoSize = true;
            this.Rbtn_s.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Rbtn_s.Location = new System.Drawing.Point(383, 24);
            this.Rbtn_s.Name = "Rbtn_s";
            this.Rbtn_s.Size = new System.Drawing.Size(113, 30);
            this.Rbtn_s.TabIndex = 13;
            this.Rbtn_s.TabStop = true;
            this.Rbtn_s.Text = "Student ";
            this.Rbtn_s.UseVisualStyleBackColor = true;
            // 
            // Rbtn_st
            // 
            this.Rbtn_st.AutoSize = true;
            this.Rbtn_st.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Rbtn_st.Location = new System.Drawing.Point(679, 24);
            this.Rbtn_st.Name = "Rbtn_st";
            this.Rbtn_st.Size = new System.Drawing.Size(79, 30);
            this.Rbtn_st.TabIndex = 14;
            this.Rbtn_st.TabStop = true;
            this.Rbtn_st.Text = "Staff";
            this.Rbtn_st.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(99, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(258, 26);
            this.label1.TabIndex = 15;
            this.label1.Text = "Selecte Attendance Type :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(1014, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 26);
            this.label2.TabIndex = 16;
            this.label2.Text = "No :";
            // 
            // Attendance
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(1748, 781);
            this.Controls.Add(this.panel1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Attendance";
            this.Text = "Attendance";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_ad)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton Rbtn_st;
        private System.Windows.Forms.RadioButton Rbtn_s;
        private System.Windows.Forms.RadioButton Rbtn_t;
        private System.Windows.Forms.DataGridView dgv_ad;
        private System.Windows.Forms.Button btn_at;
        private System.Windows.Forms.TextBox txt_ad;
    }
}