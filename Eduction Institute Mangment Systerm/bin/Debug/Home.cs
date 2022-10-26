using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Eduction_Institute_Mangment_Systerm
{
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
            con.ConnectionString= @"Data Source=LAPTOP-RR2SNHCT;Initial Catalog=Vision_Education_Institute;Integrated Security=True";
        }

        private void btn_form_close_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btn_form_max_Click(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Normal)
                this.WindowState = FormWindowState.Maximized;
            else
                this.WindowState = FormWindowState.Normal;
        }

        private void btn_form_mini_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
        SqlConnection con = new SqlConnection();
        SqlCommand com = new SqlCommand();

        private void btn_start_Click(object sender, EventArgs e)
        {
            con.Open();
            com.Connection = con;
            com.CommandText = "select * from Login";
            SqlDataReader dr = com.ExecuteReader();
            if(dr.Read())
            {
                if(txt_user_name.Text.Equals(dr["User_Names"].ToString())&& txt_password.Text.Equals(dr["Passwords"].ToString()))
                {
                    
                    Hide();
                    Menu obj = new Menu();
                    obj.Show();
                }
                else
                {
                    MessageBox.Show("Please Check Again", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            con.Close();
            
            
            
        }

        private void Home_Load(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if(checkBox1.Checked)
                {
                   txt_password.UseSystemPasswordChar = false;  
                }
            else
            {
                txt_password.UseSystemPasswordChar = true;
            }
        }
    }
}
