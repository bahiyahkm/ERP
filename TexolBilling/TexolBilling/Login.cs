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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void TxtPassword_TextChanged(object sender, EventArgs e)
        {

        }

        private void BtnSignIn_Click(object sender, EventArgs e)
        {
            if (Validation())
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
            if (TxtUserName.Text == "")
            {
                errorProvider1.SetError(TxtUserName, "Please enter the UserName");
                isValid = false;

            }
            else
            {
                errorProvider1.SetError(TxtUserName, "");
            }
            if (TxtPassword.Text == "")
            {
                errorProvider2.SetError(TxtPassword, "Please enter the Password");
                isValid = false;
            }
            else
            {
                errorProvider2.SetError(TxtPassword, "");
            }
            return isValid;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
