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


namespace TexolBilling
{
    public partial class Vendor : Form
    {
        public Vendor()
        {
            InitializeComponent();
        }
        AddVendor objvend = new AddVendor();
        private void BtnAdd_Click(object sender, EventArgs e)
        {
            if (Validation())
            {
                int i = objvend.Vendor(txtVname.Text, txtVaddress.Text, txtVcity.Text, txtVstate.Text, txtVzipcode.Text, txtVareacode.Text, txtVphoneno.Text);
                if(i>0)
                {
                    MessageBox.Show("Vendor Added Succesfully");
                }
                else
                {
                    MessageBox.Show("Failed to Vendor Add");
                }
            }
            else
            {
              // lblMessage.Text = "* Please fill the mandatory field";
            }
        }
        public bool Validation()
        {
            bool isValid = true;
            if (txtVname.Text == "")
            {
                errorProvider1.SetError(txtVname, "Please enter the name");
                isValid = false;
            }
            else
            {
                errorProvider1.SetError(txtVname, "");
            }
            if (txtVaddress.Text == "")
            {
                errorProvider2.SetError(txtVaddress, "Please enter the Address");
                isValid = false;
            }
            else
            {
                errorProvider2.SetError(txtVaddress, "");
            }
            if (txtVcity.Text == "")
            {
                errorProvider3.SetError(txtVcity, "Please enter the city");
                isValid = false;
            }
            else
            {
                errorProvider3.SetError(txtVcity, "");
            }
            if (txtVstate.Text == "")
            {
                errorProvider4.SetError(txtVstate, "Please enter the State");
                isValid = false;
            }
            else
            {
                errorProvider4.SetError(txtVstate, "");
            }
            if (txtVzipcode.Text == "")
            {
                errorProvider5.SetError(txtVzipcode, "Please enter the ZipCode");
                isValid = false;
            }
            else
            {
                errorProvider5.SetError(txtVzipcode, "");
            }
            if (txtVareacode.Text == "")
            {
                errorProvider6.SetError(txtVareacode, "Please enter the AreaCode");
                isValid = false;
            }
            else
            {
                errorProvider6.SetError(txtVareacode, "");
            }
            if (txtVphoneno.Text == "")
            {
                errorProvider7.SetError(txtVphoneno, "Please enter the PhoneNo");
                isValid = false;
            }
            else
            {
                errorProvider7.SetError(txtVphoneno, "");
            }
            return isValid;
        }
       
        Validation v = new Validation();
        private void txtVphoneno_KeyPress(object sender, KeyPressEventArgs e)
        {
            v.digitonly(e);
        }

        
        private void BtnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
