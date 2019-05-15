﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TexolBilling.BAL;

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
            if (CmbNameS.SelectedItem == null)
            {
                errorProvider4.SetError(CmbNameS, "Please select the Name");
                isValid = false;
            }
            else
            {
                errorProvider4.SetError(CmbNameS, "");
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

        private void Sales_Load(object sender, EventArgs e)
        {
            CommonFunctions objcmn = new CommonFunctions();
            txtSalesTranNo.Text = objcmn.GenerateSaleTransaction();


            Customers cust = new Customers();

            DataTable dt = cust.GetAllCustomers();

            CmbNameS.DisplayMember = "CustomerName";
            CmbNameS.ValueMember = "CustomerId";
            CmbNameS.DataSource = dt;


            Item itm = new Item();
            DataTable dt1 = itm.GetAllItem();
            CmbItemS.DisplayMember = "ItemName";
            CmbItemS.ValueMember = "ItemId";
            CmbItemS.DataSource = dt1;
        }
        Item itm = new Item();
        private void BtnAdd_Click(object sender, EventArgs e)
        {
            int i = itm.InsertSalesItem(txtSalesTranNo.Text, Convert.ToInt32(CmbItemS.SelectedValue.ToString()), Convert.ToInt32(txtPrice.Text), Convert.ToInt32(txtQuantity.Text));
            if (i > 0)
            {
                MessageBox.Show("Item Added Successfully");
            }
            else
            {
                MessageBox.Show("Fail to Add Item");
            } 
        }

        private void LblPrice_Click(object sender, EventArgs e)
        {

        }

        private void txtQuantity_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtPrice_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
