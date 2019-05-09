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
    public partial class Purchase : Form
    {
        public Purchase()
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
              // LblPurchase.Text = "Please fill the Mandatory feild";
            }
        }
        public bool Validation()
        {
            bool isValid = true;
            if (txtPurchaseTranNo.Text == "")
            {
                errorProvider1.SetError(txtPurchaseTranNo, "Please enter the transactionNo");
            }
            else
            {
                errorProvider1.SetError(txtPurchaseTranNo, "");
            }
            if (txtPurchaseDate.Text == "")
            {
                errorProvider2.SetError(txtPurchaseDate, "Please enter the purchase date");
            }
            else
            {
                errorProvider2.SetError(txtPurchaseDate, "");
            }
            if (txtVendorId.Text == "")
            {
                errorProvider3.SetError(txtVendorId, "Please enter the vendorId");
            }
            else
            {
                errorProvider3.SetError(txtVendorId, "");
            }
            if (txtPTotalAmont.Text == "")
            {
                errorProvider4.SetError(txtPTotalAmont, "Please enter the total amount");
            }
            else
            {
                errorProvider4.SetError(txtPTotalAmont, "");
            }
            return isValid;
        }

        private void txtPTotalAmont_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(!(char.IsDigit(e.KeyChar)||char.IsControl(e.KeyChar)))
            {
                e.Handled = true;
                MessageBox.Show("Please enter the digits only");
            }

            
        }
    }
}
