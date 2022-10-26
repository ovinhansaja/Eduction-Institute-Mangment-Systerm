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
    public partial class Finance : Form
    {
        public Finance()
        {
            InitializeComponent();
        }
        private void AbrirFormEnPanel(object Form)
        {
            if (this.finance_panel.Controls.Count > 0)
                this.finance_panel.Controls.RemoveAt(0);
            Form fh = Form as Form;
            fh.TopLevel = false;
            fh.Dock = DockStyle.Fill;
            this.finance_panel.Controls.Add(fh);
            this.finance_panel.Tag = fh;
            fh.Show();

        }
        private void btn_add_payment_Click(object sender, EventArgs e)
        {
            AbrirFormEnPanel(new Fin_Add_Payment());
        }

        private void btn_view_payment_Click(object sender, EventArgs e)
        {
            AbrirFormEnPanel(new Fin_View_Payment());
        }
    }
}
