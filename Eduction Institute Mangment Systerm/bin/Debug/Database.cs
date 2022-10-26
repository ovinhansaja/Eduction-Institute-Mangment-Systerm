using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;


namespace Eduction_Institute_Mangment_Systerm
{
    class Database
    {
        private SqlConnection con;
        private SqlCommand cmd;
        private SqlDataAdapter da;

        public Database() 
        {
            con = new SqlConnection("Data Source=LAPTOP-RR2SNHCT;Initial Catalog=Vision_Education_Institute;Integrated Security=True");
        }
        public void openConnection()
        {
            con.Open();
        }
        public void closeConnection()
        {
            con.Close();
        }
        public int save_update_delete(string a)
        {
            openConnection();
            cmd = new SqlCommand(a, con);
            int i = cmd.ExecuteNonQuery();
            
            closeConnection();
            return i;
            
        }
        public DataTable getData(string a)
        {
            openConnection();
            da = new SqlDataAdapter(a, con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            closeConnection();
            return dt;
        }

    }
}
