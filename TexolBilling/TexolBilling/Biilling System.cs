using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TexolBilling
{
    public partial class Biilling_System : Form
    {
        public Biilling_System()
        {
            InitializeComponent();
        }

        private void purchaseReportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Purchase objpurchase = new Purchase();
            objpurchase.Show();
        }

        private void salesReportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Sales objsale = new Sales();
            objsale.Show();
        }
        private void purchaseReportToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            PurchaseReport objpr = new PurchaseReport();
            objpr.Show();
        }

        private void salesReportToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            SalesReport objsr = new SalesReport();
            objsr.Show();
        }

        private void customerReportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CustomerReport objcp = new CustomerReport();
            objcp.Show();
        }

        private void itemReportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ItemReport objip = new ItemReport();
            objip.Show();
        }

        private void vendorToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            VendorReport objvp = new VendorReport();
            objvp.Show();
        }

       

       

        private void addItemToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            ItemAdd objitem = new ItemAdd();
            objitem.Show();
        }

        private void addVendorToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Vendor objvend = new Vendor();
            objvend.Show();
        }

        private void addCustomerToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Customer objcust = new Customer();
            objcust.Show();
        }

        private void purchaseToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Purchase objpurchase = new Purchase();
            objpurchase.Show();

        }

        private void salesToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Sales objsale = new Sales();
            objsale.Show();
        }

        private void loToolStripMenuItem_Click(object sender, EventArgs e)
        {

            
        }
    }
}
