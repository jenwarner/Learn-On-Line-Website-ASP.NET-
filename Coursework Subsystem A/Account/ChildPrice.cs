using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.OleDb;

namespace Coursework_Subsystem_A.Account
{
    public class ChildPrice
    {
        private static double mainPrice = 190.00; // default price per child for LoL services

        public static void SetVariable(double s)
        {
            mainPrice = s;
        }
        public static double getVariable()
        {
            return mainPrice;
        }

        public static double price()
        {
            int x = 0;
            double res = 0.0;
            OleDbConnection myConnection = DBConnectivity.GetConn();

            string myQuery = "SELECT count(*) FROM Child INNER JOIN Parent on Child.cID = Parent.ID"; // joint query for Parent and Child tables
            OleDbCommand myCommand = new OleDbCommand(myQuery, myConnection);

            try
            {
                myConnection.Open();
                x = Convert.ToInt32(myCommand.ExecuteScalar().ToString()); // returns the first matching row for query
                if (x > 0)
                {
                    res = Convert.ToDouble(x) * mainPrice;
                }
                else if (x == 0)
                {
                    Console.WriteLine("You must add a child for the selected parent.");
                }

            }
            catch (Exception ex)
            {
                Console.WriteLine("Exception in DBHandler", ex);
            }
            finally
            {
                myConnection.Close();
            }
            return res;
        }
        public static double getSubtotal()
        {
            double s = mainPrice * PaymentInfoStorage.GetChildCount();
            return s;
        }
    }
}