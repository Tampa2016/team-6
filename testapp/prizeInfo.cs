using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace testapp
{
    public partial class prizeInfo : Form
    {
        public prizeInfo()
        {
            InitializeComponent();
            label1.Text = list.listAccounts[list.accountIndex].getPoints() + " points";

        }
        //show profile page
        private void button3_Click(object sender, EventArgs e)
        {
            profileForm f = new profileForm();
            this.Hide();
            f.Show();           
        }
        //show featured page
        private void button2_Click(object sender, EventArgs e)
        {
            /*Form4 f = new Form4();
            this.Hide();
            f.Show();*/
        }
        //display home page
        private void button1_Click(object sender, EventArgs e)
        {
            frmMainMenu f = new frmMainMenu();
            this.Hide();
            f.Show();
        }
    }
}
