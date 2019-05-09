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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void addItemToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ItemAdd objItem = new ItemAdd();
            objItem.Show();
        }
    }
}
