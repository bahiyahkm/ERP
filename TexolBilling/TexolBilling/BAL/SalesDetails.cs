using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TexolBilling.DAL;

namespace TexolBilling.BAL
{
   public  class SalesDetails
    {
        Connection db = new Connection();
        public bool CheckIfSalesItemAlreadyInsert(string SaleTrNo,int ItemId)
        {
            string sql = "select * from salesitem_tbl where SalesTransactionNo='" + SaleTrNo + "' and ItemId=" + ItemId + "";
            DataTable dt = db.GetData(sql);
            if (dt.Rows.Count > 0)
            {
                return true;
            }
            else
            {
                return false;
            }

        }
        public int UpdateSalesItem(string SaleTrNo,int ItemId,int quantity)
        {
            string sql = "update sales_tbl set Quantity=(Quantity+" + quantity + ")where SaleTransactionNo='" + SaleTrNo + "' and ItemId=" + ItemId + "";
             int i = db.InsertData(sql);
            return i;

        }
        public int InsertSalesItem(string SaleTrNo,int ItemId,int rate,int quantity)
        {
            string sql= "insert into salesitem_tbl (SalesTransactionNo,ItemId,Rate,Quantity) values('"+SaleTrNo+"',"+ItemId+","+rate+","+quantity+")";
            int i = db.InsertData(sql);
            return i;
        }
    }
}
