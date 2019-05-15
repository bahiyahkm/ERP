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


    }
}

        
        
    

