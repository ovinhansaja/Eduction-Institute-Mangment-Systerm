namespace Eduction_Institute_Mangment_Systerm
{
    partial class TE_View
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
            this.rbn_teacher_no = new System.Windows.Forms.RadioButton();
            this.dgv_teacher3 = new System.Windows.Forms.DataGridView();
            this.btn_te_data_view = new System.Windows.Forms.Button();
            this.txt_teacher_no = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_teacher3)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(204)))), ((int)(((byte)(0)))));
            this.panel1.Controls.Add(this.rbn_teacher_no);
            this.panel1.Controls.Add(this.dgv_teacher3);
            this.panel1.Controls.Add(this.btn_te_data_view);
            this.panel1.Controls.Add(this.txt_teacher_no);
            this.panel1.Location = new System.Drawing.Point(65, 47);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1627, 656);
            this.panel1.TabIndex = 10;
            // 
            // rbn_teacher_no
            // 
            this.rbn_teacher_no.AutoSize = true;
            this.rbn_teacher_no.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbn_teacher_no.Location = new System.Drawing.Point(452, 28);
            this.rbn_teacher_no.Name = "rbn_teacher_no";
            this.rbn_teacher_no.Size = new System.Drawing.Size(142, 30);
            this.rbn_teacher_no.TabIndex = 12;
            this.rbn_teacher_no.TabStop = true;
            this.rbn_teacher_no.Text = "Teacher No";
            this.rbn_teacher_no.UseVisualStyleBackColor = true;
            // 
            // dgv_teacher3
            // 
            this.dgv_teacher3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgv_teacher3.BackgroundColor = System.Drawing.Color.White;
            this.dgv_teacher3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_teacher3.GridColor = System.Drawing.Color.White;
            this.dgv_teacher3.Location = new System.Drawing.Point(0, 81);
            this.dgv_teacher3.Name = "dgv_teacher3";
            this.dgv_teacher3.RowTemplate.Height = 24;
            this.dgv_teacher3.Size = new System.Drawing.Size(1627, 543);
            this.dgv_teacher3.TabIndex = 11;
            // 
            // btn_te_data_view
            // 
            this.btn_te_data_view.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(204)))), ((int)(((byte)(0)))));
            this.btn_te_data_view.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_te_data_view.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_te_data_view.Font = new System.Drawing.Font("Microsoft Tai Le", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_te_data_view.Location = new System.Drawing.Point(1035, 25);
            this.btn_te_data_view.Name = "btn_te_data_view";
            this.btn_te_data_view.Size = new System.Drawing.Size(107, 37);
            this.btn_te_data_view.TabIndex = 10;
            this.btn_te_data_view.Text = "View";
            this.btn_te_data_view.UseVisualStyleBackColor = false;
            this.btn_te_data_view.Click += new System.EventHandler(this.btn_te_data_view_Click);
            // 
            // txt_teacher_no
            // 
            this.txt_teacher_no.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_teacher_no.Location = new System.Drawing.Point(611, 28);
            this.txt_teacher_no.Name = "txt_teacher_no";
            this.txt_teacher_no.Size = new System.Drawing.Size(404, 33);
            this.txt_teacher_no.TabIndex = 9;
            // 
            // TE_View
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1748, 781);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "TE_View";
            this.Text = "TE_View";
            this.Load += new System.EventHandler(this.TE_View_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_teacher3)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btn_te_data_view;
        private System.Windows.Forms.TextBox txt_teacher_no;
        private System.Windows.Forms.DataGridView dgv_teacher3;
        private System.Windows.Forms.RadioButton rbn_teacher_no;
    }
}