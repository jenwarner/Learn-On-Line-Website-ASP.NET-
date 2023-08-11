using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Coursework_Subsystem_A
{
    public class Child : Person
    {
        string childName,dob, sex, username, password;
        int cID;
        Parent cParent;

        public int CID
        {
            get { return cID; }
            set { cID = value; }
        }
        public string ChildName
        {
            get { return childName; }
            set { childName = value; }
        }
        public string ChildDoB
        {
            get { return dob; }
            set { dob = value; }
        }
        public string ChildSex
        {
            get { return sex; }
            set { sex = value; }
        }
        public Parent Parent
        {
            get { return cParent; }
            set { cParent = value; }
        }

        public Child(int id, string cN)
        {
            ID = id;
            childName = cN;
        }

        // overload method
        public Child(int id, string fN, string sN, string dOB, string s, string uN, string p)
        {
            ID = id;
            FirstName = fN;
            Surname = sN;
            dob = dOB;
            sex = s;
            username = uN;
            password = p;
        }
        public Child(int id, Parent p)
        {
            ID = id;
            Parent = p;
        }
        public Child(int id, string fN, string sN, int cID, Parent p)
        {
            CID = cID;
            ID = id;
            FirstName = fN;
            Surname = sN;
            Parent = p;
        }
    }
}