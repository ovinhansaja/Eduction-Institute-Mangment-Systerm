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
    public partial class ST_Update : Form
    {
        public ST_Update()
        {
            InitializeComponent();
        }

        Database db = new Database();
        string Gender;
        string Grade;

        
        private void btn_update_2_Click(object sender, EventArgs e)
        {

            try
            {


                string student_details = "Update Students set  Student_Name= '" + txt_student_name.Text + "', Birthday = '" + dtp_brithday.Value + "', " +
                                         "NIC_No=  '" + txt_nic_number.Text + "', Gender= '" + Gender + "', Address= '" + txt_address.Text + "'," +
                                         " Contact_No='" + txt_c_no.Text + "',Gmail='" + txt_gmail.Text + "',Grade='" + Grade + "'," +
                                         "Subject_1= '" + txt_subject_01.Text + "',Subject_2= '" + txt_subject_02.Text + "'," +
                                         "Subject_3='" + txt_subject_03.Text + "' where Student_No = '" + txt_student_no.Text + "'";

                int i = db.save_update_delete(student_details);
                if (i == 1)
                    MessageBox.Show(this, "Data Update Successfully", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                else
                    MessageBox.Show(this, "Data Cannot Update", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception)
            {
                    MessageBox.Show(this, "Please check again", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void btn_show_Click(object sender, EventArgs e)
        {
            if (rbn_student_details.Checked == true)
            {
                dgv_student_up.DataSource = db.getData("Select * from Students where Student_No = '" + txt_student_no_update.Text + "'");
            }
            else if (txt_student_no_update.Text.Length == 0)
            {
                dgv_student_up.DataSource = db.getData("Select * from Students");
            }
            
        }
      

        private void dgv_student_up_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            if (dgv_student_up.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
            {
                txt_student_no.Text = dgv_student_up.Rows[e.RowIndex].Cells[0].Value.ToString();
                txt_student_name.Text = dgv_student_up.Rows[e.RowIndex].Cells[1].Value.ToString();
                dtp_brithday.Value = DateTime.Parse(dgv_student_up.Rows[e.RowIndex].Cells[2].Value.ToString());
                txt_nic_number.Text = dgv_student_up.Rows[e.RowIndex].Cells[3].Value.ToString();
                if (dgv_student_up.Rows[e.RowIndex].Cells[4].Value.ToString() == "Male")
                {
                    rbtn_male.Checked = true;
                    rbtn_female.Checked = false;
                }
                else if (dgv_student_up.Rows[e.RowIndex].Cells[4].Value.ToString() == "Female")
                {
                    rbtn_female.Checked = true;
                    rbtn_male.Checked = false;
                }
                txt_address.Text = dgv_student_up.Rows[e.RowIndex].Cells[5].Value.ToString();
                txt_c_no.Text = dgv_student_up.Rows[e.RowIndex].Cells[6].Value.ToString();
                txt_gmail.Text = dgv_student_up.Rows[e.RowIndex].Cells[7].Value.ToString();
                if (dgv_student_up.Rows[e.RowIndex].Cells[8].Value.ToString() == "Grade 12")
                {

                    ch_grade_12.Checked = true;
                    ch_grade_13.Checked = false;
                    
                }
                else if (dgv_student_up.Rows[e.RowIndex].Cells[8].Value.ToString() == "Grade 13")
                {

                    ch_grade_13.Checked = true;
                    ch_grade_12.Checked = false;
                }
                txt_subject_01.Text = dgv_student_up.Rows[e.RowIndex].Cells[9].Value.ToString();
                txt_subject_02.Text = dgv_student_up.Rows[e.RowIndex].Cells[10].Value.ToString();
                txt_subject_03.Text = dgv_student_up.Rows[e.RowIndex].Cells[11].Value.ToString();

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

      

        private void ch_grade_12_CheckedChanged_1(object sender, EventArgs e)
        {
            Grade = "Grade 12";
        }

        private void ch_grade_13_CheckedChanged_1(object sender, EventArgs e)
        {
            Grade = "Grade 13";
        }
    }
}
