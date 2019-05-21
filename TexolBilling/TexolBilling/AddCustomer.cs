using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Validation;
using TexolBilling.BAL;

namespace TexolBilling
{
    public partial class Customer : Form
    {

        public Customer()
        {
            InitializeComponent();
        }
        Customers objcust = new Customers();
        Validation v = new Validation();
        private void BtnAddCustomer_Click(object sender, EventArgs e)
        {

            if (Validation())
            {
                int i = objcust.InsertCustomer( txtCname.Text, txtCaddress.Text, txtCcity.Text, txtCstate.Text, txtCzipcode.Text, txtCareacode.Text, txtCphoneno.Text);

                if (i > 0)
                {
                    MessageBox.Show("Customer Added Successfully");
                    clear();
                }
                else
                {
                    MessageBox.Show("Fail to Add Customer");
                }
            }
            else
            {
                lblMessage.Text = "Please fill the required field";
            }
        }
        public void clear()
        {
           
            txtCname.Text = "";
            txtCcity.Text = "";
            txtCaddress.Text = "";
            txtCareacode.Text = "";
            txtCphoneno.Text = "";
            txtCzipcode.Text = "";
            txtCstate.Text = "";
        }
        public bool Validation()
        {
            bool isValid = true;
            
            if (txtCname.Text == "")
            {
                errorProvider2.SetError(txtCname, "Please enter Your Name");
                isValid = false;
            }
            else
            {
                errorProvider2.SetError(txtCname, "");
            }

            if (txtCaddress.Text == "")
            {
                errorProvider4.SetError(txtCaddress, "Please enter the Address");
                isValid = false;
            }
            else
            {
                errorProvider4.SetError(txtCaddress, "");
            }
            /*if (txtCcity.Text == "")
            {
                errorProvider5.SetError(txtCcity, "Please enter the City");
                isValid = false;
            }
            else
            {
                errorProvider5.SetError(txtCcity, "");
            }
            if (txtCstate.Text == "")
            {
                errorProvider6.SetError(txtCstate, "Please enter the State");
                isValid = false;
            }
            else
            {
                errorProvider6.SetError(txtCstate, "");
            }*/
            if (txtCzipcode.Text == "")
            {
                errorProvider7.SetError(txtCzipcode, "Please enter the ZipCode");
                isValid = false;
            }
            else
            {
                errorProvider7.SetError(txtCzipcode, "");
            }
            if (txtCareacode.Text == "")
            {
                errorProvider8.SetError(txtCareacode, "Please enter the AreaCode");
                isValid = false;
            }
            else
            {
                errorProvider8.SetError(txtCareacode, "");
            }
            if (txtCphoneno.Text == "")
            {
                errorProvider8.SetError(txtCphoneno, "Please enter the PhoneNo");
                isValid = false;
            }
            else
            {
                errorProvider8.SetError(txtCphoneno, "");
            }
            return isValid;
        }

       /* private void txtCzipcode_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (!char.IsDigit(ch) && ch != 8 && ch != 46)
            {
                e.Handled = true;
                MessageBox.Show("Enter only digit and decimel.", "Alert!");
            }
        }*/
       
        private void txtCcity_KeyPress(object sender, KeyPressEventArgs e)
        {
            v.charonly(e);
        }

       

       

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtCphoneno_KeyPress(object sender, KeyPressEventArgs e)
        {
            v.digitonly(e);
        }
    }
}

