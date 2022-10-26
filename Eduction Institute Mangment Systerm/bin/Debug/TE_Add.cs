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
    public partial class TE_Add : Form
    {
        public TE_Add()
        {
            InitializeComponent();
        }

        Database db = new Database();

        private void TE_Add_Load(object sender, EventArgs e)
        {

        }

        string Gender;

        private void btn_save_1_Click(object sender, EventArgs e)
        {
            if (txt_teacher_no.Text == "")
            {

                errorProvider1.SetError(txt_teacher_no, "Teacher Number is empty!");

            }
            else
            {
                errorProvider1.SetError(txt_teacher_no, null);
                if (txt_teacher_name.Text == "")
                {
                    errorProvider2.SetError(txt_teacher_name, "Teacher Name cannot be Empty!");
                }
                else
                {
                    errorProvider2.SetError(txt_teacher_name, null);

                    if (dtp_tbrithday.Value.ToShortDateString() == DateTime.Now.ToShortDateString())
                    {
                        errorProvider3.SetError(dtp_tbrithday, "Select your birthday!");
                    }
                    else
                    {
                        errorProvider3.SetError(dtp_tbrithday, null);
                        if (txt_tnic_number.Text == "")
                        {
                            errorProvider4.SetError(txt_tnic_number, "Teacher Name cannot be Empty!");
                        }
                        else
                        {
                            errorProvider4.SetError(txt_tnic_number, null);
                            if (!(this.rbtn_male.Checked || this.rbtn_female.Checked))

                            {


                                errorProvider5.SetError(rbtn_female, "Select Gender !");

                            }

                            else
                            {
                                errorProvider5.SetError(rbtn_male, null);
                                errorProvider5.SetError(rbtn_female, null);
                                if (txt_teacher_address.Text == "")
                                {
                                    errorProvider6.SetError(txt_teacher_address, "Teacher address cannot be Empty!");
                                }
                                else
                                {
                                    errorProvider6.SetError(txt_teacher_address, null);
                                    if (txt_teacher_address.Text == "")
                                    {
                                        errorProvider6.SetError(txt_teacher_address, "Teacher address cannot be Empty!");
                                    }
                                    else
                                    {
                                        errorProvider6.SetError(txt_teacher_address, null);
                                        if (txt_teacher_c_no.Text == "")
                                        {
                                            errorProvider7.SetError(txt_teacher_c_no, "Teacher phone number cannot be Empty!");
                                        }
                                        else if (!Regex.IsMatch(txt_teacher_c_no.Text, @"^(?:7|0|(?:\+94))[0-9]{8,9}$"))
                                        {
                                            errorProvider7.SetError(txt_teacher_c_no, "Telephone number must have 10 numbers!");
                                            txt_teacher_c_no.Focus();
                                        }

                                        else
                                        {
                                            errorProvider7.SetError(txt_teacher_c_no, null);
                                            if (txt_teacher_gmail.Text == "")
                                            {
                                                errorProvider8.SetError(txt_teacher_gmail, "Teacher gmail is empty!");
                                            }

                                            else if (!Regex.IsMatch(txt_teacher_gmail.Text, @"^[a-zA-Z][\w\.-]*[a-zA-Z0-9]@[a-zA-Z0-9][\w\.-]*[a-zA-Z0-9]\.[a-zA-Z][a-zA-Z\.]*[a-zA-Z]$"))
                                            {
                                                errorProvider8.SetError(txt_teacher_gmail, "Enter a valid email. Ex:name@gmail.com !");
                                                txt_teacher_gmail.Focus();
                                            }
                                            else
                                            {
                                                errorProvider8.SetError(txt_teacher_gmail, null);
                                                if (txt_sub_name.Text == "")
                                                {
                                                    errorProvider6.SetError(txt_sub_name, "Subject can not be is empty!");
                                                }
                                                else
                                                {
                                                    errorProvider6.SetError(txt_sub_name, null);


                                                    string query = "Insert  into Teachers values ('" + txt_teacher_no.Text + "', '" + txt_teacher_name.Text + "', '" + dtp_tbrithday.Value + "',  '" + txt_tnic_number.Text + "', '" + Gender + "', " +
                                                        "'" + txt_teacher_address.Text + "', '" + txt_teacher_c_no.Text + "', '" + txt_teacher_gmail.Text + "', '" + txt_sub_name.Text + "') ";

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
            }

            
            
            
           
            
            
            
           
        }

        private void rbtn_male_CheckedChanged_1(object sender, EventArgs e)
        {
            Gender = "Male";
        }

        private void rbtn_female_CheckedChanged(object sender, EventArgs e)
        {
            Gender = "Female";
        }

        private void btn_clear_1_Click(object sender, EventArgs e)
        {
            txt_teacher_no.Clear();
            txt_teacher_name.Clear();
            dtp_tbrithday.ResetText();
            txt_tnic_number.Clear();
            txt_teacher_address.Clear();
            if (rbtn_male.Checked)
            {
                rbtn_male.Checked = false;
            }
            else if (rbtn_female.Checked)
            {
                rbtn_female.Checked = false;
            }
            txt_teacher_c_no.Clear();
            txt_teacher_gmail.Clear();
            txt_sub_name.Clear();

        }

        private void txt_teacher_c_no_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);

            {
                if (e.KeyChar == 22)
                    e.Handled = true;

            }
        }

        private void txt_teacher_name_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !(char.IsLetter(e.KeyChar) || e.KeyChar == (char)Keys.Back);
        }

        private void txt_sub_name_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !(char.IsLetter(e.KeyChar) || e.KeyChar == (char)Keys.Back);
        }
    }
    
}
