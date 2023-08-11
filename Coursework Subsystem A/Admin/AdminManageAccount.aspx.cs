using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.OleDb;

namespace Coursework_Subsystem_A.Account
{
    public partial class AdminManageAccount : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
        }
        // updates data stored in admin table
        protected void updateFNBtn_Click(object sender, EventArgs e)
        {
            mainLbl.Text = "";
            if (fNTB.Text != "")
            {
                OleDbConnection myConnection = DBConnectivity.GetConn();
                string myQuery = "UPDATE Admin SET firstName = @fName WHERE userName = @uName";
                OleDbCommand myCommand = new OleDbCommand(myQuery, myConnection);
                myCommand.Parameters.AddWithValue("@fName", fNTB.Text);
                myCommand.Parameters.AddWithValue("@uName", Session["loginUN"].ToString());

                try
                {
                    myConnection.Open();
                    myCommand.ExecuteNonQuery();
                    fNLbl.Text = "Your First Name has been updated.";
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
                mainLbl.Text = "You must enter a first name!";
            }
        }

        protected void updateLNBtn_Click(object sender, EventArgs e)
        {
            mainLbl.Text = "";
            if (lNTB.Text != "")
            {
                OleDbConnection myConnection = DBConnectivity.GetConn();
                string myQuery = "UPDATE Admin SET surname = @lName WHERE userName = @uName";
                OleDbCommand myCommand = new OleDbCommand(myQuery, myConnection);
                myCommand.Parameters.AddWithValue("@lName", lNTB.Text);
                myCommand.Parameters.AddWithValue("@uName", Session["loginUN"].ToString());

                try
                {
                    myConnection.Open();
                    myCommand.ExecuteNonQuery();
                    sNLbl.Text = "Your Last Name has been updated.";
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
                mainLbl.Text = "You must enter a last name!";
            }
        }

        protected void updateUNBtn_Click(object sender, EventArgs e)
        {
            mainLbl.Text = "";
            if (uNTB.Text != "")
            {
                OleDbConnection myConnection = DBConnectivity.GetConn();
                string myQuery = "UPDATE Admin SET userName = @userName WHERE userName = @uName";
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

        protected void updateRPWBtn_Click(object sender, EventArgs e)
        {
            mainLbl.Text = "";
            if (rTB.Text != "")
            {
                OleDbConnection myConnection = DBConnectivity.GetConn();
                string myQuery = "UPDATE Admin SET password = @password WHERE userName = @uName";
                OleDbCommand myCommand = new OleDbCommand(myQuery, myConnection);
                myCommand.Parameters.AddWithValue("@password", pTB.Text);
                myCommand.Parameters.AddWithValue("@uName", Session["loginUN"].ToString());

                try
                {
                    myConnection.Open();
                    myCommand.ExecuteNonQuery();
                    pWLbl.Text = "Your password has been updated.";
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
                mainLbl.Text = "You must enter a password!";
            }
        }
    }
}