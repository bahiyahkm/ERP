using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using TexolBilling.DAL;

namespace TexolBilling.BAL
{
    
  public  class Item
    {
        Connection db = new Connection();
        public int ItemAdd(string itemname,int quantity,int rate)
        {
            string sql = "insert into item_tbl (ItemName,Quantity,Rate) values ('" + itemname + "'," + quantity + "," + rate + ")";
            int i = db.InsertData(sql);
            return i;
        }
        public DataTable GetAllItem()
        {
            string sql = "select * from item_tbl ";
            return db.GetData(sql);
        }
        public int InsertPurchaseItem(string purchasetno,int itemid,int rate,int quantity)
        {
            string sql = "insert into purchaseitem_tbl(PurchaseTransactionNo,ItemId,Rate,Quantity) values('" + purchasetno + "'," + itemid + "," + rate + "," + quantity + ")";
            int i = db.InsertData(sql);
            return i;
        }
        public int InsertSalesItem(string salestno,int itemid,int rate,int quantity)
        {
            string sql = "insert into salesitem_tbl(SalesTransactionNo,ItemId,Rate,Quantity)values('" + salestno + "'," + itemid + "," + rate + "," + quantity + ")";
            int i = db.InsertData(sql);
            return i;
        }
    }
}
