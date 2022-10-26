using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;


namespace Eduction_Institute_Mangment_Systerm
{
    public partial class STA_Add : Form
    {
        public STA_Add()
        {
            InitializeComponent();
        }
        Database db = new Database();

        private void STA_Add_Load(object sender, EventArgs e)
        {

        }
        string Gender;

        private void btn_save_1_Click(object sender, EventArgs e)
        {

            if (txt_staff_no.Text == "")
            {

                errorProvider1.SetError(txt_staff_no, "Staff Number is empty !");

            }
            else
            {
                errorProvider1.SetError(txt_staff_no, null);
                if (txt_staff_name.Text == "")
                {
                    errorProvider2.SetError(txt_staff_name, "Staff Name cannot be Empty !");
                }
                else
                {
                    errorProvider2.SetError(txt_staff_name, null);
                    if (dtp_sbrithday.Value.ToShortDateString() == DateTime.Now.ToShortDateString())
                    {
                        errorProvider3.SetError(dtp_sbrithday, "Select your birthday !");
                    }
                    else
                    {
                        errorProvider3.SetError(dtp_sbrithday, null);

                        if (string.IsNullOrEmpty(txt_snic_number.Text))
                        {
                            errorProvider4.SetError(txt_snic_number, "Staff ID number is empty !");
                        }

                        else
                        {
                            errorProvider4.SetError(txt_snic_number, null);
                            if (!(this.rbtn_male.Checked || this.rbtn_female.Checked))

                            {


                                errorProvider5.SetError(rbtn_female, "Select Gender !");


                            }
                            else
                            {
                                errorProvider5.SetError(rbtn_male, null);
                                errorProvider5.SetError(rbtn_female, null);

                                if (string.IsNullOrEmpty(txt_staff_address.Text))
                                {
                                    errorProvider6.SetError(txt_staff_address, "Staff address is empty !");
                                }

                                else
                                {
                                    errorProvider6.SetError(txt_staff_address, null);
                                    if (string.IsNullOrEmpty(txt_staff_cno.Text))
                                    {
                                        errorProvider7.SetError(txt_staff_cno, "Staff contact is empty !");
                                    }
                                    else if (!Regex.IsMatch(txt_staff_cno.Text, @"^(?:7|0|(?:\+94))[0-9]{8,9}$"))
                                    {
                                        errorProvider7.SetError(txt_staff_cno, "Telephone number must have 10 numbers !");
                                        txt_staff_cno.Focus();

                                    }
                                    else
                                    {
                                        errorProvider7.SetError(txt_staff_cno, null);
                                        if (string.IsNullOrEmpty(txt_staff_position.Text))
                                        {
                                            errorProvider8.SetError(txt_staff_position, "Staff position is empty !");
                                        }

                                        else
                                        {
                                            errorProvider8.SetError(txt_staff_position, null);




                                            string query = "Insert  into Staff  values ('" + txt_staff_no.Text + "', '" + txt_staff_name.Text + "', '" + dtp_sbrithday.Value + "',  '" + txt_snic_number.Text + "', '" + Gender + "', " +
                                              "'" + txt_staff_address.Text + "', '" + txt_staff_cno.Text + "', '" + txt_staff_position.Text + "') ";

                                            int i = db.save_update_delete(query);


                                            if (i == 1)
                                                MessageBox.Show(this, "Data save Successfully", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                            else
                                                MessageBox.Show(this, "Data Cannot Save", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);


                                        }
                                    }
                                }
                            }
                        }
                    }

                }
            }

           
           
           

            

            
            

        }

        private void rbtn_male_CheckedChanged(object sender, EventArgs e)
        {
            Gender = "Male";
        }

        private void rbtn_female_CheckedChanged(object sender, EventArgs e)
        {
            Gender = "Female";
        }

        private void btn_clear_1_Click(object sender, EventArgs e)
        {
            txt_staff_no.Clear();
            txt_staff_name.Clear();
            dtp_sbrithday.ResetText();
            txt_snic_number.Clear();
            if (rbtn_male.Checked)
            {
                rbtn_male.Checked = false;
            }
           else if (rbtn_female.Checked)
            {
                rbtn_female.Checked = false;
            }    
            txt_staff_address.Clear();
            txt_staff_cno.Clear();
            txt_staff_position.Clear();
        }

        private void txt_staff_cno_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);

            {
                if (e.KeyChar == 22)
                    e.Handled = true;

            }
        }

        private void txt_staff_name_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !(char.IsLetter(e.KeyChar) || e.KeyChar == (char)Keys.Back);
        }

        private void txt_staff_position_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !(char.IsLetter(e.KeyChar) || e.KeyChar == (char)Keys.Back);
        }
    }
}
