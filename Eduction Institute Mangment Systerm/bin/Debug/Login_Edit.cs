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
    public partial class Login_Edit : Form
    {
        public Login_Edit()
        {
            InitializeComponent();
            con.ConnectionString = @"Data Source=LAPTOP-RR2SNHCT;Initial Catalog=Vision_Education_Institute;Integrated Security=True";
        }
        SqlConnection con = new SqlConnection();
        SqlCommand com = new SqlCommand();
        private void button2_Click(object sender, EventArgs e)
        {
            
                    con.Open();
                    com = new SqlCommand ("Update Loging set  User_Names = '" + txt_user_name_add.Text + "',Passwords= '" + txt_password_add.Text + "'Where Loging_ID =  '" + txt_login_id.Text + "'", con);
                    int i = com.ExecuteNonQuery();
                    
                       MessageBox.Show(this, "Data save Successfully", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    
                    con.Close();
                    com.Dispose();


                

        }

        private void button1_Click(object sender, EventArgs e)
        {
            txt_login_id.Clear();
            txt_user_name_add.Clear();
            txt_password_add.Clear();
        }
    }
}
