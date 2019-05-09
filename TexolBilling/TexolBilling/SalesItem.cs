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
    public partial class SalesItem : Form
    {
        public SalesItem()
        {
            InitializeComponent();
        }

        private void SalesItem_Load(object sender, EventArgs e)
        {

        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
           if(Validation())
            {

            }
           else
            {
                //lblMessge.Text = "Please fill the mandatory field";
            }
        }
        public bool Validation()
        {
            bool isValid = true;
            if (txtSalesId.Text == "")
            {
                errorProvider1.SetError(txtSalesId, "Please enter the SalesId");
            }
            else
            {
                errorProvider1.SetError(txtSalesId, "");
            }
            if (txtSItemId.Text == "")
            {
                errorProvider2.SetError(txtSItemId, "Please enter the ItemId");
            }
            else
            {
                errorProvider2.SetError(txtSItemId, "");
            }
            if (txtSRate.Text == "")
            {
                errorProvider3.SetError(txtSRate, "Please enter the rate");
            }
            else
            {
                errorProvider3.SetError(txtSRate, "");
            }
            if (txtSQuantity.Text == "")
            {
                errorProvider4.SetError(txtSQuantity, "Please enter the Quantity");
            }
            else
            {
                errorProvider4.SetError(txtSQuantity, "");
            }
            return isValid;
        }

        private void txtSQuantity_KeyPress(object sender, KeyPressEventArgs e)
        {
            
            if(!(char.IsDigit(e.KeyChar)||char.IsLetter(e.KeyChar)||char.IsControl(e.KeyChar)))
            {
                e.Handled = true;
                MessageBox.Show("Please enter the digits only");
            }
        }

        private void txtSRate_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsDigit(e.KeyChar)))
            {
                e.Handled = true;
                MessageBox.Show("Please enter the digits only");
            }
        }
    }
}
