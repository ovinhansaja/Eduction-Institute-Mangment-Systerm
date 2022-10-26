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
    public partial class ST_Add : Form
    {
        public ST_Add()
        {
            InitializeComponent();
        }

        Database db = new Database();
       
        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void ST_Add_Load(object sender, EventArgs e)
        {

        }

        private void cmb_stream_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        string Gender;
        string Grade;

        private void btn_save_1_Click(object sender, EventArgs e)
        {
              if (txt_student_no.Text == "")
                {
                
                errorProvider1.SetError(txt_student_no,"Student Number is empty!");
                    
                }
              else 
                {
                errorProvider1.SetError(txt_student_no, null);
                if (txt_student_name.Text == "")
                {
                    errorProvider2.SetError(txt_student_name, "Student Name cannot be Empty!");
                }
                else
                {
                    errorProvider2.SetError(txt_student_name, null);

                    if (dtp_brithday.Value.ToShortDateString() == DateTime.Now.ToShortDateString())
                    {
                        errorProvider3.SetError(dtp_brithday, "Select your birthday!");
                    }
                    else
                    {
                        errorProvider3.SetError(dtp_brithday, null);
                        if (string.IsNullOrEmpty(txt_nic_number.Text))
                        {
                            errorProvider4.SetError(txt_nic_number, "Student ID number is empty!");
                        }

                        else
                        {
                            errorProvider4.SetError(txt_nic_number, null);
                            if (!(this.rbtn_male.Checked || this.rbtn_female.Checked))

                            {


                                errorProvider5.SetError(rbtn_female, "Select Gender");

                            }

                            else
                            {
                                errorProvider5.SetError(rbtn_male, null);
                                errorProvider5.SetError(rbtn_female, null);
                                if (txt_address.Text == "")
                                {

                                    errorProvider6.SetError(txt_address, "Student address is empty!");

                                }
                                else
                                {
                                    errorProvider6.SetError(txt_address, null);
                                    if (txt_c_no.Text == "") //limitted 10 characters(else if)
                                    {
                                        errorProvider7.SetError(txt_c_no, "Student phone number is empty!");
                                    }

                                    else
                                    {
                                        errorProvider7.SetError(txt_c_no, null);
                                        if (txt_gmail.Text == "")
                                        {
                                            errorProvider8.SetError(txt_gmail, "Student gmail is empty!");
                                        }

                                        else if (!Regex.IsMatch(txt_gmail.Text, @"^[a-zA-Z][\w\.-]*[a-zA-Z0-9]@[a-zA-Z0-9][\w\.-]*[a-zA-Z0-9]\.[a-zA-Z][a-zA-Z\.]*[a-zA-Z]$"))
                                        {
                                            errorProvider8.SetError(txt_gmail, "Enter a valid email. Ex:name@gmail.com !");
                                            txt_gmail.Focus();
                                        }
                                        else
                                        {
                                            errorProvider8.SetError(txt_gmail, null);
                                            if (!(this.ch_grade_12.Checked || this.ch_grade_13.Checked))

                                            {


                                                errorProvider5.SetError(ch_grade_13, "Select Grade !");

                                            }

                                            else
                                            {
                                                errorProvider5.SetError(ch_grade_12, null);
                                                errorProvider5.SetError(ch_grade_13, null);
                                                if (string.IsNullOrEmpty(txt_subject_01.Text))
                                                {
                                                    errorProvider10.SetError(txt_subject_01, "Subject can not be is empty!");
                                                }

                                                else
                                                {
                                                    errorProvider10.SetError(txt_subject_01, null);

                                                    string query = "Insert  into Students values ('" + txt_student_no.Text + "', '" + txt_student_name.Text + "', '" + dtp_brithday.Value + "',  '" + txt_nic_number.Text + "', '" + Gender + "', " +
                                                     "'" + txt_address.Text + "', '" + txt_c_no.Text + "', '" + txt_gmail.Text + "', '" + Grade + "','" + txt_subject_01.Text + "','" + txt_subject_02.Text + "','" + txt_subject_02.Text + "') ";

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

        private void rbtn_male_CheckedChanged(object sender, EventArgs e)
        {
            Gender = "Male";
        }

        private void rbtn_female_CheckedChanged(object sender, EventArgs e)
        {
            Gender = "Female";
        }

        private void ch_grade_12_CheckedChanged(object sender, EventArgs e)
        {
            Grade = "Grade 12";
        }

        private void ch_grade_13_CheckedChanged(object sender, EventArgs e)
        {
            Grade = "Grade 13";
        }

        private void btn_clear_1_Click(object sender, EventArgs e)
        {
            txt_student_no.Clear();
            txt_student_name.Clear();
            dtp_brithday.ResetText();
            txt_nic_number.Clear();
            if (rbtn_male.Checked)
            {
                rbtn_male.Checked = false;
            }
            else if (rbtn_female.Checked)
            {
                rbtn_female.Checked = false;
            }
            txt_address.Clear();
            txt_c_no.Clear();
            txt_gmail.Clear();
            ch_grade_12.Checked = false;
            ch_grade_13.Checked = false;
            txt_subject_01.Clear();
            txt_subject_02.Clear();
            txt_subject_03.Clear();
        }

        private void txt_c_no_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);

            {
                if (e.KeyChar == 22)
                    e.Handled = true;

            }
        }

        private void txt_student_name_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void errorProvider2_RightToLeftChanged(object sender, EventArgs e)
        {

        }

        private void txt_student_name_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            e.Handled = !(char.IsLetter(e.KeyChar) || e.KeyChar == (char)Keys.Back);
        }

        private void txt_subject_01_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_subject_01_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !(char.IsLetter(e.KeyChar) || e.KeyChar == (char)Keys.Back);
        }

        private void txt_subject_02_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !(char.IsLetter(e.KeyChar) || e.KeyChar == (char)Keys.Back);
        }

        private void txt_subject_03_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !(char.IsLetter(e.KeyChar) || e.KeyChar == (char)Keys.Back);
        }
    }
}
