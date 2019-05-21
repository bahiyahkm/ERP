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
    public partial class SalesReport : Form
    {
        public SalesReport()
        {
            InitializeComponent();
        }
        SalesDetails objsalereport = new SalesDetails();
        


        private void BtnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Show_Click(object sender, EventArgs e)
        {
            Bind();
            sum();
        }
      public  void Bind()
        {
            DataTable dt = objsalereport.GetSalesItemByDate(Convert.ToDateTime(dtpFrom.Value.ToString()), Convert.ToDateTime(dtp2.Value.ToString()));
            dgvSalesReport.DataSource = dt;

        }
        public void sum()
        {
            DataTable dt = objsalereport.GetSumOFTotalAmount(Convert.ToDateTime(dtpFrom.Value.ToString()), Convert.ToDateTime(dtp2.Value.ToString()));
            LblMessage.Text = dt.Rows[0]["tt"].ToString();
        }
    }
}
