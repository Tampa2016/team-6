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
    public partial class Search : Form
    {
        public Search()
        {
            InitializeComponent();
        }

        private void btnProfile_Click(object sender, EventArgs e)
        {
            this.Hide();
            profileForm f = new profileForm();
            f.Show();
        }

        private void lblPnts_Click(object sender, EventArgs e)
        {

        }

        private void Search_Load(object sender, EventArgs e)
        {
            List<String> tempList = new List<String>();
            for (int i=0;i<list.listLocations.Count;i++)
            {
                
                if (list.listLocations[i].getLocName().Contains(list.searchString))
                {
                    if (list.typeSearch == 0)
                        tempList.Add(list.listLocations[i].getLocName());
                    else if (list.typeSearch == list.listLocations[i].getType())
                        tempList.Add(list.listLocations[i].getLocName());
                }
            }
            listBox1.DataSource = tempList;
        }

        private void btnView_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedItem!=null)
                for (int i =0;i<list.listLocations.Count;i++)
                {
                    if(list.listLocations[i].getLocName().ToString()==listBox1.SelectedItem.ToString())
                        list.currentLocationIndex = i;
                }
            
            Form4 f = new Form4();
            this.Hide();
            f.Show();

        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            frmMainMenu f = new frmMainMenu();
            this.Hide();
            f.Show();
        }

        private void btnFeature_Click(object sender, EventArgs e)
        {
            Form5 f = new Form5();
            this.Hide();
            f.Show();
        }
    }
}
