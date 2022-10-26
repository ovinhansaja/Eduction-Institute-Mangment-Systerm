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
    public partial class Staff : Form
    {
        public Staff()
        {
            InitializeComponent();
        }
        private void AbrirFormEnPanel(object Form)
        {
            if (this.staff_panel.Controls.Count > 0)
                this.staff_panel.Controls.RemoveAt(0);
            Form fh = Form as Form;
            fh.TopLevel = false;
            fh.Dock = DockStyle.Fill;
            this.staff_panel.Controls.Add(fh);
            this.staff_panel.Tag = fh;
            fh.Show();

        }
        
        private void btn_add_staff_Click(object sender, EventArgs e)
        {
            AbrirFormEnPanel(new STA_Add());
        }

        private void btn_staff_edit_Click(object sender, EventArgs e)
        {
            AbrirFormEnPanel(new STA_Edit());
        }

        private void btn_staff_view_Click(object sender, EventArgs e)
        {
            AbrirFormEnPanel(new STA_View());
        }
    }
}
