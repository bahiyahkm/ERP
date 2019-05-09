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
    public partial class PurchaseItem : Form
    {
        public PurchaseItem()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

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
            if (txtPurchaseId.Text == "")
            {
                errorProvider1.SetError(txtPurchaseId, "Please enter the PurchaseId");
            }
            else
            {
                errorProvider1.SetError(txtPurchaseId, " ");
            }
            if (txtItemId.Text == "")
            {
                errorProvider2.SetError(txtItemId, "Please enter the ItemId");
            }
            else
            {
                errorProvider2.SetError(txtItemId, "");
            }
            if (txtPRate.Text == "")
            {
                errorProvider3.SetError(txtPRate, "Please enter the Rate");
            }
            else
            {
                errorProvider3.SetError(txtPRate, "");
            }
            if (txtPQuantity.Text == "")
            {
                errorProvider4.SetError(txtPQuantity, "Please enter the Quantity");
            }
            else
            {
                errorProvider4.SetError(txtPQuantity, "");
            }
            return isValid;
        }

        private void txtPRate_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(!(char.IsDigit(e.KeyChar)||char.IsControl(e.KeyChar)))
            {
                e.Handled = true;
                MessageBox.Show("Please enter the digits only");
            }
        }

        private void txtPQuantity_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsDigit(e.KeyChar)||char.IsControl(e.KeyChar)))
            {
                e.Handled = true;
                MessageBox.Show("Please enter the digits only");
            }
        }

        private void PurchaseItem_Load(object sender, EventArgs e)
        {

        }
    }
}
