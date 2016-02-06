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
    public partial class frmMainMenu : Form
    {
        public frmMainMenu()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            list.listAccounts[list.accountIndex].setPoints(50);
            lblPoints.Text = "Points: " + list.listAccounts[list.accountIndex].getPoints();
        }
    }
}
