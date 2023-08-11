using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Coursework_Subsystem_A
{
    public class Address
    {
        int ID, houseNumber, pID;
        string houseName, streetName, city, postcode, country;

        Parent parent;
        public int AddressID
        {
            get { return ID; }
            set { ID = value; }
        }
        public int PID
        {
            get { return pID; }
            set { pID = value; }
        }
        public int HouseNumber
        {
            get { return houseNumber; }
            set { houseNumber = value; }
        }
        public string HouseName
        {
            get { return houseName; }
            set { houseName = value; }
        }
        public string StreetName
        {
            get { return streetName; }
            set { streetName = value; }
        }
        public string City
        {
            get { return city; }
            set { city = value; }
        }
        public string Postcode
        {
            get { return postcode; }
            set { postcode = value; }
        }
        public string Country
        {
            get { return country; }
            set { country = value; }
        }
        public Parent Parent
        {
            get { return parent; }
            set { parent = value; }
        }
        public Address(int id, string hN, int hNo, string sN, string c, string p, string co, int pid, Parent pt)
        {
            ID = id;
            houseName = hN;
            houseNumber = hNo;
            streetName = sN;
            city = c;
            postcode = p;
            country = co;
            pID = pid;
            Parent = pt;
        }
        public Address(string hN, int hNo, string sN, string c, string p, string co, Parent pt)
        {
            houseName = hN;
            houseNumber = hNo;
            streetName = sN;
            city = c;
            postcode = p;
            country = co;
            Parent = pt;
        }
    }
}