namespace Eduction_Institute_Mangment_Systerm
{
    partial class ST_View
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
            this.dgv_student = new System.Windows.Forms.DataGridView();
            this.rbn_fees = new System.Windows.Forms.RadioButton();
            this.rbn_attendence = new System.Windows.Forms.RadioButton();
            this.rbn_detail = new System.Windows.Forms.RadioButton();
            this.btn_student_view = new System.Windows.Forms.Button();
            this.txt_student_no = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_student)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(204)))), ((int)(((byte)(0)))));
            this.panel1.Controls.Add(this.dgv_student);
            this.panel1.Controls.Add(this.rbn_fees);
            this.panel1.Controls.Add(this.rbn_attendence);
            this.panel1.Controls.Add(this.rbn_detail);
            this.panel1.Controls.Add(this.btn_student_view);
            this.panel1.Controls.Add(this.txt_student_no);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(68, 35);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1615, 693);
            this.panel1.TabIndex = 8;
            // 
            // dgv_student
            // 
            this.dgv_student.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgv_student.BackgroundColor = System.Drawing.Color.White;
            this.dgv_student.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_student.GridColor = System.Drawing.Color.White;
            this.dgv_student.Location = new System.Drawing.Point(0, 80);
            this.dgv_student.Name = "dgv_student";
            this.dgv_student.RowTemplate.Height = 24;
            this.dgv_student.Size = new System.Drawing.Size(1615, 543);
            this.dgv_student.TabIndex = 15;
            // 
            // rbn_fees
            // 
            this.rbn_fees.AutoSize = true;
            this.rbn_fees.Font = new System.Drawing.Font("Microsoft Tai Le", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbn_fees.ForeColor = System.Drawing.Color.Black;
            this.rbn_fees.Location = new System.Drawing.Point(799, 22);
            this.rbn_fees.Name = "rbn_fees";
            this.rbn_fees.Size = new System.Drawing.Size(69, 27);
            this.rbn_fees.TabIndex = 14;
            this.rbn_fees.TabStop = true;
            this.rbn_fees.Text = "Fees";
            this.rbn_fees.UseVisualStyleBackColor = true;
            // 
            // rbn_attendence
            // 
            this.rbn_attendence.AutoSize = true;
            this.rbn_attendence.Font = new System.Drawing.Font("Microsoft Tai Le", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbn_attendence.ForeColor = System.Drawing.Color.Black;
            this.rbn_attendence.Location = new System.Drawing.Point(671, 22);
            this.rbn_attendence.Name = "rbn_attendence";
            this.rbn_attendence.Size = new System.Drawing.Size(122, 27);
            this.rbn_attendence.TabIndex = 13;
            this.rbn_attendence.TabStop = true;
            this.rbn_attendence.Text = "Attendens";
            this.rbn_attendence.UseVisualStyleBackColor = true;
            // 
            // rbn_detail
            // 
            this.rbn_detail.AutoSize = true;
            this.rbn_detail.Font = new System.Drawing.Font("Microsoft Tai Le", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbn_detail.ForeColor = System.Drawing.Color.Black;
            this.rbn_detail.Location = new System.Drawing.Point(566, 22);
            this.rbn_detail.Name = "rbn_detail";
            this.rbn_detail.Size = new System.Drawing.Size(90, 27);
            this.rbn_detail.TabIndex = 11;
            this.rbn_detail.TabStop = true;
            this.rbn_detail.Text = "Details";
            this.rbn_detail.UseVisualStyleBackColor = true;
            // 
            // btn_student_view
            // 
            this.btn_student_view.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(204)))), ((int)(((byte)(0)))));
            this.btn_student_view.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_student_view.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_student_view.Font = new System.Drawing.Font("Microsoft Tai Le", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_student_view.Location = new System.Drawing.Point(884, 22);
            this.btn_student_view.Name = "btn_student_view";
            this.btn_student_view.Size = new System.Drawing.Size(117, 33);
            this.btn_student_view.TabIndex = 10;
            this.btn_student_view.Text = "View";
            this.btn_student_view.UseVisualStyleBackColor = false;
            this.btn_student_view.Click += new System.EventHandler(this.btn_student_view_Click);
            // 
            // txt_student_no
            // 
            this.txt_student_no.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_student_no.Location = new System.Drawing.Point(150, 19);
            this.txt_student_no.Name = "txt_student_no";
            this.txt_student_no.Size = new System.Drawing.Size(404, 33);
            this.txt_student_no.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(24, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(120, 26);
            this.label1.TabIndex = 8;
            this.label1.Text = "Student No";
            // 
            // ST_View
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1748, 781);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ST_View";
            this.Text = "ST_View";
            this.Load += new System.EventHandler(this.ST_View_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_student)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RadioButton rbn_fees;
        private System.Windows.Forms.RadioButton rbn_attendence;
        private System.Windows.Forms.RadioButton rbn_detail;
        private System.Windows.Forms.Button btn_student_view;
        private System.Windows.Forms.TextBox txt_student_no;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgv_student;
    }
}