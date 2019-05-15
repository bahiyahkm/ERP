using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using TexolBilling.DAL;


namespace TexolBilling.BAL
{
    
    public class Account
    {
        Connection db = new Connection();
        public DataTable Login(string username,string password)
        {
            string sql = "select * from login_tbl where username='" + username + "' and password='" + password + "'";
            DataTable dt = db.GetData(sql);
            return dt;

        }
        
       
       
    }
}
