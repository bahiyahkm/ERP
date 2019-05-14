using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TexolBilling.BAL;



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
                {

                }
            }
         else
            {
              // LblPurchase.Text = "Please fill the Mandatory feild";
            }
        }
        public bool Validation()
        {
            bool isValid = true;
            if (txtPurchaseTNo.Text == "")
            {
                errorProvider1.SetError(txtPurchaseTNo, "Please enter the transactionNo");
            }
            else
            {
                errorProvider1.SetError(txtPurchaseTNo, "");
            }
            if (CBName.SelectedItem == null)
            {
                errorProvider2.SetError(CBName, "Please select a name");
            }
            else
            {
                errorProvider2.SetError(CBName, "");
            }
            if (CBPayMet.SelectedItem == null)
            {
                errorProvider3.SetError(CBPayMet, "Please select a Payment Method");
            }
            else
            {
                errorProvider3.SetError(CBPayMet, "");
            }


            return isValid;
        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Purchase_Load(object sender, EventArgs e)
        {
            CommonFunctions objcmn = new CommonFunctions();
            txtPurchaseTNo.Text = objcmn.GenerateRandomNo(); //testtttt
            
        }

       
    }
}
