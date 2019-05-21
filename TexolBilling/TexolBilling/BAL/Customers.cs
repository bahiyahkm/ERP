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
        public int InsertCustomer( string cname, string caddress, string ccity, string cstate, string czipcode, string careacode, string cphoneno)
        {
            string sql = "insert into customers_tbl(CustomerName,CustomerAddress,CustomerCity,CustomerState,CustomerZipCode,CustomerAreaCode,CustomerPhoneNo) values( '" + cname + "','" + caddress + "','" + ccity + "','" + cstate + "','" + czipcode + "','" + careacode + "','" + cphoneno + "')";
            int i = db.InsertData(sql);
            return i;
        }
        public DataTable GetAllCustomers()
        {

            string sql = "select * from customers_tbl";
            return db.GetData(sql);

        }
        public DataTable GetCustomerByName(int CustomerId)
        {
            string sql = "select * from customers_tbl where CustomerId=" + CustomerId + "";
            return db.GetData(sql);
        }
    }
}
