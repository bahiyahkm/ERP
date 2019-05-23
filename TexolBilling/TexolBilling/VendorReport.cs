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
using Excel = Microsoft.Office.Interop.Excel;

namespace TexolBilling
{
    public partial class VendorReport : Form
    {
        public VendorReport()
        {
            InitializeComponent();
        }
        Vendor objvend = new Vendor();

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnShowVendor_Click(object sender, EventArgs e)
        {

        }
        public void Bind()
        {
            DataTable dt = objvend.GetVendorByDate(Convert.ToDateTime(dtpFrom.Value.ToString()), Convert.ToDateTime(dtpTo.Value.ToString()));
            dgvVendorReport.DataSource = dt;
        }
        public void copyAlltoClipboard()
        {
            dgvVendorReport.SelectAll();
            DataObject dataObj = dgvVendorReport.GetClipboardContent();
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
