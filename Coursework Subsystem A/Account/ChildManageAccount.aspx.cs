using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.OleDb;

namespace Coursework_Subsystem_A.Account
{
    public partial class ChildManageAccount : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
        }
        protected void updateRPWBtn_Click(object sender, EventArgs e)
        {
            mainLbl.Text = ""; // set label to empty string
            if (rTB.Text != "")
            {
                OleDbConnection myConnection = DBConnectivity.GetConn();
                string myQuery = "UPDATE Child SET password = @password WHERE userName = @uName"; // update password for logged in child account
                OleDbCommand myCommand = new OleDbCommand(myQuery, myConnection);
                myCommand.Parameters.AddWithValue("@password", pTB.Text);
                myCommand.Parameters.AddWithValue("@uName", Session["loginUN"].ToString());

                try
                {
                    myConnection.Open(); // open connection
                    myCommand.ExecuteNonQuery();
                    pWLbl.Text = "Your password has been updated.";
                    
                }
                catch (Exception ex)
                {
                    Response.Write(ex); // displays the exception on the current page, if caught
                }
                finally
                {
                    myConnection.Close(); // close connection
                }
            }
            else
            {
                mainLbl.Text = "You must enter a password!";
            }
        }
        
        protected void updateUNBtn_Click(object sender, EventArgs e)
        {
            mainLbl.Text = "";
            if (uNTB.Text != "")
            {
                OleDbConnection myConnection = DBConnectivity.GetConn();
                string myQuery = "UPDATE Child SET userName = @userName WHERE userName = @uName"; // update username stored in the database
                OleDbCommand myCommand = new OleDbCommand(myQuery, myConnection);
                myCommand.Parameters.AddWithValue("@userName", Session["loginUN"].ToString());
                myCommand.Parameters.AddWithValue("@uName", uNTB.Text);

                try
                {
                    myConnection.Open();
                    myCommand.ExecuteNonQuery();
                    uNLbl.Text = "Your Username has been updated.";
                    Session["loginUN"] = uNTB.Text;
                }
                catch (Exception ex)
                {
                    Response.Write(ex);
                }
                finally
                {
                    myConnection.Close();
                }
            }
            else
            {
                mainLbl.Text = "You must enter a username!";
            }
        }
    }
}