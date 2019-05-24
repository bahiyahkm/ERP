using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TexolBilling.BAL;

namespace TexolBilling
{
    public partial class PurchaseInvoiceReport : Form
    {
        public PurchaseInvoiceReport()
        {
            InitializeComponent();
        }
        PurchaseDetails objPurchasedetails = new PurchaseDetails();

        private void PurchaseInvoiceReport_Load(object sender, EventArgs e)
        {
            string PurchaseNo = LblPurchaseTrNo.Text;
            DataTable dt = objPurchasedetails.GetPurchaseByTrNo(PurchaseNo);
            if(dt.Rows.Count>0)
            {
                LblPurchaseDate.Text = dt.Rows[0]["PurchaseDate"].ToString();
                LblVendorName.Text = dt.Rows[0]["VendorName"].ToString();
                LblVendorAddress.Text = dt.Rows[0]["VendorAddress"].ToString();
                LblVendorPhno.Text = dt.Rows[0]["VendorPhoneNo"].ToString();

            }
            Bind();
            
        }
        public void Bind()
        {
            DataTable dt = objPurchasedetails.AddedItemIntoGridView(LblPurchaseTrNo.Text);
            dgvPurchaseInvoice.DataSource = dt;
        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnPrint_Click(object sender, EventArgs e)
        {
            BtnPrint.Visible = false;
            BtnCancel.Visible = false;
            PrintDocument _document = new PrintDocument();
            _document.PrintPage += new PrintPageEventHandler(Document_PrintPage);
            PrintPreviewDialog _dlg = new PrintPreviewDialog();
            _dlg.ClientSize = new System.Drawing.Size(Width / 2, Height / 2);
            _dlg.Location = new System.Drawing.Point(Left, Top);
            _dlg.MinimumSize = new System.Drawing.Size(375, 250);
            _dlg.UseAntiAlias = true;
            _dlg.Document = _document;
            _dlg.ShowDialog(this);
            _document.Dispose();
            this.Hide();
        }

        private void Document_PrintPage(object sender, PrintPageEventArgs e)
        {
            Bitmap _bitmap = new Bitmap(Width, Height, System.Drawing.Imaging.PixelFormat.Format32bppRgb);
            this.DrawToBitmap(_bitmap, this.DisplayRectangle);
            e.Graphics.DrawImage(_bitmap, 0, 0);
            _bitmap.Dispose();
        }
    }
}
