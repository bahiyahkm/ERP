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
            string sql = "update salesitem_tbl set Quantity=(Quantity+" + quantity + ")where SalesTransactionNo='" + SaleTrNo + "' and ItemId=" + ItemId + "";
             int i = db.InsertData(sql);
            return i;

        }
        
        public int InsertSalesItem(string SaleTrNo,int ItemId,decimal rate,int quantity)
        {
            string sql= "insert into salesitem_tbl (SalesTransactionNo,ItemId,Rate,Quantity) values('"+SaleTrNo+"',"+ItemId+","+rate+","+quantity+")";
            int i = db.InsertData(sql);
            return i;
        }
        public DataTable AddedItemIntoGridView(string TransactionNo)
        {
            string sql = "select  item_tbl.ItemName,salesitem_tbl.Rate,salesitem_tbl.Quantity,(salesitem_tbl.Rate*salesitem_tbl.Quantity) as TotalAmount from item_tbl inner join salesitem_tbl on salesitem_tbl.ItemId=item_tbl.ItemId where salesitem_tbl.SalesTransactionNo='" + TransactionNo + "'";
            return db.GetData(sql);
        }
        public int InsertDataToSalesTbl(string salesTrno, DateTime date, int customerid, decimal tax, decimal tamount,decimal subtotal)
        {
            string sql = "insert into sales_tbl(SalesTransactionNo,SalesDate,CustomerId,TaxAmount,TotalAmount,SubTotal) values('" + salesTrno + "','" + date + "'," + customerid + "," + tax + "," + tamount + ","+subtotal+") ";
            int i = db.InsertData(sql);
            return i;
        }
        public DataTable GetSalesItemByDate(DateTime dtp1, DateTime dtp2)
        {
            string sql = "select sales_tbl.SalesTransactionNo,customers_tbl.CustomerName,sales_tbl.SalesDate,sales_tbl.TotalAmount from sales_tbl inner join customers_tbl on sales_tbl.CustomerId=customers_tbl.CustomerId where SalesDate between '" + dtp1.Date + "' and '" + dtp2.Date + "'";
            return db.GetData(sql);
        }
        public DataTable GetSumOFTotalAmount(DateTime dtp1, DateTime dtp2)
        {
            string sql = "select sum(TotalAmount) as tt from sales_tbl inner join customers_tbl on sales_tbl.CustomerId=customers_tbl.CustomerId where SalesDate between '" + dtp1.Date + "' and '" + dtp2.Date + "'";
            return db.GetData(sql);
        }
        public DataTable GetSalesByTranNo(string TrnNo)
        {
            string sql = "select customers_tbl.CustomerName,customers_tbl.CustomerAddress,customers_tbl.CustomerPhoneNo,sales_tbl.SalesDate from customers_tbl inner join sales_tbl on sales_tbl.CustomerId=customers_tbl.CustomerId where sales_tbl.SalesTransactionNo='"+TrnNo+"'";
            return db.GetData(sql);

        }
        public DataTable GetTotalSale(string date)
        {
            string sql = "select sum(TotalAmount) as TotalSales from sales_tbl where SalesDate='"+date+"'";
            return db.GetData(sql);
        }
       
    }
}
