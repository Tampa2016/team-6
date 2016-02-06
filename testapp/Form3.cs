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
            lblPoints.Text = "Points: " + list.listAccounts[list.accountIndex].getPoints();

            //LOADING PREDEFINED LIST OF SAMPLE Locations AND REVIEWS

        //    Resturants = 1
            Locations x1 = new Locations(1, "IHOP", "1123 Pancake Way");
            
            Locations x2 = new Locations(1, "Applebees", "1243 Apple Rd");
            Locations x3 = new Locations(1, "Taco Bell", "5443 Lynn Rd");
            Locations x4 = new Locations(1, "Chilli's", "6655 Henry dr");
            Locations x5 = new Locations(1, "Mama's Pizza", "8723 Martin st");
            Locations x6 = new Locations(1, "Nam's Kitchen", "5547 Lily Rd");
            Locations x7 = new Locations(1, "Deli Diner", "9888 Rich Rd");
            Locations x8 = new Locations(1, "Kaitlin's Tacos", "8775 Bulls St");
            Locations x9 = new Locations(1, "Rahul Dining", "5576 Pepper Highway");
            Locations x10 = new Locations(1, "Italian House", "7744 Morgan Rd");

          //  Hotels = 2
            Locations x11 = new Locations(2, "Holiday Inn", "6655 Holly Rd");
            Locations x12 = new Locations(2, "Tampa Marriot", "7765 Tampa St");
            Locations x13 = new Locations(2, "Floridan Palace", "8856 Henry HighWay");
            Locations x14 = new Locations(2, "Le Meridien Tampa", "5555 Chase Rd");
            Locations x15 = new Locations(2, "Embassy Suites Tampa", "8798 Lincoln Rd");
            Locations x16 = new Locations(2, "Hilton Tampa Bay", "8833 High HighWay");
            Locations x17 = new Locations(2, "Sheraton Tampa", "1111 Range Rd");
            Locations x18 = new Locations(2, "Aloft Downtwon", "4332 Paul Rd");
            Locations x19 = new Locations(2, "The Westin", "7765 Tommy Dr");
            Locations x20 = new Locations(2, "Rodeway Inn", "7775 Code Rd");

           // Activities = 3
            Locations x21 = new Locations(3, "MOSI", "7773 Yellow Dr");
            Locations x22 = new Locations(3, "Children's Museum", "5555 Highway St");
            Locations x23 = new Locations(3, "AirHeads Trampolines", "7773 Momma Dr");
            Locations x24 = new Locations(3, "IKEA", "6655 Morgan St");
            Locations x25 = new Locations(3, "The Florida Aquarium", "7676 Lincoln Rd");
            Locations x26 = new Locations(3, "Egypt Shriners", "8433 Real Rd");
            Locations x27 = new Locations(3, "Tampa History Center", "5445 Main St");
            Locations x28 = new Locations(3, "Tampa Bowling", "6656 Low Rd");
            Locations x29 = new Locations(3, "Tampa Yacht Club", "7865 Second St");
            Locations x30 = new Locations(3, "Movico 24", "7975 Third St");

            list.listLocations.Add(x1);
            list.listLocations.Add(x2);
            list.listLocations.Add(x3);
            list.listLocations.Add(x4);
            list.listLocations.Add(x5);
            list.listLocations.Add(x6);
            list.listLocations.Add(x7);
            list.listLocations.Add(x8);
            list.listLocations.Add(x9);
            list.listLocations.Add(x10);
            list.listLocations.Add(x11);
            list.listLocations.Add(x12);
            list.listLocations.Add(x13);
            list.listLocations.Add(x14);
            list.listLocations.Add(x15);
            list.listLocations.Add(x16);
            list.listLocations.Add(x17);
            list.listLocations.Add(x18);
            list.listLocations.Add(x19);
            list.listLocations.Add(x20);
            list.listLocations.Add(x21);
            list.listLocations.Add(x22);
            list.listLocations.Add(x23);
            list.listLocations.Add(x24);
            list.listLocations.Add(x25);
            list.listLocations.Add(x26);
            list.listLocations.Add(x27);
            list.listLocations.Add(x28);
            list.listLocations.Add(x29);
            list.listLocations.Add(x30);




            Reviews a = new Reviews(true, false, true, true,
                        1, 1, 3, "THIS PLACE IS AWESOME");
            Reviews b = new Reviews(true, true, true, true,
                        3, 2, 4, "");
            Reviews c = new Reviews(false, false, false, true,
                        2, 2, 2, "Easy Accessibility!");
            Reviews d = new Reviews(true, false, true, false,
                        1, 1, 5, "So Helpful with my wheelchair!");
            Reviews e1 = new Reviews(true, true, true, true,
                        2, 1, 4, "");
            Reviews f = new Reviews(false, false, true, true,
                        1, 2, 2, "I was unable to enter the front door");
            Reviews g = new Reviews(true, true, false, true,
                        3, 1, 2, "");
            Reviews h = new Reviews(false, false, true, true,
                        1, 1, 1, "");
            Reviews i = new Reviews(true, false, false, false,
                        1, 2, 3, "I love this place! They were really helpful!");
            Reviews j = new Reviews(true, true, true, true,
                        3, 2, 4, "");
            Reviews k = new Reviews(false, false, true, true,
                        2, 1, 5, "Easy!");
            Reviews l = new Reviews(true, false, true, false,
                        2, 2, 5, "");
            Reviews m = new Reviews(false, false, true, true,
                        2, 2, 1, "I could not get through the lobby, too busy and staff did not help.");
            Reviews n = new Reviews(true, false, false, true,
                        1, 2, 3, "Not very helpful with my chair.");
            Reviews o = new Reviews(true, false, true, true,
                        1, 2, 4, "This place was amazing! My husband and I had a great experience!");
            Reviews p = new Reviews(true, false, true, false,
                        1, 1, 2, "I noticed there was a wheelchair ramp with handlebars.");
            Reviews q = new Reviews(true, false, false, true,
                        3, 1, 3, "");
            Reviews r = new Reviews(true, true, true, true,
                        3, 2, 5, "The staff was very knowlegable on accessibility");
            Reviews s = new Reviews(false, false, true, true,
                        2, 1, 3, "");
            Reviews t = new Reviews(true, false, true, true,
                        2, 2, 2, "I could not reach the sink.");
            Reviews u = new Reviews(false, false, true, true,
                        3, 2, 1, "The mirror was too high for the handicap bathroom.");
            Reviews v = new Reviews(true, false, true, true,
                        2, 2, 1, "");
            Reviews w = new Reviews(true, false, true, true,
                        2, 1, 4, "I Love this place! Everything was so easy to access!");
            Reviews x = new Reviews(true, false, true, false,
                        1, 1, 4, "My best friend, who is in a wheelchair had a hard time getting around the people. ");
            Reviews y = new Reviews(true, false, false, true,
                        1, 2, 5, "I did not find the staff helpfull.");
            Reviews z = new Reviews(true, true, true, true,
                        1, 1, 5, "");
            Reviews aa = new Reviews(false, false, true, true,
                        2, 2, 2, "Great Place for disabled individuals.");
            Reviews ab = new Reviews(true, false, true, false,
                        3, 1, 2, "");
            Reviews ac = new Reviews(true, false, true, true,
                        1, 2, 3, "I had a hard time reaching the sink.");
            Reviews ad = new Reviews(false, false, false, true,
                        1, 1, 3, "");

            list.listLocations[0].addReview(a);
            list.listLocations[0].addReview(b);
            list.listLocations[2].addReview(c);
            list.listLocations[2].addReview(d);
            list.listLocations[2].addReview(e1);
            list.listLocations[3].addReview(f);
            list.listLocations[4].addReview(g);
            list.listLocations[6].addReview(h);
            list.listLocations[6].addReview(i);
            list.listLocations[8].addReview(j);
            list.listLocations[10].addReview(k);
            list.listLocations[11].addReview(l);
            list.listLocations[11].addReview(m);
            list.listLocations[20].addReview(n);
            list.listLocations[21].addReview(o);
            list.listLocations[23].addReview(p);
            list.listLocations[24].addReview(r);
            list.listLocations[22].addReview(s);
            list.listLocations[28].addReview(t);
            list.listLocations[1].addReview(u);
            list.listLocations[3].addReview(v);
            list.listLocations[24].addReview(w);
            list.listLocations[15].addReview(x);
            list.listLocations[19].addReview(y);
            list.listLocations[10].addReview(z);
            list.listLocations[20].addReview(aa);
            list.listLocations[21].addReview(ab);
            list.listLocations[25].addReview(ac);
            list.listLocations[26].addReview(ad);

        }


        //this button loads up the profile
        private void btnProfile_Click(object sender, EventArgs e)
        {
            this.Hide();
            profileForm f = new profileForm();
            f.Show();
        }
        //searches entire entire db
        private void btnAll_Click(object sender, EventArgs e)
        {
            list.typeSearch = 0;
            list.searchString = textBox1.Text;
            this.Hide();
            Search f = new Search();
            f.Show();
        }
        //searches db for restaurants
        private void btnRest_Click(object sender, EventArgs e)
        {
            list.typeSearch = 1;
            list.searchString = textBox1.Text;
            this.Hide();
            Search f = new Search();
            f.Show();
        }
        //searches db for hotel
        private void btnHotel_Click(object sender, EventArgs e)
        {
            list.typeSearch = 2;
            list.searchString = textBox1.Text;
            this.Hide();
            Search f = new Search();
            f.Show();
        }
        //searches db for activities
        private void btnAct_Click(object sender, EventArgs e)
        {
            list.typeSearch = 3;
            list.searchString = textBox1.Text;
            this.Hide();
            Search f = new Search();
            f.Show();
        }
        //display featured tab
        private void button2_Click(object sender, EventArgs e)
        {
            Form5 f = new Form5();
            list.searchString = textBox1.Text;
            this.Hide();
            f.Show();
        }
    }
}
