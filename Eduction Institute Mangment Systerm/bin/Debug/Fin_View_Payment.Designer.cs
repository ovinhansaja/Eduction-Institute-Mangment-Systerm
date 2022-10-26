namespace Eduction_Institute_Mangment_Systerm
{
    partial class Fin_View_Payment
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
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Rbtn_fees = new System.Windows.Forms.RadioButton();
            this.Rbtn_salary = new System.Windows.Forms.RadioButton();
            this.dgv_fin = new System.Windows.Forms.DataGridView();
            this.btn_fin_view = new System.Windows.Forms.Button();
            this.txt_fin_no = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_fin)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(204)))), ((int)(((byte)(0)))));
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.Rbtn_fees);
            this.panel1.Controls.Add(this.Rbtn_salary);
            this.panel1.Controls.Add(this.dgv_fin);
            this.panel1.Controls.Add(this.btn_fin_view);
            this.panel1.Controls.Add(this.txt_fin_no);
            this.panel1.Location = new System.Drawing.Point(61, 42);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1627, 697);
            this.panel1.TabIndex = 12;
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(99, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(221, 26);
            this.label1.TabIndex = 15;
            this.label1.Text = "Selecte Finance Type :";
            // 
            // Rbtn_fees
            // 
            this.Rbtn_fees.AutoSize = true;
            this.Rbtn_fees.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Rbtn_fees.Location = new System.Drawing.Point(383, 24);
            this.Rbtn_fees.Name = "Rbtn_fees";
            this.Rbtn_fees.Size = new System.Drawing.Size(127, 30);
            this.Rbtn_fees.TabIndex = 13;
            this.Rbtn_fees.TabStop = true;
            this.Rbtn_fees.Text = "Class Fees";
            this.Rbtn_fees.UseVisualStyleBackColor = true;
            // 
            // Rbtn_salary
            // 
            this.Rbtn_salary.AutoSize = true;
            this.Rbtn_salary.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Rbtn_salary.Location = new System.Drawing.Point(531, 25);
            this.Rbtn_salary.Name = "Rbtn_salary";
            this.Rbtn_salary.Size = new System.Drawing.Size(91, 30);
            this.Rbtn_salary.TabIndex = 12;
            this.Rbtn_salary.TabStop = true;
            this.Rbtn_salary.Text = "Salary";
            this.Rbtn_salary.UseVisualStyleBackColor = true;
            // 
            // dgv_fin
            // 
            this.dgv_fin.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgv_fin.BackgroundColor = System.Drawing.Color.White;
            this.dgv_fin.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_fin.GridColor = System.Drawing.Color.White;
            this.dgv_fin.Location = new System.Drawing.Point(0, 88);
            this.dgv_fin.Name = "dgv_fin";
            this.dgv_fin.RowTemplate.Height = 24;
            this.dgv_fin.Size = new System.Drawing.Size(1627, 577);
            this.dgv_fin.TabIndex = 11;
            // 
            // btn_fin_view
            // 
            this.btn_fin_view.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(204)))), ((int)(((byte)(0)))));
            this.btn_fin_view.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_fin_view.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_fin_view.Font = new System.Drawing.Font("Microsoft Tai Le", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_fin_view.Location = new System.Drawing.Point(1386, 17);
            this.btn_fin_view.Name = "btn_fin_view";
            this.btn_fin_view.Size = new System.Drawing.Size(107, 37);
            this.btn_fin_view.TabIndex = 10;
            this.btn_fin_view.Text = "View";
            this.btn_fin_view.UseVisualStyleBackColor = false;
            this.btn_fin_view.Click += new System.EventHandler(this.btn_fin_view_Click);
            // 
            // txt_fin_no
            // 
            this.txt_fin_no.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_fin_no.Location = new System.Drawing.Point(1071, 19);
            this.txt_fin_no.Name = "txt_fin_no";
            this.txt_fin_no.Size = new System.Drawing.Size(296, 33);
            this.txt_fin_no.TabIndex = 9;
            // 
            // Fin_View_Payment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1748, 781);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Fin_View_Payment";
            this.Text = "Fin_View_Payment";
            this.Load += new System.EventHandler(this.Fin_View_Payment_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_fin)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton Rbtn_fees;
        private System.Windows.Forms.RadioButton Rbtn_salary;
        private System.Windows.Forms.DataGridView dgv_fin;
        private System.Windows.Forms.Button btn_fin_view;
        private System.Windows.Forms.TextBox txt_fin_no;
    }
}