using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Coursework_Subsystem_A
{
    public class Person
    {
        string firstName, surname, username, password;
        int id;
        // get and set variables
        public int ID
        {
            get { return id; }
            set { id = value; }
        }
        public string FirstName
        {
            get { return firstName; }
            set { firstName = value; }
        }
        public string Surname
        {
            get { return surname; }
            set { surname = value; }
        }
        public string Username
        {
            get { return username; }
            set { username = value; }
        }
        public string Password
        {
            get { return password; }
            set { password = value; }
        }
    }
}