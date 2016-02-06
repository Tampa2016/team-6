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

        public bool checkPassword(string tmp) {
            if (tmp != this.password)
                return false;
            else
                return true;
        }
    }

    //////////////////////////////////////////////////////////////////
    public class Locations {
        private string locName;
        private double rating;
        private string address;
        private string image;

        public Locations(string lName, string addr, double rate) {
            this.locName = lName;
            this.address = addr;
            this.rating = rate;
        }

        public string getLocName() {
            return locName;
        }

        public string getAddress() {
            return address;
        }

        public double getRating() {
            return rating;
        }
    }

    //////////////////////////////////////////////////////////////////
    public class Reviews {
        private string review;
        private string author;
        private int likes;

        public void addReview(string r, string username) {
            this.review = r;
            this.author = username;
            this.likes = 0;
        }

        public string displayReview() {
            return review;
        }

        public void incrementLikes() {
            this.likes++;
        }

        public string displayAuthor() {
            return author;
        }
    }

    public static class list
    {
        public static List<Accounts> listAccounts=new List<Accounts>();
    }
    
}/*
    //dataset for Accounts 		public Accounts(string u, string pw, int p, int l, int ty, string pn){
    List<Accounts> listAccounts = new List<Accounts>();
    Accounts listAccounts = new Accounts()*/


