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
    public partial class frmLogOnChoice : Form
    {
        public frmLogOnChoice()
        {
            InitializeComponent();
        }

        //Facebook button
        private void btnFB_Click(object sender, EventArgs e)
        {
            btnFB.Text = "FB test";
        }

        //Create an account button 
        //When clicked the frmLogOnUser opens
        private void btnCreate_Click(object sender, EventArgs e)
        {
            btnCreate.Text = "create test";
            this.Hide();
            frmLogOnUser f2 = new frmLogOnUser();
            f2.Show();
        }
    }
}
