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
            try
            {
                if (Validation())
                {
                    label6.Text = dgvSales.Rows.Count.ToString();
                    if (Convert.ToInt32(label6.Text)>1)
                    {
                        int i = objsaledetails.InsertDataToSalesTbl(txtSalesTranNo.Text, datetimepicker2.Value.Date, Convert.ToInt32(CmbNameS.SelectedValue.ToString()),Convert.ToDecimal(LblTax.Text), Convert.ToDecimal(lblTotal.Text),Convert.ToDecimal(LblSubTotal.Text));
                        if (i > 0)
                        {
                            MessageBox.Show(" Saved Succesfully");
                            SalesInvoiceReport objSReport = new SalesInvoiceReport();
                             objSReport.LblSalesTrno.Text = txtSalesTranNo.Text;
                             objSReport.LblTotalAmount.Text =lblTotal.Text;
                             objSReport.LblTaxAmount.Text = LblTax.Text;
                             objSReport.LblSubTotal.Text = LblSubTotal.Text;
                            objSReport.Show();
                            clear();
                            foreach (Form f in Application.OpenForms)
                            {
                                if (f is SalesInvoiceReport)
                                {
                                    f.Focus();
                                    return;
                                }
                            }
                            objSReport.MdiParent = this;
                            

                        }
                        else
                        {
                            MessageBox.Show("Saving Failed");
                        }
                        
                    }
                    else
                    {
                        MessageBox.Show("Please Add the items");
                    }
                }
                else
                {
                    MessageBox.Show("Please fill all the fields");
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
            txtSalesTranNo.Text = objcmn.GenerateSaleTransaction();
            BindGrid();
            txtPrice.Text = "0";
            txtQuantity.Text = "0";
            lblTotal.Text = "0";
            LblTax.Text = "0";
            LblSubTotal.Text = "0";
            LblAddress.Text = "Address";
            LblPhno.Text = "ContactNo";
            CmbNameS.Text = "select CustomerName";
            CmbItemS.Text = "select Item";
            CmbPayMet.Text = "--select payment--";
            

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
            if (CmbPayMet.SelectedItem == null)
            {
                errorProvider3.SetError(CmbPayMet, "Please select the Payment Method");
                isValid = false;
            }
            else
            {
                errorProvider3.SetError(CmbPayMet, "");
            }
            if (CmbNameS.SelectedValue.ToString() =="0")
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
           // label1.Text = dgvSales.Rows.Count.ToString();
            CmbItemS.Items.Insert(0, "---Select--");
            CommonFunctions objcmn = new CommonFunctions();
            txtSalesTranNo.Text = objcmn.GenerateSaleTransaction();
            Customers cust = new Customers();
            DataTable dt = cust.GetAllCustomers();
            DataRow row = dt.NewRow();
            row["CustomerId"] = 0;
            row["CustomerName"] = "--Select Cust--";
            dt.Rows.InsertAt(row,0);
            CmbNameS.DisplayMember = "CustomerName";
            CmbNameS.ValueMember = "CustomerId";
            CmbNameS.DataSource = dt;
            Item itm = new Item();
            DataTable dt1 = itm.GetAllItem();
            DataRow row1 = dt1.NewRow();
            row1["ItemId"] = 0;
            row1["ItemName"] = "--Select Item--";
            dt1.Rows.InsertAt(row1, 0);
            CmbItemS.DisplayMember = "ItemName";
            CmbItemS.ValueMember = "ItemId";
            CmbItemS.DataSource = dt1;
            
        }
        public void CalculateTax()
        {
            decimal tax= ((Convert.ToDecimal(lblTotal.Text) * Convert.ToDecimal(txtTax.Text) / 100));
            LblTax.Text = tax.ToString();
            decimal subtotal = (Convert.ToDecimal(lblTotal.Text) + Convert.ToDecimal(LblTax.Text));
            LblSubTotal.Text =subtotal .ToString();
        }
        private void BtnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                

                int ItemId1 = Convert.ToInt32(CmbItemS.SelectedValue.ToString());
                DataTable dt = itm.GetItemById(ItemId1);
                if (dt.Rows.Count > 0)
                {
                    Lblmsg.Text = dt.Rows[0]["Quantity"].ToString();
                }
                
                if (Convert.ToInt32( txtQuantity.Text)<= Convert.ToInt32(Lblmsg.Text))
                {

                    decimal totalvalue = ((Convert.ToDecimal(lblTotal.Text) + Convert.ToDecimal(txtPrice.Text) * Convert.ToInt32(txtQuantity.Text)));


                    lblTotal.Text = totalvalue.ToString();
                    CalculateTax();
                    string SaleTrNo = txtSalesTranNo.Text;
                    int ItemId = Convert.ToInt32(CmbItemS.SelectedValue.ToString());
                    if (objsaledetails.CheckIfSalesItemAlreadyInsert(SaleTrNo, ItemId))
                    {
                        int i = objsaledetails.UpdateSalesItem(txtSalesTranNo.Text, Convert.ToInt32(CmbItemS.SelectedValue.ToString()), Convert.ToInt32(txtQuantity.Text));
                        int j = itm.UpdateSalesQuantity(Convert.ToInt32(ItemId), Convert.ToInt32(txtQuantity.Text));
                    }
                    else
                    {
                       
                        int i = objsaledetails.InsertSalesItem(txtSalesTranNo.Text, Convert.ToInt32(CmbItemS.SelectedValue.ToString()), Convert.ToDecimal(txtPrice.Text), Convert.ToInt32(txtQuantity.Text));
                        int j = itm.UpdateSalesQuantity(Convert.ToInt32(ItemId), Convert.ToInt32(txtQuantity.Text));
                    }
                }
                else
                {
                    MessageBox.Show("Out of stock");
                }
                txtQuantity.Text = "";
                BindGrid();

            }
            catch(Exception ex)
            {
                MessageBox.Show("Errror" + ex.Message);
            }
             

        }
        void BindGrid()
        {
            try
            {
                DataTable dt = objsaledetails.AddedItemIntoGridView(txtSalesTranNo.Text);
                dgvSales.DataSource = dt;
               
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error" + ex.Message);
            }
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
        private void txtTax_TextChanged(object sender, EventArgs e)
        {
            CalculateTax();
        }
    }
}
