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
    public partial class Login : Form
    {
        Account objaccount = new Account();
        public Login()
        {
            InitializeComponent();
        }
        Validation v = new Validation();
        private void BtnSignIn_Click(object sender, EventArgs e)
        {
            if (Validation())
            {
                DataTable dt = new DataTable();
                dt = objaccount.Login(TxtUserName.Text, TxtPassword.Text);
                if (dt.Rows.Count > 0)
                {
                  Biilling_System objHome = new Biilling_System();
                    objHome.Show();
                    this.Hide();
                    TxtUserName.Text = " ";
                    TxtPassword.Text = "";
                }
                else
                {
                    MessageBox.Show("Login Failed");
                }
            }
            else
            {
               
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

        private void TxtUserName_KeyPress(object sender, KeyPressEventArgs e)
        {
            v.charonly(e);
        }

        private void TxtUserName_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
