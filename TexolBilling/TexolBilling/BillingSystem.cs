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
            foreach(Form f in Application.OpenForms)
            {
                if(f is Purchase)
                {
                    f.Focus();
                    return;
                }
            }
            Purchase objpurchase = new Purchase();
            objpurchase.MdiParent = this;
            objpurchase.Show();
        }
        private void salesReportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach(Form f in Application.OpenForms)
            {
                if(f is Sales)
                {
                    f.Focus();
                    return;
                }
            }
            Sales objsale = new Sales();
            objsale.MdiParent = this;
            objsale.Show();
        }
        private void purchaseReportToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            foreach(Form f in Application.OpenForms)
            {
                if(f is PurchaseReport)
                {
                    f.Focus();
                    return;
                }
            }
            PurchaseReport objpr = new PurchaseReport();
            objpr.MdiParent = this;
            objpr.Show();
        }
        private void salesReportToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            foreach(Form f in Application.OpenForms)
            {
                if( f is SalesReport)
                {
                    f.Focus();
                    return;
                }
            }
            SalesReport objsr = new SalesReport();
            objsr.MdiParent = this;
            objsr.Show();
        }
        private void customerReportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach(Form f in Application.OpenForms)
            {
                if(f is CustomerReport)
                {
                    f.Focus();
                    return;
                }
            }
            CustomerReport objcp = new CustomerReport();
            objcp.MdiParent = this;
            objcp.Show();
        }
        private void itemReportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach(Form f in Application.OpenForms)
            {
                if(f is ItemReport)
                {
                    f.Focus();
                    return;
                }
            }
            ItemReport objip = new ItemReport();
            objip.MdiParent = this;
            objip.Show();
        }
        private void vendorToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            foreach (Form f in Application.OpenForms)
            {
                if (f is VendorReport)
                {
                    f.Focus();
                    return;
                }
            }
            VendorReport objvp = new VendorReport();
            objvp.MdiParent = this;
            objvp.Show();
        }
        private void addItemToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            foreach (Form f in Application.OpenForms)
            {
                if (f is ItemAdd)
                {
                    f.Focus();
                    return;
                }
            }

           
            ItemAdd objitem = new ItemAdd();
            objitem.MdiParent = this;
            objitem.Show();
        }
        private void addVendorToolStripMenuItem1_Click(object sender, EventArgs e)
        {

            foreach (Form f in Application.OpenForms)
            {
                if (f is AddVendor)
                {
                    f.Focus();
                    return;
                }
            }
            AddVendor objvend = new AddVendor();
            objvend.MdiParent = this;
            objvend.Show();
        }
        private void addCustomerToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            foreach (Form f in Application.OpenForms)
            {
                if (f is Customer)
                {
                    f.Focus();
                    return;
                }
            }
            Customer objcust = new Customer();
            objcust.MdiParent = this;
            objcust.Show();
        }
        private void purchaseToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            foreach (Form f in Application.OpenForms)
            {
                if (f is Purchase)
                {
                    f.Focus();
                    return;
                }
            }
            Purchase objpurchase = new Purchase();
            objpurchase.MdiParent = this;
            objpurchase.Show();

        }
        private void salesToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            foreach (Form f in Application.OpenForms)
            {
                if (f is Sales)
                {
                    f.Focus();
                    return;
                }
            }
            Sales objsale = new Sales();
            objsale.MdiParent = this;
            objsale.Show();
        }
        private void loToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
            
        }

        private void dailyReportToolStripMenuItem_Click(object sender, EventArgs e)
        {

            foreach (Form f in Application.OpenForms)
            {
                if (f is DailyReport)
                {
                    f.Focus();
                    return;
                }
            }
            DailyReport objdailyreport = new DailyReport();
           objdailyreport.MdiParent = this;
            objdailyreport.Show();
        }
    }
}
