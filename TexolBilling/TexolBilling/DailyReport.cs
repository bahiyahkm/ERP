using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TexolBilling.BAL;

namespace TexolBilling
{
    public partial class DailyReport : Form
    {
        public DailyReport()
        {
            InitializeComponent();
        }
        SalesDetails objsaledetails = new SalesDetails();
        PurchaseDetails objpurchasedetails = new PurchaseDetails();
        private void DailyReport_Load(object sender, EventArgs e)
        {
            //DateTime dt = DateTime.Now.ToShortDateString();
            string salereport = DateTime.Now.ToShortDateString();

            DataTable dt_saleamount = objsaledetails.GetTotalSale(salereport);
            LblTotalSale.Text = dt_saleamount.Rows[0]["TotalSales"].ToString();

            string purchasereport = DateTime.Now.ToShortDateString();
            DataTable dt_purchaseamount = objpurchasedetails.GetTotalPurchase(purchasereport);
            LblTotalPurchase.Text = dt_purchaseamount.Rows[0]["TotalPurchase"].ToString();
        }
    }
}
