using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication2
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
            //label1.Text = list.listAccounts[accountIndex].getPoints() + " points";

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form1 f = new Form1();
            this.Hide();
            f.Show();           
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form4 f = new Form4();
            this.Hide();
            f.Show();
        }
    }
}
