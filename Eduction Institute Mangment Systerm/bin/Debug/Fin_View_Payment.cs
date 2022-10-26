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
    public partial class Fin_View_Payment : Form
    {
        public Fin_View_Payment()
        {
            InitializeComponent();
        }

        Database db = new Database(); 

        private void Fin_View_Payment_Load(object sender, EventArgs e)
        {

        }

       

        private void btn_fin_view_Click(object sender, EventArgs e)
        {
            try
            {
                if (Rbtn_fees.Checked == true)
                {
                    dgv_fin.DataSource = db.getData("Select * from Class_Fees where Student_No = '" + txt_fin_no.Text + "'");

                }
                if (Rbtn_salary.Checked == true)
                {
                    dgv_fin.DataSource = db.getData("Select * from Payment");
                }
            }
            catch (Exception)

            {
                MessageBox.Show(this, "Please check again", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
