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
    public partial class Sales : Form
    {
        public Sales()
        {
            InitializeComponent();
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
           if(Validation())
            {

            }
           else
            {
                //
            }

        }
       public bool Validation()
        {
            bool isValid = true;
            if (txtSalesTranNo.Text == "")
            {
                errorProvider1.SetError(txtSalesTranNo, "Please enter the transactionNo");
                isValid = false;
            }
            else
            {
                errorProvider1.SetError(txtSalesTranNo, "");
            }
            if (dtpSales.Text == "")
            {
                errorProvider2.SetError(dtpSales, "Please Select the Sales date");
                isValid = false;
            }
            else
            {
                errorProvider2.SetError(dtpSales, "");
            }
            if (cbSPayMet.SelectedItem == null)
            {
                errorProvider3.SetError(cbSPayMet, "Please select the Payment Method");
                isValid = false;
            }
            else
            {
                errorProvider3.SetError(cbSPayMet, "");
            }
            if (cbSname.SelectedItem == null)
            {
                errorProvider4.SetError(cbSname, "Please select the Name");
                isValid = false;
            }
            else
            {
                errorProvider4.SetError(cbSname, "");
            }

            return isValid;
        }

        private void txtSTotalAmount_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsDigit(e.KeyChar)||char.IsControl(e.KeyChar)))
            {
                e.Handled = true;
                MessageBox.Show("Please enter the digits only");
            }
        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
