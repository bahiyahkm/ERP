using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;


namespace TexolBilling.DAL
{
    public class Connection
    {
        public string GetConnection()
        {
            return "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\QFTechnology\\Documents\\erp_db.mdf;Integrated Security=True;Connect Timeout=30";
        }
        public DataTable GetData(string sql)
        {
            SqlConnection con = new SqlConnection(GetConnection());
            SqlDataAdapter adp = new SqlDataAdapter(sql, con);
            DataTable dt = new DataTable();
            adp.Fill(dt);
            return dt;
        }
        public int InsertData(string sql)
        {

            SqlConnection con = new SqlConnection(GetConnection());
            SqlCommand cmd = new SqlCommand(sql, con);
            con.Open();
            int i = cmd.ExecuteNonQuery();
            con.Close();
            return i;
        }
        

    }
}
