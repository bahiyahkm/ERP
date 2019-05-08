using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TexolBilling
{
    public partial class ItemAdd : Form
    {
        public ItemAdd()
        {
            InitializeComponent();
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            if (TxtItemName.Text == "")
            {
                errorProvider1.SetError(TxtItemName, "please add the item name");
            }
            else
            {
                errorProvider1.SetError(TxtItemName, "");
            }
            if(TxtQuantity.Text=="")
            {
                errorProvider2.SetError(TxtQuantity, "pls type the Quantity");
            }
            else
            {
                errorProvider2.SetError(TxtQuantity, "");
            }
            if(TxtRate.Text=="")
            {
                errorProvider3.SetError(TxtRate, "Please enter the rate of the item");
            }
            else
            {
                errorProvider3.SetError(TxtRate, "");
            }
        }
    }
}
