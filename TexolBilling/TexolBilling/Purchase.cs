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
        Item itm = new Item();
        PurchaseDetails pd = new PurchaseDetails();
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
            Vendor vend = new Vendor();

            DataTable dt = vend.GetAllVendor();
           
            CBName.DisplayMember = "VendorName";
            CBName.ValueMember = "VendorId";
            CBName.DataSource = dt;

            Item itm = new Item();
            DataTable dt1 = itm.GetAllItem();
            CmbItemName.DisplayMember = "ItemName";
            CmbItemName.ValueMember = "ItemId";
            CmbItemName.DataSource = dt1;

               


            


            CommonFunctions objcmn = new CommonFunctions();
            txtPurchaseTNo.Text = objcmn.GenerateRandomNo(); //testtttt
            
        }

        private void CBName_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        
        private void BtnAdd_Click(object sender, EventArgs e)
        {
            
            string purchasetno = txtPurchaseTNo.Text;
            int ItemId = Convert.ToInt32(CmbItemName.ValueMember);
            
            
            if (pd.CheckIfPurchaseItemAlreadyInsert(purchasetno,ItemId ))
            {
                MessageBox.Show("Customer Already Exists with PurchaseTransactionNo " + txtPurchaseTNo.Text);
            }
            else
            {

                MessageBox.Show("Customer doesnot exist");
                
            }




            int i = itm.InsertPurchaseItem(txtPurchaseTNo.Text,Convert.ToInt32(CmbItemName.SelectedValue.ToString()), Convert.ToInt32(txtPrice.Text), Convert.ToInt32(txtQuantity.Text));

            if (i > 0)
            {
                MessageBox.Show("Item Added Successfully");
            }
            else
            {
                MessageBox.Show("Fail to Add Item");
            }
        }
    }
}
