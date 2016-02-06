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
    public partial class Review : Form
    {
        public Review()
        {
            InitializeComponent();
            //label4.Text = list.listAccounts[accountIndex].getPoints() + " points";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmMainMenu f = new frmMainMenu();
            this.Hide();
            f.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            profileForm f = new profileForm();
            this.Hide();
            f.Show();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            int temp, temp2;
            if (radHeight1.Checked) temp = 1;
            else if (radHeight2.Checked) temp = 2;
            else temp = 3;
            if (radWidth1.Checked)temp2 = 1;
            else temp2 = 2;


            Reviews r = new Reviews(
                checkBox1.Checked, checkBox2.Checked,
                checkBox3.Checked, checkBox4.Checked,
                temp, temp2, Double.Parse(comboBox1.Text), textBox1.Text);
            list.listLocations[list.currentLocationIndex].addReview(r);
        }
        
    }
}
