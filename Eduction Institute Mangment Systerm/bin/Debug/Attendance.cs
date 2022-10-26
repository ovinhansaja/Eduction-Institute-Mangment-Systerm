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
    public partial class Attendance : Form
    {
        public Attendance()
        {
            InitializeComponent();
        }

        Database db = new Database();

        private void btn_at_Click(object sender, EventArgs e)
        {
            if (Rbtn_s.Checked == true)
            {
                dgv_ad.DataSource = db.getData("Select * from Students_Attendence where Student_No = '" + txt_ad.Text + "'");

            }
            if (Rbtn_t.Checked == true)
            {
                dgv_ad.DataSource = db.getData("Select * from Teachers_Attendence where Teacher_No = '" + txt_ad.Text + "'");
            }
            if (Rbtn_st.Checked == true)
            {
                dgv_ad.DataSource = db.getData("Select * from Staff_Attendence where Staff_No = '" + txt_ad.Text + "'");
            }
        }
    }
}
