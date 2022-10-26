namespace Eduction_Institute_Mangment_Systerm
{
    partial class STA_View
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
            this.rbn_staff_no = new System.Windows.Forms.RadioButton();
            this.dgv_staff3 = new System.Windows.Forms.DataGridView();
            this.btn_staff_view = new System.Windows.Forms.Button();
            this.txt_staff_no = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_staff3)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(204)))), ((int)(((byte)(0)))));
            this.panel1.Controls.Add(this.rbn_staff_no);
            this.panel1.Controls.Add(this.dgv_staff3);
            this.panel1.Controls.Add(this.btn_staff_view);
            this.panel1.Controls.Add(this.txt_staff_no);
            this.panel1.Location = new System.Drawing.Point(60, 42);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1629, 679);
            this.panel1.TabIndex = 12;
            // 
            // rbn_staff_no
            // 
            this.rbn_staff_no.AutoSize = true;
            this.rbn_staff_no.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbn_staff_no.Location = new System.Drawing.Point(470, 26);
            this.rbn_staff_no.Name = "rbn_staff_no";
            this.rbn_staff_no.Size = new System.Drawing.Size(113, 30);
            this.rbn_staff_no.TabIndex = 13;
            this.rbn_staff_no.TabStop = true;
            this.rbn_staff_no.Text = "Staff No";
            this.rbn_staff_no.UseVisualStyleBackColor = true;
            // 
            // dgv_staff3
            // 
            this.dgv_staff3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dgv_staff3.BackgroundColor = System.Drawing.Color.White;
            this.dgv_staff3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_staff3.GridColor = System.Drawing.Color.White;
            this.dgv_staff3.Location = new System.Drawing.Point(0, 80);
            this.dgv_staff3.Name = "dgv_staff3";
            this.dgv_staff3.RowTemplate.Height = 24;
            this.dgv_staff3.Size = new System.Drawing.Size(1629, 571);
            this.dgv_staff3.TabIndex = 12;
            // 
            // btn_staff_view
            // 
            this.btn_staff_view.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(204)))), ((int)(((byte)(0)))));
            this.btn_staff_view.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_staff_view.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_staff_view.Font = new System.Drawing.Font("Microsoft Tai Le", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_staff_view.ForeColor = System.Drawing.Color.Black;
            this.btn_staff_view.Location = new System.Drawing.Point(1012, 26);
            this.btn_staff_view.Name = "btn_staff_view";
            this.btn_staff_view.Size = new System.Drawing.Size(103, 33);
            this.btn_staff_view.TabIndex = 10;
            this.btn_staff_view.Text = "View";
            this.btn_staff_view.UseVisualStyleBackColor = false;
            this.btn_staff_view.Click += new System.EventHandler(this.button1_Click);
            // 
            // txt_staff_no
            // 
            this.txt_staff_no.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_staff_no.Location = new System.Drawing.Point(589, 26);
            this.txt_staff_no.Name = "txt_staff_no";
            this.txt_staff_no.Size = new System.Drawing.Size(404, 33);
            this.txt_staff_no.TabIndex = 9;
            // 
            // STA_View
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1748, 781);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "STA_View";
            this.Text = "STA_View";
            this.Load += new System.EventHandler(this.STA_View_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_staff3)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btn_staff_view;
        private System.Windows.Forms.TextBox txt_staff_no;
        private System.Windows.Forms.DataGridView dgv_staff3;
        private System.Windows.Forms.RadioButton rbn_staff_no;
    }
}