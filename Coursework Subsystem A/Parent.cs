using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Coursework_Subsystem_A
{
    public class Parent : Person
    {
        string parentName, postcode, email;
        string activeMembership;
        long telNo;
        
        Child child;

        public int ParentID
        {
            get { return ID; }
            set { ID = value; }
        }
        public string ParentName
        {
            get { return parentName; }
            set { parentName = value; }
        }

        public string Postcode
        {
            get { return postcode; }
            set { postcode = value; }
        }
        public string Email
        {
            get { return email; }
            set { email = value; }
        }

        public string MembershipAdded
        {
            get { return activeMembership; }
            set { activeMembership = value; }
        }
        public long TelNo
        {
            get { return telNo; }
            set { telNo = value; }
        }
        public Child Child
        {
            get { return child; }
            set { child = value; }
        }

        public Parent(int id, string fN, string sN)
        {
            ID = id;
            FirstName = fN;
            Surname = sN;
        }

        // overload methods

        public Parent(int id, string pN)
        {
            ID = id;
            parentName = pN;
        }

        public Parent(int id, string fN, string sN, long tN, string e, string u, string p, string pC, string aM)
        {
            ID = id;
            FirstName = fN;
            Surname = sN;
            telNo = tN;
            email = e;
            Username = u;
            Password = p;
            postcode = p;
            activeMembership = aM;
        }

        public Parent(int id, string fN, string sN, Child c)
        {
            ID = id;
            FirstName = fN;
            Surname = sN;
            Child = c;
        }
        public Parent(int id, Child c)
        {
            ID = id;
            Child = c;
        }
        
    }
}