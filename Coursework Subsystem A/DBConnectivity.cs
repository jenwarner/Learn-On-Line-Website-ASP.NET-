using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.OleDb;
using System.IO;

namespace Coursework_Subsystem_A
{
    public class DBConnectivity
    {
        //Int32 x = 0;
        private static OleDbConnection GetConnection()
        {
            string connString;
            //  change to your connection string in the following line
            // change provider for each computer
            //connString = @"Provider=Microsoft.JET.OLEDB.4.0;Data Source=C:\Users\jenz_\Documents\Uni Projects\Coursework Subsystem A\LolUsers.mdb";
            connString = @"Provider=Microsoft.JET.OLEDB.4.0; Data Source=LolUsers.mdb; Persist Security Info=False;";
            return new OleDbConnection(connString);
        }
        // find parent id from username session
        public static string FindParentNameWithUsername(string uN)
        {
            string name;
            OleDbConnection myConnection = GetConnection();
            string myQuery = "SELECT Parent.ID FROM Parent WHERE userName = '" +uN + "'";
            OleDbCommand myCommand = new OleDbCommand(myQuery, myConnection);
            try
            {
                myConnection.Open();
                int x = int.Parse(myCommand.ExecuteScalar().ToString());

                string myQuery2 = "SELECT firstName + ' ' + surname as parentName FROM Parent WHERE ID = " + x;
                OleDbCommand myCommand2 = new OleDbCommand(myQuery2, myConnection);
                name = myCommand2.ExecuteScalar().ToString();
                //nameLbl.Text = name; 
                return name;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Exception in DBHandler", ex);
                //Response.Write(ex.ToString());
                ///return ex;
                Console.WriteLine(ex.ToString());
                return null;
            }
            finally
            {
                myConnection.Close();
            }
        }

        // add parent address into database
        public static string AddParentAddress(string uN, string hN, string hNO, string sN, string c, string p, string con)
        {
            OleDbConnection myConnection = GetConnection();
            //first find parent id
            string findParentQuery = "SELECT Parent.ID FROM Parent WHERE userName = '" + uN + "'";
            OleDbCommand myFindCommand = new OleDbCommand(findParentQuery, myConnection);
            try
            {
                myConnection.Open();
                int parentID = int.Parse(myFindCommand.ExecuteScalar().ToString());
                // insert address with parent id
                string myAddressQuery = "INSERT INTO Address ([houseName],[houseNumber],[streetName],[city],[postcode],[country],[pID]) VALUES (@hName,@hNumber,@sName,@city,@postcode,@country,@pID)";
                OleDbCommand myAddressCommand = new OleDbCommand(myAddressQuery, myConnection);
                myAddressCommand.Parameters.AddWithValue("@hName", hN);
                myAddressCommand.Parameters.AddWithValue("@hNumber", hNO);
                myAddressCommand.Parameters.AddWithValue("@sName", sN);
                myAddressCommand.Parameters.AddWithValue("@city", c);
                myAddressCommand.Parameters.AddWithValue("@postcode", p.ToUpper());
                myAddressCommand.Parameters.AddWithValue("@country", con);
                myAddressCommand.Parameters.AddWithValue("@pID", parentID);
                myAddressCommand.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
            finally
            {
                myConnection.Close();
            }
            return null;
        }

        // update parent first name
        public static void UpdateParentFirstName(string uN)
        {
            OleDbConnection myConnection = GetConnection();
            string myQuery = "UPDATE Parent SET firstName = @fName WHERE userName = @uName";
            OleDbCommand myCommand = new OleDbCommand(myQuery, myConnection);
            myCommand.Parameters.AddWithValue("@fName", uN);

            try
            {
                myConnection.Open();
                myCommand.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                Console.Write(ex);
            }
            finally
            {
                myConnection.Close();
            }
        }
         // Method that returns a list of parent objects from the database
        public static List<Parent> LoadParents()
        {
            List<Parent> parents = new List<Parent>();
            OleDbConnection myConnection = GetConnection();

            string myQuery = "SELECT ID, firstName + ' ' + surname as parentName FROM Parent";
            OleDbCommand myCommand = new OleDbCommand(myQuery, myConnection);

            try
            {
                myConnection.Open();
                OleDbDataReader myReader = myCommand.ExecuteReader();
                while (myReader.Read())
                {
                    Parent g = new Parent(int.Parse(myReader["ID"].ToString()), myReader["parentName"].ToString());
                    parents.Add(g);
                }
                return parents;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Exception in DBHandler", ex);
                return null;
            }
            finally
            {
                myConnection.Close();
            }
        }

        // Method that saves a parent in the database

        public static void SaveParent(string fN, string lN, long tN, string e, string u, string p)
        {
            OleDbConnection myConnection = GetConnection();
            string myQuery = "INSERT INTO Parent ([firstName],[surname],[telNo],[email],[userName],[password]) VALUES (@fName,@lName,@telNo,@email,@userName,@password)";
            OleDbCommand myCommand = new OleDbCommand(myQuery, myConnection);
            myCommand.Parameters.AddWithValue("@fName", fN);
            myCommand.Parameters.AddWithValue("@lName", lN);
            myCommand.Parameters.AddWithValue("@telNo", tN);
            myCommand.Parameters.AddWithValue("@email", e);
            myCommand.Parameters.AddWithValue("@userName", u);
            myCommand.Parameters.AddWithValue("@password", p);

            try
            {
                myConnection.Open();
                myCommand.ExecuteNonQuery();
                Console.WriteLine("Reg successful");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Exception in DBHandler", ex);
            }
            finally
            {
                myConnection.Close();
            }
        }

        // Method that deletes a parent in the database

        public static void DeleteParent(int ID)
        {
            OleDbConnection myConnection = GetConnection();
            string myQuery = "DELETE * FROM Parent WHERE ID =" + ID;
            OleDbCommand myCommand = new OleDbCommand(myQuery, myConnection);

            try
            {
                myConnection.Open();
                myCommand.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Exception in DBHandler", ex);
            }
            finally
            {
                myConnection.Close();
            }
        }

        public static void DeleteSubscriptionByParentID(int pID)
        {
            OleDbConnection myConnection = GetConnection();
            string myQuery = "DELETE * FROM Membership WHERE pID =" + pID;
            OleDbCommand myCommand = new OleDbCommand(myQuery, myConnection);

            try
            {
                myConnection.Open();
                myCommand.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Exception in DBHandler", ex);
            }
            finally
            {
                myConnection.Close();
            }
        }
        public static int ReturnActiveMembership()
        {
            int activeMembership = 0;
            OleDbConnection myConnection = GetConnection();
            try
            {
                myConnection.Open();
                string myQuery = "SELECT Active FROM Membership WHERE pID = @pID";
                OleDbCommand myCommand = new OleDbCommand(myQuery, myConnection);
                myCommand.Parameters.AddWithValue("@pID", ReturnIDFromSessionUsername());
                activeMembership = int.Parse(myCommand.ExecuteScalar().ToString()); // either 1 or 0
            }
            catch (Exception ex)
            {

            }
            finally
            {
                myConnection.Close();
            }

            return activeMembership;
        }

        public static int ReturnIDFromSessionUsername()
        {
            int userID = 0;
            OleDbConnection myConnection = GetConnection();
            string myQuery = "SELECT Parent.ID FROM Parent WHERE userName = @uName";
            OleDbCommand myCommand = new OleDbCommand(myQuery, myConnection);
            myCommand.Parameters.AddWithValue("@uName", Person.SessionUsername); // selects parent id from username stored in Session

            try
            {
                myConnection.Open();
                userID = int.Parse(myCommand.ExecuteScalar().ToString());
            }
            catch (Exception ex)
            {

            }
            finally
            {
                myConnection.Close();
            }

            return userID;
        }

        public static string ReturnEndDateForActiveSubscription()
        {
            string ed = "N/A";
            OleDbConnection myConnection = GetConnection();
            try
            {
                myConnection.Open();
                string myQuery = "SELECT EndDate FROM Membership WHERE pID = @pID"; // returns end date from membership table
                OleDbCommand myCommand = new OleDbCommand(myQuery, myConnection);
                myCommand.Parameters.AddWithValue("@pID", ReturnIDFromSessionUsername());
                ed = myCommand.ExecuteScalar().ToString();

            }
            catch (Exception ex)
            {

            }
            finally
            {
                myConnection.Close();
            }
            return ed;
        }

        public static int ReturnChildCount()
        {
            int count = 0;
            OleDbConnection myConnection = GetConnection();
            try
            {
                myConnection.Open();
                string myQuery = "SELECT count(*) FROM CHILD WHERE cID =" + ReturnIDFromSessionUsername();
                OleDbCommand myCommand = new OleDbCommand(myQuery, myConnection);
                count = int.Parse(myCommand.ExecuteScalar().ToString()); // return child count
            }
            catch (Exception ex)
            {

            }
            finally
            {
                myConnection.Close();
            }

            return count;
            
        }
        public static void AddSubscriptionByParentID()
        {
            OleDbConnection myConnection = GetConnection();
            try
            {
                myConnection.Open();

                
            }
            catch (Exception ex)
            {
                Console.WriteLine("Exception in DBHandler", ex);
            }
            finally
            {
                myConnection.Close();
            }
        }

        public static void DeleteAllByParentUsername(string uN)
        {
            OleDbConnection myConnection = GetConnection();
            string myQuery = "SELECT Parent.ID from Parent WHERE userName = @uName";
            OleDbCommand myCommand = new OleDbCommand(myQuery, myConnection);
            myCommand.Parameters.AddWithValue("@uName", uN);

            try
            {
                myConnection.Open();
                int x = int.Parse(myCommand.ExecuteScalar().ToString());

                string myQuery2 = "DELETE * FROM Address WHERE pID = " + x;
                OleDbCommand myCommand2 = new OleDbCommand(myQuery2, myConnection);
                myCommand2.ExecuteNonQuery();
                string myQuery3 = "DELETE * FROM Child WHERE cID = " + x;
                OleDbCommand myCommand3 = new OleDbCommand(myQuery3, myConnection);
                myCommand3.ExecuteNonQuery();
                string myQuery4 = "DELETE * FROM Membership WHERE pID = " + x;
                OleDbCommand myCommand4 = new OleDbCommand(myQuery4, myConnection);
                myCommand4.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Exception in DBHandler", ex);
            }
            finally
            {
                myConnection.Close();
            }
        }

        // Method that returns a list of Child objects from the database

        public static List<Child> LoadChildren(int cID)
        {
            List<Child> child = new List<Child>();

            OleDbConnection myConnection = GetConnection();

            string myQuery = "SELECT ID, firstName + ' ' + Surname as childName FROM Child WHERE cID = " + cID;
            OleDbCommand myCommand = new OleDbCommand(myQuery, myConnection);

            try
            {
                myConnection.Open();
                OleDbDataReader myReader = myCommand.ExecuteReader();
                while (myReader.Read())
                {
                    Child g = new Child(int.Parse(myReader["ID"].ToString()), myReader["childName"].ToString());
                    child.Add(g);
                }
                return child;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Exception in DBHandler", ex);
                return null;
            }
            finally
            {
                myConnection.Close();
            }
        }

        // Method that returns a list of child objects with the same parent

        public static List<Child> LoadChildrenByParent(int pID)
        {
            List<Child> children = new List<Child>();
            OleDbConnection myConnection = GetConnection();
            string myQuery = "SELECT ID, firstName, surname, cID FROM Child WHERE cID = " + pID;
            OleDbCommand myCommand = new OleDbCommand(myQuery, myConnection);

            List<Parent> parent = LoadParents();

            try
            {
                myConnection.Open();
                OleDbDataReader myReader = myCommand.ExecuteReader();

                while (myReader.Read())
                {
                    Parent currentParent = FindParent(parent, int.Parse(myReader["cID"].ToString()));
                    Child v = new Child(int.Parse(myReader["ID"].ToString()), myReader["firstName"].ToString(), myReader["surname"].ToString(), int.Parse(myReader["cID"].ToString()), currentParent);
                    children.Add(v);
                }
                return children;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Exception in DBHandler", ex);
                return null;
            }
            finally
            {
                myConnection.Close();
            }
        }

        public static List<Child> LoadChildrenByParentUsername(string uN)
        {
            List<Child> children = new List<Child>();
            OleDbConnection myConnection = GetConnection();
            string myQuery = "SELECT Parent.ID from Parent WHERE userName = @uName";
            OleDbCommand myCommand = new OleDbCommand(myQuery, myConnection);
            myCommand.Parameters.AddWithValue("@uName", uN);
            
            List<Parent> parent = LoadParents();

            try
            {
                myConnection.Open();
                int x = int.Parse(myCommand.ExecuteScalar().ToString());
                string myQuery2 = "SELECT ID, firstName, surname, cID FROM Child WHERE cID = " + x;
                OleDbCommand myCommand2 = new OleDbCommand(myQuery2, myConnection);
                OleDbDataReader myReader = myCommand2.ExecuteReader();

                while (myReader.Read())
                {
                    Parent currentParent = FindParent(parent, int.Parse(myReader["cID"].ToString()));
                    Child v = new Child(int.Parse(myReader["ID"].ToString()), myReader["firstName"].ToString(), myReader["surname"].ToString(), int.Parse(myReader["cID"].ToString()), currentParent);
                    children.Add(v);
                }
                return children;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Exception in DBHandler", ex);
                return null;
            }
            finally
            {
                myConnection.Close();
            }
        }
        public static List<Address> LoadAddressByParent(int pID)
        {
            List<Address> address = new List<Address>();
            OleDbConnection myConnection = GetConnection();
            string myQuery = "SELECT ID, houseName, houseNumber, streetName, city, postcode, country, pID FROM Address WHERE pID = " + pID;
            OleDbCommand myCommand = new OleDbCommand(myQuery, myConnection);

            List<Parent> parent = LoadParents();

            try
            {
                myConnection.Open();
                OleDbDataReader myReader = myCommand.ExecuteReader();

                while (myReader.Read())
                {
                    Parent currentParent = FindParent(parent, int.Parse(myReader["pID"].ToString()));
                    Address v = new Address(int.Parse(myReader["ID"].ToString()), myReader["houseName"].ToString(), int.Parse(myReader["houseNumber"].ToString()), myReader["streetName"].ToString(), myReader["city"].ToString(), myReader["postcode"].ToString(), myReader["country"].ToString(), int.Parse(myReader["pID"].ToString()), currentParent);
                    address.Add(v);
                }
                return address;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Exception in DBHandler", ex);
                return null;
            }
            finally
            {
                myConnection.Close();
            }
        }
        // load addresses with parent id
        public static List<Address> LoadAddressByParentForRegister(string uN)
        {
            List<Address> address = new List<Address>();
            OleDbConnection myConnection = GetConnection();

            string myQuery0 = "SELECT Parent.ID FROM Parent WHERE userName = @uName";
            OleDbCommand myCommand0 = new OleDbCommand(myQuery0, myConnection);
            myCommand0.Parameters.AddWithValue("@uName", uN);

            

            List<Parent> parent = LoadParents();

            try
            {
                myConnection.Open();
                // get parent id
                int x = int.Parse(myCommand0.ExecuteScalar().ToString());
                // get address with parent id
                string myQuery = "SELECT * FROM Address WHERE pID = " + x;
                OleDbCommand myCommand = new OleDbCommand(myQuery, myConnection);

                OleDbDataReader myReader = myCommand.ExecuteReader();

                while (myReader.Read())
                {
                    Parent currentParent = FindParent(parent, int.Parse(myReader["pID"].ToString()));
                    Address v = new Address(int.Parse(myReader["ID"].ToString()),myReader["houseName"].ToString(), int.Parse(myReader["houseNumber"].ToString()), myReader["streetName"].ToString(), myReader["city"].ToString(), myReader["postcode"].ToString(), myReader["country"].ToString(), int.Parse(myReader["pID"].ToString()), currentParent);
                    address.Add(v);
                }
                return address;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Exception in DBHandler", ex);
                return null;
            }
            finally
            {
                myConnection.Close();
            }
        }

        // Method that finds a parent

        public static Parent FindParent(List<Parent> parent, int id)
        {
            foreach (var p in parent)
            {
                if (p.ParentID == id)
                {
                    return p;
                }
            }
            return null;
        }

        // find parent by username
        public static Parent FindParentByUsername(List<Parent> parent, string uN, int pID)
        {
            foreach (var p in parent)
            {
                if (p.Username == uN && p.ParentID == pID)
                {
                    return p;
                }
            }
            return null;
        }
        // finds parent by their username
        public static Parent FindParentByUsername(List<Parent> parent, string uN)
        {
            foreach (var p in parent)
            {
                if (p.Username == uN)
                {
                    return p;
                }
            }
            return null;
        }

        // Method that deletes a child from the database

        public static void DeleteChild (int ID)
        {
            OleDbConnection myConnection = GetConnection();
            string myQuery = "DELETE * FROM Child WHERE cID =" + ID;
            OleDbCommand myCommand = new OleDbCommand(myQuery, myConnection);

            try
            {
                myConnection.Open();
                myCommand.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Exception in DBHandler", ex);
            }
            finally
            {
                myConnection.Close();
            }
        }

        // deletes address from database
        public static void DeleteAddress(int pID)
        {
            OleDbConnection myConnection = GetConnection();
            string myQuery = "DELETE * FROM Address WHERE pID =" + pID;
            OleDbCommand myCommand = new OleDbCommand(myQuery, myConnection);

            try
            {
                myConnection.Open();
                myCommand.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Exception in DBHandler", ex);
            }
            finally
            {
                myConnection.Close();
            }
        }

        // Method that saves a child in the database

        public static void SaveChild(int id, string fN, string sN, string dOB, string s, string uN, string p)
        {
            OleDbConnection myConnection = GetConnection();
            string myQuery = "INSERT INTO Child( ID, firstName, surname, DoB, sex, username, cID, password ) VALUES ( '" + fN + "' , '" + sN + "' , '" + dOB + "' , '" + s + "' , '" + uN + "' , '" + p + "')";
            OleDbCommand myCommand = new OleDbCommand(myQuery, myConnection);

            try
            {
                myConnection.Open();
                myCommand.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Exception in DBHandler", ex);
            }
            finally
            {
                myConnection.Close();
            }
        }

        public static string ActiveConnection()
        {
            string conn = "";
            OleDbConnection myConnection = GetConnection();

            try
            {
                myConnection.Open();
                conn = "Connection to database successful";
            }
            catch (Exception ex)
            {
                Console.WriteLine("Exception in DBHandler", ex);
                conn = ex.ToString();
            }
            finally
            {
                myConnection.Close();
            }
            return conn;
        }

        public static string reg(string u)
        {
            // returns username count from parent table
            OleDbConnection myConnection = GetConnection();
            string myQuery = "SELECT count(*) FROM Parent WHERE username = '" + u + "'";
            OleDbCommand myCommand = new OleDbCommand(myQuery, myConnection);

            try
            {
                myConnection.Open();
                int temp = Convert.ToInt32(myCommand.ExecuteScalar().ToString());
                if (temp == 1)
                {
                    Console.Write("UN already exist");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Exception in DBHandler", ex);
                string m = ex.ToString();
            }
            finally
            {
                myConnection.Close();
            }
            return null;
        }

        public static OleDbConnection GetConn()
        {
            OleDbConnection myConnection = GetConnection();
            return myConnection; // returns connection string
        }

    }
}