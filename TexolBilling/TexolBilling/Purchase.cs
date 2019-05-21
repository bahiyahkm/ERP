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
        PurchaseDetails objprodetails = new PurchaseDetails();
        Vendor vend = new Vendor();
        private void BtnSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (Validation())
                {
                    {

                        int i = objprodetails.InsertDataToPurchaseTbl(txtPurchaseTNo.Text, dateTimePicker1.Value.Date, Convert.ToInt32(CmbName.SelectedValue.ToString()), Convert.ToInt32(lblTotal.Text));
                        if (i > 0)
                        {
                            MessageBox.Show(" Saved Succesfully");
                            clear();
                        }
                        else
                        {
                            MessageBox.Show("Saving Failed");
                        }
                    }
                }
                else
                {
                    // LblPurchase.Text = "Please fill the Mandatory feild";
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("Error" + ex.Message);
            }
           
        }
        public void clear()
        {
            CommonFunctions objcmn = new CommonFunctions();
            txtPurchaseTNo.Text = objcmn.GenerateRandomNo();
            BindGrid();
            txtQuantity.Text = "";
            txtPrice.Text = "";
            lblTotal.Text="0";
            CmbName.Text = "select Vendor";
            CmbItemName.Text = "select Item";
            LblAddress.Text = "Address";
            LblPhno.Text = "ContactNo";
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
            if (CmbName.SelectedItem == null)
            {
                errorProvider2.SetError(CmbName, "Please select a name");
            }
            else
            {
                errorProvider2.SetError(CmbName, "");
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
            CmbName.DisplayMember = "VendorName";
            CmbName.ValueMember = "VendorId";
            CmbName.DataSource = dt;
            CmbName.Text = "select Vendor";
            Item itm = new Item();
            DataTable dt1 = itm.GetAllItem();
            CmbItemName.DisplayMember = "ItemName";
            CmbItemName.ValueMember = "ItemId";
            CmbItemName.DataSource = dt1;
            CmbItemName.Text = "select Item";
            CommonFunctions objcmn = new CommonFunctions();
            txtPurchaseTNo.Text = objcmn.GenerateRandomNo(); 
        }
        private void CBName_SelectedIndexChanged(object sender, EventArgs e)
        {
            int VendorId = Convert.ToInt32(CmbName.SelectedValue);
            DataTable dt = vend.GetVendorByName(VendorId);
            if (dt.Rows.Count > 0)
            {
                LblAddress.Text = dt.Rows[0]["VendorAddress"].ToString();
                LblPhno.Text = dt.Rows[0]["VendorPhoneNo"].ToString();
            }
        }
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            int ItemId = Convert.ToInt32(CmbItemName.SelectedValue.ToString());
            DataTable dt = itm.GetItemById(Convert.ToInt32(ItemId));
            if (dt.Rows.Count > 0)
            {
                txtPrice.Text = dt.Rows[0]["Rate"].ToString();
            }
        }
        private void BtnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                int ItemId1 = Convert.ToInt32(CmbItemName.SelectedValue.ToString());
                DataTable dt = itm.GetItemById(Convert.ToInt32(ItemId1));
                if (dt.Rows.Count > 0)
                {
                    LblMessage.Text = dt.Rows[0]["Quantity"].ToString();
                }
              lblTotal.Text = (Convert.ToInt32(lblTotal.Text) + (Convert.ToInt32(txtPrice.Text) * Convert.ToInt32(txtQuantity.Text))).ToString();
                    string PurchaseTrNo = txtPurchaseTNo.Text;
                    int ItemId = Convert.ToInt32(CmbItemName.SelectedValue);
                    if (objprodetails.CheckIfPurchaseItemAlreadyInsert(PurchaseTrNo, ItemId))
                    {
                        int i = objprodetails.UpdatePurchaseItem(Convert.ToInt32(txtQuantity.Text), txtPurchaseTNo.Text, Convert.ToInt32(CmbItemName.SelectedValue.ToString()));
                        int j = itm.UpdatePurchaseQuantity(Convert.ToInt32(ItemId), Convert.ToInt32(txtQuantity.Text));
                    }
                    else
                    {
                        int i = objprodetails.InsertPurchaseItem(txtPurchaseTNo.Text, Convert.ToInt32(CmbItemName.SelectedValue.ToString()), Convert.ToInt32(txtPrice.Text), Convert.ToInt32(txtQuantity.Text));
                        int j = itm.UpdatePurchaseQuantity(Convert.ToInt32(ItemId), Convert.ToInt32(txtQuantity.Text));
                    }
                               
                txtQuantity.Text = "";
                BindGrid();
            }
            catch(Exception ex)
            {
                MessageBox.Show("Error" + ex.Message);
            }
            }
        void BindGrid()
        {
            try
            {
                DataTable dt = objprodetails.AddedItemIntoGridView(txtPurchaseTNo.Text);
                dgvPurchase.DataSource = dt;
            }
            catch(Exception ex)
            {
                MessageBox.Show("Error" + ex.Message);
                
            }
        }

       
    }
    }



