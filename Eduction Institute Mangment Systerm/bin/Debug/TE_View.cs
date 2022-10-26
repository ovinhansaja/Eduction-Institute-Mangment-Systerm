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
    public partial class TE_View : Form
    {
        public TE_View()
        {
            InitializeComponent();
        }

        Database db = new Database();

        private void TE_View_Load(object sender, EventArgs e)
        {

        }

        private void btn_te_data_view_Click(object sender, EventArgs e)
        {
            try
            {
                if (rbn_teacher_no.Checked == true)
                {
                    dgv_teacher3.DataSource = db.getData("Select * from Teachers where Teacher_No = '" + txt_teacher_no.Text + "'");
                }
                if (txt_teacher_no.Text.Length == 0)
                {
                    dgv_teacher3.DataSource = db.getData("Select * from Teachers");
                }
            }
            catch (Exception)

            {
                MessageBox.Show(this, "Please check again", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
