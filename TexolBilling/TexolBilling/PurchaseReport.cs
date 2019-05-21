using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using TexolBilling.BAL;
using Excel = Microsoft.Office.Interop.Excel;



namespace TexolBilling
{
    public partial class PurchaseReport : Form
    {
        public PurchaseReport()
        {
            InitializeComponent();
        }
        PurchaseDetails objprodetails = new PurchaseDetails();

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnShowP_Click(object sender, EventArgs e)
        {

            Bind();
            sum();
        }
      public  void Bind()
        {
            DataTable dt = objprodetails.GetPurchaseItemByDate(Convert.ToDateTime(dtpFrom.Value.ToString()), Convert.ToDateTime(dtpTo.Value.ToString()));
            dgvPurchaseReport.DataSource = dt;
               
        }
      public  void sum()
        {

            DataTable dt = objprodetails.GetSumOFTotalAmount(Convert.ToDateTime(dtpFrom.Value.ToString()), Convert.ToDateTime(dtpTo.Value.ToString()));
            LblTAmount.Text = dt.Rows[0]["tt"].ToString();       
        }

        public void copyAlltoClipboard()
        {
           dgvPurchaseReport.SelectAll();
            DataObject dataObj = dgvPurchaseReport.GetClipboardContent();
            if (dataObj != null)
                Clipboard.SetDataObject(dataObj);
        }
        private void BtnExport_Click(object sender, EventArgs e)
        {
            copyAlltoClipboard();
            Microsoft.Office.Interop.Excel.Application xlexcel;
            Microsoft.Office.Interop.Excel.Workbook xlWorkBook;
            Microsoft.Office.Interop.Excel.Worksheet xlWorkSheet;
            object misValue = System.Reflection.Missing.Value;
            xlexcel = new Excel.Application();
            xlexcel.Visible = true;
            xlWorkBook = xlexcel.Workbooks.Add(misValue);
            xlWorkSheet = (Excel.Worksheet)xlWorkBook.Worksheets.get_Item(1);
            Excel.Range CR = (Excel.Range)xlWorkSheet.Cells[1, 1];
            CR.Select();
            xlWorkSheet.PasteSpecial(CR, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, true);
        }
    }
}
