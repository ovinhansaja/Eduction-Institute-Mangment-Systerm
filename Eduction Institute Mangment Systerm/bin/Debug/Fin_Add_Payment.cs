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
    public partial class Fin_Add_Payment : Form
    {
        public Fin_Add_Payment()
        {
            InitializeComponent();
        }

        Database db = new Database();

        private void Fin_Add_Payment_Load(object sender, EventArgs e)
        {

        }

        private void btn_fees_clear_Click(object sender, EventArgs e)
        {
            txt_r_no.Clear();
            txt_s_no.Clear();
            dtp_class_fee.ResetText();
            txt_cl_descripion.Clear();
            txt_cl_amount.Clear();

        }

        private void btn_salary_clear_Click(object sender, EventArgs e)
        {
            txt_ch.Clear();
            txt_des_pa.Clear();
            dtp_payment.ResetText();
            txt_amount.Clear();
        }

        private void btn_fees_save_Click(object sender, EventArgs e)
        {
            if (txt_r_no.Text == "")
            {

                errorProvider1.SetError(txt_r_no, "Recipt number is empty !");

            }
            else
            {
                errorProvider1.SetError(txt_r_no, null);

                if (txt_s_no.Text == "")
                {
                    errorProvider2.SetError(txt_s_no, "Student number cannot be Empty !");
                }
                else
                {
                    errorProvider2.SetError(txt_s_no, null);
                    if (txt_cl_descripion.Text == "")
                    {
                        errorProvider10.SetError(txt_s_no, "Description cannot be Empty !");
                    }
                    else
                    {
                        errorProvider10.SetError(txt_cl_descripion, null);
                        if (txt_cl_descripion.Text == "")
                        {
                            errorProvider10.SetError(txt_s_no, "Description cannot be Empty !");
                        }
                        else
                        {
                            errorProvider10.SetError(txt_cl_descripion, null);
                            if (txt_cl_descripion.Text == "")
                            {
                                errorProvider10.SetError(txt_s_no, "Description cannot be Empty !");
                            }
                            else
                            {
                                errorProvider10.SetError(txt_cl_descripion, null);

                                if (txt_cl_amount.Text == "")
                                {
                                    errorProvider5.SetError(txt_cl_amount, "Amount cannot be Empty !");
                                }
                                else
                                {
                                    errorProvider5.SetError(txt_cl_amount, null);






                                    string Fees = "Insert  into Class_Fees  values ('" + txt_r_no.Text + "','" + txt_s_no.Text + "','" + dtp_class_fee.Value + "','" + txt_cl_descripion.Text + "','" + txt_cl_amount.Text + "')";

                                    int i = db.save_update_delete(Fees);
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

        private void btn_salary_save_Click(object sender, EventArgs e)
        {
            if (txt_ch.Text == "")
            {
                errorProvider6.SetError(txt_ch, "Cheque number cannot be Empty !");
            }
            else
            {
                errorProvider6.SetError(txt_ch, null);
                if (txt_des_pa.Text == "")
                {
                    errorProvider7.SetError(txt_des_pa, "Cheque number cannot be Empty !");
                }

                else
                {
                    errorProvider7.SetError(txt_des_pa, null);

                    if (txt_amount.Text == "")
                    {
                        errorProvider9.SetError(txt_amount, "Cheque number cannot be Empty !");
                    }

                    else
                    {
                        errorProvider9.SetError(txt_amount, null);

                        string Payment = "Insert  into Payment  values ('" + txt_ch.Text + "','" + txt_des_pa.Text + "','" + dtp_payment.Value + "','" + txt_amount.Text + "')";

                        int i = db.save_update_delete(Payment);
                        if (i == 1)
                            MessageBox.Show(this, "Data Update Successfully", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        else
                            MessageBox.Show(this, "Data Cannot Update", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    }

                }
            }
            
           
        }

        private void txt_cl_amount_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);

            {
                if (e.KeyChar == 22)
                    e.Handled = true;

            }
        }

        private void txt_amount_TextChanged(object sender, EventArgs e)
        {
        }

        private void txt_amount_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);

            {
                if (e.KeyChar == 22)
                    e.Handled = true;

            }
        }
    }
}
