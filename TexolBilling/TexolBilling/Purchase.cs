﻿using System;
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
                     
                        if (Convert.ToInt32(dgvPurchase.Rows.Count) > 1)
                        {
                            int i = objprodetails.InsertDataToPurchaseTbl(txtPurchaseTNo.Text, dateTimePicker1.Value.Date, Convert.ToInt32(CmbName.SelectedValue.ToString()), Convert.ToInt32(LblTaxAmount.Text), Convert.ToInt32(lblTotal.Text), Convert.ToInt32(LblSubTotal.Text));
                            if (i > 0)
                            {
                                MessageBox.Show(" Saved Succesfully");
                                PurchaseInvoiceReport objPReport = new PurchaseInvoiceReport();
                                objPReport.LblPurchaseTrNo.Text = txtPurchaseTNo.Text;
                                objPReport.LblTotalAmount.Text = lblTotal.Text;
                                objPReport.LblTaxAmount.Text = LblTaxAmount.Text;
                                objPReport.LblSubTotal.Text = LblSubTotal.Text;
                                objPReport.Show();
                                clear();
                            }
                            else
                            {
                                MessageBox.Show("Saving Failed");
                            }
                        }
                        else
                        {
                            MessageBox.Show("Please add the items");
                        }
                    }
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("Error-------------:" + ex.Message);
            }
               
            
            
           
        }
        public void clear()
        {
            CommonFunctions objcmn = new CommonFunctions();
            txtPurchaseTNo.Text = objcmn.GenerateRandomNo();
            BindGrid();
            txtQuantity.Text = "0";
            txtPrice.Text = "0";
            txtTax.Text = "0";
            lblTotal.Text="0";
            CmbName.Text = "--select Vendor--";
            CmbItemName.Text = "--select Item--";
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
            DataRow row = dt.NewRow();
            row["VendorId"] = 0;
            row["VendorName"] = "--Select Vendor--";
            dt.Rows.InsertAt(row, 0);
            CmbName.DisplayMember = "VendorName";
            CmbName.ValueMember = "VendorId";
            CmbName.DataSource = dt;
           
            Item itm = new Item();
            DataTable dt1 = itm.GetAllItem();
            DataRow row1 = dt1.NewRow();
            row1["ItemId"] = 0;
            row1["ItemName"] = "--Select Item--";
            dt1.Rows.InsertAt(row1, 0);
            CmbItemName.DisplayMember = "ItemName";
            CmbItemName.ValueMember = "ItemId";
            CmbItemName.DataSource = dt1;
          
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
        public void CalculateTax()
        {
           LblTaxAmount.Text = ((Convert.ToInt32(lblTotal.Text) * Convert.ToInt32(txtTax.Text) / 100)).ToString();
            LblSubTotal.Text = (Convert.ToInt32(lblTotal.Text) + Convert.ToInt32(LblTaxAmount.Text)).ToString();
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
                CalculateTax();
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
           
                DataTable dt = objprodetails.AddedItemIntoGridView(txtPurchaseTNo.Text);
                dgvPurchase.DataSource = dt;
             
        }

        private void txtTax_TextChanged(object sender, EventArgs e)
        {
            CalculateTax();
        }
    }
    }



