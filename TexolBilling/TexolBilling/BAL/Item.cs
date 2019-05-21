﻿using System;
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
      
       
        public DataTable GetItemById(int ItemId)
        {
            string sql = "select * from item_tbl where ItemId=" + ItemId + "";
            return db.GetData(sql);
        }
        public int UpdateSalesQuantity(int ItemId,int quantity)
        {
            string sql = "update item_tbl set Quantity=(Quantity-" + quantity + ") where ItemId="+ItemId+" ";
           int i= db.InsertData(sql);
            return i;
        }
        public int UpdatePurchaseQuantity(int ItemId,int quantity)
        {
            string sql = "update item_tbl set Quantity=(Quantity+" + quantity + ")where ItemId=" + ItemId + "";
            int i = db.InsertData(sql);
            return i;
        }
        public DataTable GetItemByDate(DateTime dtp1, DateTime dtp2)
        {
            string sql = "select   ItemName,Quantity,Rate from item_tbl  where Date between '" + dtp1.Date + "' and '" + dtp2.Date + "'";
            return db.GetData(sql);
        }

    }
}

