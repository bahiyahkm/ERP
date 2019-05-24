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
    public partial class SalesInvoiceReport : Form
    {
        public SalesInvoiceReport()
        {
            InitializeComponent();
        }
        SalesDetails objsaledetails = new SalesDetails();
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void SalesInvoiceReport_Load(object sender, EventArgs e)
        {
            string SalesNo = LblSalesTrno.Text;
           DataTable dt = objsaledetails.GetSalesByTranNo(SalesNo);
            if (dt.Rows.Count > 0)
            {
                LblCustomerName.Text = dt.Rows[0]["CustomerName"].ToString();
                LblCustomerAddress.Text = dt.Rows[0]["CustomerAddress"].ToString();
                LblPhno.Text = dt.Rows[0]["CustomerPhoneNo"].ToString();
                LblSalesDate.Text = dt.Rows[0]["SalesDate"].ToString();
               
            }
            Bind();


        }
        public void Bind()
        {
            DataTable dt = objsaledetails.AddedItemIntoGridView(LblSalesTrno.Text);
            dgvSalesInvoice.DataSource = dt;
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
