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
    public partial class STA_View : Form
    {
        public STA_View()
        {
            InitializeComponent();
        }
        Database db = new Database();

        private void STA_View_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {

                if (rbn_staff_no.Checked == true)
                {
                    dgv_staff3.DataSource = db.getData("Select * from Staff where Staff_No = '" + txt_staff_no.Text + "'");
                }
                if (txt_staff_no.Text.Length == 0)
                {
                    dgv_staff3.DataSource = db.getData("Select * from Staff");
                }
            }
            catch (Exception)

            {
                MessageBox.Show(this, "Please check again", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
