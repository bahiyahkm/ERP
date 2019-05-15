﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TexolBilling.DAL;

namespace TexolBilling.BAL
{
   public class Vendor
    {
        Connection db = new Connection();
        public int InsertVendor(string vname, string vaddress, string vcity, string vstate, string vzipcode, string vareacode, string vphoneno)
        {
            string sql = "insert into vendor_tbl(VendorName,VendorAddress,VendorCity,VendorState,VendorZipCode,VendorAreaCode,VendorPhoneNo) values('" + vname + "','" + vaddress + "','" + vcity + "','" + vstate + "','" + vzipcode + "','" + vareacode + "','" + vphoneno + "')";
            int i = db.InsertData(sql);
            return i;
        }

        public DataTable GetAllVendor()
        {
           
            string sql = "select * from vendor_tbl";
            return db.GetData(sql);
           
        }
    }
}