using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TexolBilling.DAL;

namespace TexolBilling.BAL
{
    public class PurchaseDetails
    {
        Connection db = new Connection();
        public bool CheckIfPurchaseItemAlreadyInsert(string PurchaseTrNo, int ItemId)
        {
            string sql = "select * from purchaseitem_tbl where PurchaseTransactionNo='" + PurchaseTrNo + "' and ItemId=" + ItemId + "";
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
        public int UpdatePurchaseItem(int quantity,string purchaseTrNo,int itemid)
        {
            string sql = "update purchaseitem_tbl set Quantity=(Quantity+"+quantity+") where PurchaseTransactionNo='" +purchaseTrNo + "' and ItemId=" + itemid + "";
            int i= db.InsertData(sql);
            return i;
        }
        public int InsertPurchaseItem(string purchasetno, int itemid, int rate, int quantity)
        {
            string sql = "insert into purchaseitem_tbl(PurchaseTransactionNo,ItemId,Rate,Quantity) values('" + purchasetno + "'," + itemid + "," + rate + "," + quantity + ")";
            int i = db.InsertData(sql);
            return i;
        }
        public DataTable AddedItemIntoGridView(string TransactionNo)
        {
           string sql = "select  item_tbl.ItemName,purchaseitem_tbl.Rate,purchaseitem_tbl.Quantity,(purchaseitem_tbl.Rate*purchaseitem_tbl.Quantity) as TotalAmount from item_tbl inner join purchaseitem_tbl on purchaseitem_tbl.ItemId=item_tbl.ItemId where purchaseitem_tbl.PurchaseTransactionNo='" + TransactionNo+"'";
            return db.GetData(sql);
        }
        public int InsertDataToPurchaseTbl(string purchaseTrno,DateTime date,int vendorid,int tamount)
        {
            string sql = "insert into purchase_tbl(PurchaseTransactionNo,PurchaseDate,VendorId,TotalAmount) values('"+ purchaseTrno+"','"+date+"',"+vendorid+","+tamount+") ";
            int i = db.InsertData(sql);
            return i;
        }

    }
}

        
        
    

