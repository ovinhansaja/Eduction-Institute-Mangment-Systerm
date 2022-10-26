using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Eduction_Institute_Mangment_Systerm
{
    public partial class student : Form
    {
        public student()
        {
            InitializeComponent();
        }
        private void AbrirFormEnPanel(object Form)
        {
            if (this.student_panel.Controls.Count > 0)
                this.student_panel.Controls.RemoveAt(0);
            Form fh = Form as Form;
            fh.TopLevel = false;
            fh.Dock = DockStyle.Fill;
            this.student_panel.Controls.Add(fh);
            this.student_panel.Tag = fh;
            fh.Show();

        }
       


        private void student_Load(object sender, EventArgs e)
        {

        }

        private void btn_add_student_Click(object sender, EventArgs e)
        {
            AbrirFormEnPanel(new ST_Add());
        }

        private void btn_student_edit_Click(object sender, EventArgs e)
        {
            AbrirFormEnPanel(new ST_Update());
        }

        private void btn_student_view_Click(object sender, EventArgs e)
        {
            AbrirFormEnPanel(new ST_View());
        }

       
    }
}
