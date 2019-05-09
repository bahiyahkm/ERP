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
            if (txtSalesDate.Text == "")
            {
                errorProvider2.SetError(txtSalesDate, "Please enter the Sales date");
                isValid = false;
            }
            else
            {
                errorProvider2.SetError(txtSalesDate, "");
            }
            if (txtSalSId.Text == "")
            {
                errorProvider3.SetError(txtSalSId, "Please enter the Sales StaffId");
                isValid = false;
            }
            else
            {
                errorProvider3.SetError(txtSalSId, "");
            }
            if (txtCustomerId.Text == "")
            {
                errorProvider3.SetError(txtCustomerId, "Please enter the CustomerId");
                isValid = false;
            }
            else
            {
                errorProvider3.SetError(txtCustomerId, "");
            }
            if (txtSTotalAmount.Text == "")
            {
                errorProvider4.SetError(txtSTotalAmount, "Please enter the Total Amount");
                isValid = false;
            }
            else
            {
                errorProvider4.SetError(txtSTotalAmount, "");
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
    }
}
