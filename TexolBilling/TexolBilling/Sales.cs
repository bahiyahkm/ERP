using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TexolBilling.BAL;
using System.Data.SqlClient;

namespace TexolBilling
{
    public partial class Sales : Form
    {
        public Sales()
        {
            InitializeComponent();
        }
        Customers objcust = new Customers();
        SalesDetails objsaledetails = new SalesDetails();
        Item itm = new Item();
        private void BtnSave_Click(object sender, EventArgs e)
        {
           if(Validation())
            {
                int i = objsaledetails.InsertDataToSalesTbl(txtSalesTranNo.Text, datetimepicker2.Value.Date, Convert.ToInt32(CmbNameS.SelectedValue.ToString()), Convert.ToInt32(lblTotal.Text));
                if (i > 0)
                {
                    MessageBox.Show(" Saved Succesfully");
                }
                else
                {
                    MessageBox.Show("Saving Failed");
                }
            }
           else
            {
                
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
            if (datetimepicker2.Text == "")
            {
                errorProvider2.SetError(datetimepicker2, "Please Select the Sales date");
                isValid = false;
            }
            else
            {
                errorProvider2.SetError(datetimepicker2, "");
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
        private void BtnAdd_Click(object sender, EventArgs e)
        {
            lblTotal.Text = ((Convert.ToInt32(lblTotal.Text) + Convert.ToInt32(txtPrice.Text) * Convert.ToInt32(txtQuantity.Text))).ToString();
            string SaleTrNo = txtSalesTranNo.Text;
            int ItemId = Convert.ToInt32(CmbItemS.SelectedValue.ToString());
            if (objsaledetails.CheckIfSalesItemAlreadyInsert(SaleTrNo, ItemId))
            {
                int i = objsaledetails.UpdateSalesItem(txtSalesTranNo.Text, Convert.ToInt32(CmbItemS.SelectedValue.ToString()), Convert.ToInt32(txtQuantity.Text));
                if (i > 0)
                {
                    MessageBox.Show("Item Added Succesfully");
                }
                else
                {

                }
            }
            else
            {
                int i = objsaledetails.InsertSalesItem(txtSalesTranNo.Text, Convert.ToInt32(CmbItemS.SelectedValue.ToString()), Convert.ToInt32(txtPrice.Text), Convert.ToInt32(txtQuantity.Text));
                if (i > 0)
                {
                    MessageBox.Show("Item Added Successfully");
                }
                else
                {
                    MessageBox.Show("Fail to Add Item");
                }
                txtQuantity.Text = "";
                
            }
            BindGrid();
        }
        void BindGrid()
        {
            DataTable dt = objsaledetails.AddedItemIntoGridView(txtSalesTranNo.Text);
            dgvSales.DataSource = dt;
        }

       
        private void CmbNameS_SelectedIndexChanged(object sender, EventArgs e)
        {
            int CustomerId = Convert.ToInt32(CmbNameS.SelectedValue.ToString());
            DataTable dt = objcust.GetCustomerByName(CustomerId);
            if(dt.Rows.Count>0)
            {
                LblAddress.Text = dt.Rows[0]["CustomerAddress"].ToString();
                LblPhno.Text = dt.Rows[0]["CustomerPhoneNo"].ToString();
            }
        }
        private void CmbItemS_SelectedIndexChanged(object sender, EventArgs e)
        {
            int ItemId = Convert.ToInt32(CmbItemS.SelectedValue.ToString());
            DataTable dt = itm.GetItemById(ItemId);
            if(dt.Rows.Count>0)
            {
                txtPrice.Text = dt.Rows[0]["Rate"].ToString();
            }
        }

        
    }
}
