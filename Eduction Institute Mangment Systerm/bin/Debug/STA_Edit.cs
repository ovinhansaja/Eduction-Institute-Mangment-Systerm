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
    public partial class STA_Edit : Form
    {
        public STA_Edit()
        {
            InitializeComponent();
        }

        Database db = new Database();
        string Gender;

        private void STA_Edit_Load(object sender, EventArgs e)
        {

        }

        private void btn_save_1_Click(object sender, EventArgs e)
        {
            try
            {
                string staff_details = "Update Staff set  Staff_Name = '" + txt_staff_name.Text + "', Birthday = '" + dtp_brithday.Value + "', " +
                                       "NIC_No= '" + txt_sta_nic_no.Text + "', Gender = '" + Gender + "', Address= '" + txt_staff_add.Text + "'," +
                                       " Contact_No='" + txt_staff_cno.Text + "',Position='" + txt_staff_position.Text + "'  where Staff_No = '" + txt_staff_no.Text + "'";

                int i = db.save_update_delete(staff_details);
                if (i == 1)
                    MessageBox.Show(this, "Data Edit Successfully", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                else
                    MessageBox.Show(this, "Data Cannot Edit", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception)
            {
                MessageBox.Show(this, "Please check again", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        

       
        
        private void btn_show_sta_Click(object sender, EventArgs e)
        {
            if (rbn_sta_no.Checked == true)
            {
                dgv_staff_up.DataSource = db.getData("Select * from Staff where Staff_No = '" + txt_sta_no.Text + "'");
            }
            if (txt_sta_no.Text.Length == 0)
            {
                dgv_staff_up.DataSource = db.getData("Select * from Staff");
            }
        }

        private void dgv_staff_up_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            if (dgv_staff_up.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
            {
                txt_staff_no.Text = dgv_staff_up.Rows[e.RowIndex].Cells[0].Value.ToString();
                txt_staff_name.Text = dgv_staff_up.Rows[e.RowIndex].Cells[1].Value.ToString();
                dtp_brithday.Value = DateTime.Parse(dgv_staff_up.Rows[e.RowIndex].Cells[2].Value.ToString());
                txt_sta_nic_no.Text = dgv_staff_up.Rows[e.RowIndex].Cells[3].Value.ToString();
                if (dgv_staff_up.Rows[e.RowIndex].Cells[4].Value.ToString() == "Male")
                {
                    rbtn_male.Checked = true;
                    rbtn_female.Checked = false;
                }
                else if (dgv_staff_up.Rows[e.RowIndex].Cells[4].Value.ToString() == "Female")
                {
                    rbtn_female.Checked = true;
                    rbtn_male.Checked = false;
                }
                txt_staff_add.Text = dgv_staff_up.Rows[e.RowIndex].Cells[5].Value.ToString();
                txt_staff_cno.Text = dgv_staff_up.Rows[e.RowIndex].Cells[6].Value.ToString();
                txt_staff_position.Text = dgv_staff_up.Rows[e.RowIndex].Cells[7].Value.ToString();

            }
        }

        private void rbtn_male_CheckedChanged_1(object sender, EventArgs e)
        {
            Gender = "Male";
        }

        private void rbtn_female_CheckedChanged_1(object sender, EventArgs e)
        {
            Gender = "Female";
        }
    }
}
