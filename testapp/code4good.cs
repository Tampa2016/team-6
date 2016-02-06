using System;
using System.Collections.Generic;

namespace testapp {

    public class Accounts {
        private string user;
        private string password;
        private int points;
        private int likes;
        private int thankyous;
        private int phoneNumber;

        public Accounts(string u, string pw, int pn) {
            this.user = u;
            this.password = pw;
            this.points = 0;
            this.likes = 0;
            this.thankyous = 0;
            this.phoneNumber = pn;
        }

        public int getPhoneNumber() {
            return phoneNumber;
        }

        public int getPoints() {
            return points;
        }

        public void setPoints(int value) {
            this.points = value;
        }

        public int getLikes() {
            return likes;
        }

        public void setLikes(int value) {
            this.likes = value;
        }

        public int getThankyous() {
            return thankyous;
        }

        public void setThankyous(int value) {
            this.thankyous = value;
        }

        public void changePoints(int value) {
            this.setPoints(this.getPoints() + value);
            return;
        }

        public void changeLikes(int value) {
            this.setLikes(this.getLikes() + value);
            return;
        }

        public void changeThankyous(int value) {
            this.setThankyous(this.getThankyous() + value);
            return;
        }
        public string getUser() {
            return user;
        }
        public bool checkPassword(string tmp) {
            if (tmp != this.password)
                return false;
            else
                return true;
        }
    }

    //////////////////////////////////////////////////////////////////
    public class Locations {
        private int type;
        private string locName;
        private double rating;
        private string address;
        private string image;
        private List<Reviews> rev = new List<Reviews>();

        public Locations(int t, string lName, string addr) {
            this.type = t;
            this.locName = lName;
            this.address = addr;
        }
        public void addReview(Reviews r)
        { rev.Add(r); }
        public List<Reviews> getReviews()
        { return rev; }

        public string getLocName() {
            return locName;
        }

        public string getAddress() {
            return address;
        }

        public double getRating() {
            return rating;
        }
        public int getType() { return type; }
    }

    //////////////////////////////////////////////////////////////////
    public class Reviews
    {
        private int likes;
        private bool wheel;
        private bool bath;
        private bool fauc;
        private bool elav;
        //table height
        private int height;
        //door width
        private int width;
        private double rate;
        private string review;

       
        public Reviews(bool w, bool b, bool f, bool e, 
            int hei, int wid ,double r, string message)
        {
            wheel = w;
            bath = b;
            fauc = f;
            elav = e;
            height = hei;
            width = wid;
            rate = r;
            review =     message;
            likes = 0;
        }
        public bool getWheel() { return wheel; }
        public bool getBath() { return bath; }
        public bool getFaucet() { return fauc; }
        public bool getElev() { return elav; }
        public int getHeight() { return height; }
        public int getWidth() { return width; }
        public double getRating() { return rate; }
        public string displayReview() { return review; }

        public void incrementLikes()
        {
            this.likes++;
        }
    }
    //container to hold global vars
    public static class list
    {
        public static List<Accounts> listAccounts=new List<Accounts>();
        public static List<Locations> listLocations = new List<Locations>();
        public static int accountIndex;
        public static int currentLocationIndex;
        public static int typeSearch;
        public static string searchString;

    }
    
    
}

