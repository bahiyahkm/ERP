using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using TexolBilling.DAL;

namespace TexolBilling.BAL
{
   public class AddCustomer
    {
        Connection db = new Connection();
        public int Customer(int cnumber, string clastname, string cfirstname, string caddress, string ccity, string cstate, string czipcode, string careacode, string cphoneno)
        {
            string sql = "insert into customers_tbl(CustomerNumber,CustomerLastName,CustomerFirstName,CustomerAddress,CustomerCity,CustomerState,CustomerZipCode,CustomerAreaCode,CustomerPhoneNo) values( " + cnumber + ",'" + clastname + "','" + cfirstname + "','" + caddress + "','" + ccity + "','" + cstate + "','" + czipcode + "','" + careacode + "','" + cphoneno + "')";
            int i = db.InsertData(sql);
            return i;
        }

    }
}


