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
    public partial class ST_View : Form
    {
        public ST_View()
        {
            InitializeComponent();
        }

        Database db = new Database();

        private void ST_View_Load(object sender, EventArgs e)
        {

        }

        private void btn_student_view_Click(object sender, EventArgs e)
        {
            try
            {
                if (txt_student_no.Text.Length == 0)
                {
                    dgv_student.DataSource = db.getData("Select * from Students");

                }
                if (rbn_detail.Checked == true)
                {
                    dgv_student.DataSource = db.getData("Select * from Students where Student_No = '" + txt_student_no.Text + "'");

                }
                if (rbn_attendence.Checked == true)
                {
                    dgv_student.DataSource = db.getData("Select  * from Student_Attendance where Student_No = '" + txt_student_no.Text + "'");
                }
                if (rbn_fees.Checked == true)
                {
                    dgv_student.DataSource = db.getData("Select * from Class_Fees where Student_No = '" + txt_student_no.Text + "'");
                }
            }
            catch (Exception)

            {
                MessageBox.Show(this, "Please check again", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
