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

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {

        }

        AddCustomer objcust = new AddCustomer();
        private void BtnAddCustomer_Click(object sender, EventArgs e)
        {
            if (Validation())
            {
                int i = objcust.Customer(Convert.ToInt32(txtCnumber.Text), txtClastname.Text, txtCfirstname.Text, txtCaddress.Text, txtCcity.Text, txtCstate.Text, txtCzipcode.Text, txtCareacode.Text, txtCphoneno.Text);
                if(i>0)
                {
                    MessageBox.Show("Customer Added Successfully");
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
        public bool Validation()
        {
            bool isValid = true;
            if (txtCnumber.Text == "")
            {
                errorProvider1.SetError(txtCnumber, "Please enter the Number");
                isValid = false;
            }
            else
            {
                errorProvider1.SetError(txtCnumber, "");
            }
            if (txtClastname.Text == "")
            {
                errorProvider2.SetError(txtClastname, "Please enter the LastName");
                isValid = false;
            }
            else
            {
                errorProvider2.SetError(txtClastname, "");
            }
            if (txtCfirstname.Text == "")
            {
                errorProvider3.SetError(txtCfirstname, "Please enter the FirstName");
                isValid = false;
            }
            else
            {
                errorProvider3.SetError(txtCfirstname, "");
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
            if (txtCcity.Text == "")
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
            }
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

        private void txtCzipcode_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch= e.KeyChar;
            if(!char.IsDigit(ch) && ch!=8 && ch!=46)
            {
                e.Handled = true;
                MessageBox.Show("Enter only digit and decimel.", "Alert!");
            }
        }
        Validation v = new Validation();

        private void txtCcity_KeyPress(object sender, KeyPressEventArgs e)
        {
            v.charonly(e);
        }

        private void txtCnumber_KeyPress(object sender, KeyPressEventArgs e)
        {
            v.digitonly(e);
        }

        private void txtCphoneno_KeyPress(object sender, KeyPressEventArgs e)
        {
            v.digitonly(e);
        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
