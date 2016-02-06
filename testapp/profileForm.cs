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
    public partial class profileForm : Form
    {
        public profileForm()
        {
            InitializeComponent();
            label5.Text = list.listAccounts[list.accountIndex].getUser();
            label6.Text = list.listAccounts[list.accountIndex].getPoints().ToString();
            label7.Text = list.listAccounts[list.accountIndex].getPhoneNumber().ToString();
        }
        //shows thank you notes page
        private void button2_Click(object sender, EventArgs e)
        {
            
        }
        //shows prize info page
        private void button3_Click(object sender, EventArgs e)
        {
            prizeInfo f = new prizeInfo();
            this.Hide();
            f.Show();
        }
        //displays featured page
        private void button5_Click(object sender, EventArgs e)
        {
            Form5 f = new Form5();
            this.Hide();
            f.Show();
        }
        //displays main menu
        private void btnHome_Click(object sender, EventArgs e)
        {
            frmMainMenu f = new frmMainMenu();
            this.Hide();
            f.Show();
        }
    }

    public class surveyResults
    {

    }
}
