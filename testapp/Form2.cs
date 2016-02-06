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
   

    public partial class frmLogOnUser : Form
    {
       
        public frmLogOnUser()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {
        }
        
        private void btnMake_Click(object sender, EventArgs e)
        {
            if(txtPass.Text==txtPassConf.Text)
            {
                Accounts a = new Accounts(txtUser.Text, txtPass.Text, Int32.Parse(txtPhone.Text));
                list.listAccounts.Add(a);
                //traverse list to get index of new account
                for (int i =0;i<list.listAccounts.Count;i++)
                {
                    if (list.listAccounts[i].getUser() == a.getUser())
                    {
                        list.accountIndex = i;
                    }
                }

                //After account is created the main menu appears
                this.Hide();
                frmMainMenu f2 = new frmMainMenu();
                f2.Show();

            }

        }
    }
}
