using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TexolBilling.DAL;

namespace TexolBilling.BAL
{
    
  public  class Customers
    {
        Connection db = new Connection();
        public int InsertCustomer(int cnumber, string cname, string caddress, string ccity, string cstate, string czipcode, string careacode, string cphoneno)
        {
            string sql = "insert into customers_tbl(CustomerNumber,CustomerName,CustomerAddress,CustomerCity,CustomerState,CustomerZipCode,CustomerAreaCode,CustomerPhoneNo) values( " + cnumber + ",'" + cname + "','" + caddress + "','" + ccity + "','" + cstate + "','" + czipcode + "','" + careacode + "','" + cphoneno + "')";
            int i = db.InsertData(sql);
            return i;
        }
        public DataTable GetAllCustomers()
        {

            string sql = "select * from customers_tbl";
            return db.GetData(sql);

        }
    }
}
