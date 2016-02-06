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
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
            //label2.Text = list.accountIndex.getPoints().ToString();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmMainMenu f = new frmMainMenu();
            this.Hide();
            f.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            profileForm f = new profileForm();
            this.Hide();
            f.Show();
        }
    }
}
