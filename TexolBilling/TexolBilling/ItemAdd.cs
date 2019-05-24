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
    
    
    public partial class ItemAdd : Form
    {
        public ItemAdd()
        {
            InitializeComponent();
        }
        Item objitem = new Item();
        private void BtnAdd_Click(object sender, EventArgs e)
        {
            if (Validation())
            {
               
                int i = objitem.ItemAdd(TxtItemName.Text, Convert.ToInt32(TxtQuantity.Text), Convert.ToInt32(TxtRate.Text));
                if(i>0)
                {
                    MessageBox.Show("Item Added Successfully");
                    clear();
                }
                else
                {
                    MessageBox.Show("Failed to Add Item");
                }
                
            }
            else
            {
                //
            }
           
        }
        public void clear()
        {
            TxtItemName.Text = "";
            TxtQuantity.Text = "";
            TxtRate.Text = "";
        }
        public bool Validation()
        {
            bool isValid = true;
            if (TxtItemName.Text == "")
            {
                errorProvider1.SetError(TxtItemName, "please add the item name");
                isValid = false;
            }
            else
            {
                errorProvider1.SetError(TxtItemName, "");
            }
            if (TxtQuantity.Text == " ")
            {
                errorProvider2.SetError(TxtQuantity, "pls type the Quantity");
                isValid = false;
            }
            else
            {
                errorProvider2.SetError(TxtQuantity, "");
            }
            if (TxtRate.Text == "")
            {
                errorProvider3.SetError(TxtRate, "Please enter the rate of the item");
                isValid = false;
            }
            else
            {
                errorProvider3.SetError(TxtRate, "");
            }
            return isValid;
        }

        private void TxtRate_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(!(char.IsDigit(e.KeyChar)||char.IsControl(e.KeyChar)))
            {
                e.Handled = true;
                MessageBox.Show("Please enter the digits only");
            }
        }

        private void TxtQuantity_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsDigit(e.KeyChar)))
            {
                e.Handled = true;
                MessageBox.Show("Please enter the digits only");
            }
        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ItemAdd_Load(object sender, EventArgs e)
        {

        }
    }
}
