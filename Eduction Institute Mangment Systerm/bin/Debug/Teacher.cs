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
    public partial class Teacher : Form
    {
        public Teacher()
        {
            InitializeComponent();
        }
        private void AbrirFormEnPanel(object Form)
        {
            if (this.teacher_panel.Controls.Count > 0)
                this.teacher_panel.Controls.RemoveAt(0);
            Form fh = Form as Form;
            fh.TopLevel = false;
            fh.Dock = DockStyle.Fill;
            this.teacher_panel.Controls.Add(fh);
            this.teacher_panel.Tag = fh;
            fh.Show();

        }
        private void btn_add_teacher_Click(object sender, EventArgs e)
        {
            AbrirFormEnPanel(new TE_Add());
        }

        private void btn_teacher_edit_Click(object sender, EventArgs e)
        {
            AbrirFormEnPanel(new TE_Edit());
        }

        private void btn_teacher_view_Click(object sender, EventArgs e)
        {
            AbrirFormEnPanel(new TE_View());
        }

        
    }
}
