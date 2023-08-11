using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.OleDb;

namespace Coursework_Subsystem_A.Account
{
    public partial class ParentManageAccount : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void updateFNBtn_Click(object sender, EventArgs e)
        {
            mainLbl.Text = "";
            if (fNTB.Text != "")
            {
                DBConnectivity.UpdateParentFirstName(Session["loginUN"].ToString());
                fNLbl.Text = "Your First Name has been updated.";
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
                string myQuery = "UPDATE Parent SET surname = @lName WHERE userName = @uName";
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
                string myQuery = "UPDATE Parent SET userName = @userName WHERE userName = @uName";
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
                string myQuery = "UPDATE Parent SET password = @password WHERE userName = @uName";
                OleDbCommand myCommand = new OleDbCommand(myQuery, myConnection);
                myCommand.Parameters.AddWithValue("@password", rTB.Text);
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

        protected void updateTNBtn_Click(object sender, EventArgs e)
        {
            mainLbl.Text = "";
            if (tNTB.Text != "")
            {
                OleDbConnection myConnection = DBConnectivity.GetConn();
                string myQuery = "UPDATE Parent SET telNo = @telNo WHERE userName = @uName";
                OleDbCommand myCommand = new OleDbCommand(myQuery, myConnection);
                myCommand.Parameters.AddWithValue("@telNo", int.Parse(tNTB.Text));
                myCommand.Parameters.AddWithValue("@uName", Session["loginUN"].ToString());

                try
                {
                    myConnection.Open();
                    myCommand.ExecuteNonQuery();
                    tNLbl.Text = "Your Telephone Number has been updated.";
                }
                catch (Exception ex)
                {
                    Response.Write(ex);
                    mainLbl.Text = "You must enter a valid telephone number";
                }
                finally
                {
                    myConnection.Close();
                }
            }
            else
            {
                mainLbl.Text = "You must enter a telephone number!";
            }
        }

        protected void updateEBtn_Click(object sender, EventArgs e)
        {
            mainLbl.Text = "";
            if (eTB.Text != "")
            {
                OleDbConnection myConnection = DBConnectivity.GetConn();
                string myQuery = "UPDATE Parent SET email = @email WHERE userName = @uName";
                OleDbCommand myCommand = new OleDbCommand(myQuery, myConnection);
                myCommand.Parameters.AddWithValue("@email", eTB.Text);
                myCommand.Parameters.AddWithValue("@uName", Session["loginUN"].ToString());

                try
                {
                    myConnection.Open();
                    myCommand.ExecuteNonQuery();
                    eLbl.Text = "Your Email has been updated.";
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
                mainLbl.Text = "You must enter an email!";
            }
        }

        protected void deleteAccountBtn_Click(object sender, EventArgs e)
        {
            DBConnectivity.DeleteAllByParentUsername(Session["loginUN"].ToString());
            Response.Redirect("LogOut.aspx");
        }

        protected void addressBtn_Click(object sender, EventArgs e)
        {
            Response.Redirect("ParentAddAddress.aspx");
        }
    }
}