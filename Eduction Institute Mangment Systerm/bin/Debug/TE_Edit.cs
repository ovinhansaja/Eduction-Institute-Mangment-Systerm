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
    public partial class TE_Edit : Form
    {
        public TE_Edit()
        {
            InitializeComponent();
        }
        Database db = new Database();
        string Gender;

        private void TE_Edit_Load(object sender, EventArgs e)
        {

        }

        private void btn_te_edit_Click(object sender, EventArgs e)
        {
            try
            {
                string teachers_details = "Update Teachers set  Teacher_Name= '" + txt_teacher_name.Text + "', Birthday = '" + dtp_te_brithday.Value + "', " +
                                          "NIC_No=  '" + txt_te_nic_no.Text + "', Gender= '" + Gender + "',Address= '" + txt_teacher_add.Text + "',Contact_No= '" + txt_teacher_c_no.Text + "'," +
                                          "Gmail= '" + txt_teacher_gmail.Text + "',Subject= '" + txt_sub_name.Text + "' where Teacher_No = '" + txt_teacher_no_ed.Text + "'";


                int i = db.save_update_delete(teachers_details);
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

        
        private void btn_te_show_Click(object sender, EventArgs e)
        {
            if (rbn_teacher_no.Checked == true)
            {
                dgv_teacher_up.DataSource = db.getData("Select * from Teachers where Teacher_No = '" + txt_teacher_no.Text + "'");
            }
            else if (txt_teacher_no.Text.Length == 0)
            {
                dgv_teacher_up.DataSource = db.getData("Select * from Teachers");
            }
        }

        private void dgv_teacher_up_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            if (dgv_teacher_up.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
            {
                txt_teacher_no_ed.Text = dgv_teacher_up.Rows[e.RowIndex].Cells[0].Value.ToString();
                txt_teacher_name.Text = dgv_teacher_up.Rows[e.RowIndex].Cells[1].Value.ToString();
                dtp_te_brithday.Value = DateTime.Parse(dgv_teacher_up.Rows[e.RowIndex].Cells[2].Value.ToString());
                txt_te_nic_no.Text = dgv_teacher_up.Rows[e.RowIndex].Cells[3].Value.ToString();
                
                if (dgv_teacher_up.Rows[e.RowIndex].Cells[4].Value.ToString() == "Male")
                {
                    rbtn_male.Checked = true;
                    rbtn_female.Checked = false;
                }
                else if (dgv_teacher_up.Rows[e.RowIndex].Cells[4].Value.ToString() == "Female")
                {
                    rbtn_female.Checked = true;
                    rbtn_male.Checked = false;
                }
                txt_teacher_add.Text = dgv_teacher_up.Rows[e.RowIndex].Cells[5].Value.ToString();
                txt_teacher_c_no.Text = dgv_teacher_up.Rows[e.RowIndex].Cells[6].Value.ToString();
                txt_teacher_gmail.Text = dgv_teacher_up.Rows[e.RowIndex].Cells[7].Value.ToString();
                txt_sub_name.Text = dgv_teacher_up.Rows[e.RowIndex].Cells[8].Value.ToString();


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
