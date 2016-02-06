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

    public partial class Form4 : Form
    {

        public Form4()
        {
            InitializeComponent();

          
        }
        //shows home screen
        private void btnHome_Click(object sender, EventArgs e)
        {
            frmMainMenu f = new frmMainMenu();
            this.Hide();
            f.Show();
        }
        //shows featured screen
        private void btnFeatured_Click(object sender, EventArgs e)
        {
            Form5 f = new Form5();
            this.Hide();
            f.Show();
        }
        //shows profile screen
        private void btnProfile_Click(object sender, EventArgs e)
        {
            this.Hide();
            profileForm f = new profileForm();
            f.Show();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            this.Hide();
            Review f = new Review();
            f.Show();

        }

        private void Form4_Load(object sender, EventArgs e)
        {
            List<String> t = new List<String>();
            for (int i=0;i<list.listLocations[list.currentLocationIndex].getReviews().Count;i++)
            {
                Reviews r= list.listLocations[list.currentLocationIndex].getReviews()[i];
                t.Add(
                    "Wheel " + r.getWheel().ToString()+ 
                    " Bath " + r.getBath().ToString()+
                    " Fauc " + r.getFaucet().ToString()+
                    " Ele "  + r.getElev().ToString()+
                    " Height " + r.getHeight().ToString()+
                    " Width " + r.getWidth().ToString()+
                    " Rated " + r.getRating().ToString()+
                    " Message" + r.displayReview());
            }
            listBox1.DataSource = t;
            
        }

        
        
    }
}
