using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.OleDb;

namespace Coursework_Subsystem_A.Account
{
    public partial class Login : System.Web.UI.Page
    {
        Int32 x = 0;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (childRB.AutoPostBack == true && Page.IsPostBack)
            {
                childRB.AutoPostBack = false;
                parentRB.AutoPostBack = true;
            }
            else
            {
                parentRB.AutoPostBack = false;
                childRB.AutoPostBack = true;
            }
        }

        protected void loginBtn_Click(object sender, EventArgs e)
        {
            if (childRB.AutoPostBack == true && parentRB.AutoPostBack == false)
            {
                // Check username against database and login
                OleDbConnection myConnection = DBConnectivity.GetConn();
                string childUNQuery = "SELECT count(*) FROM [Child] WHERE userName = '" + uNTB.Text + "'";
                OleDbCommand childUNCommand = new OleDbCommand(childUNQuery, myConnection);

                try
                {
                    myConnection.Open();
                    x = Convert.ToInt32(childUNCommand.ExecuteScalar().ToString());
                    if (x > 0)
                    {
                        string childPWQuery = "SELECT password FROM [Child] WHERE userName = '" + uNTB.Text + "'";
                        OleDbCommand childPWCommand = new OleDbCommand(childPWQuery, myConnection);
                        string childPassword = childPWCommand.ExecuteScalar().ToString().Replace(" ", "");

                        if (childPassword == pTB.Text)
                        {
                            Session["loginUN"] = uNTB.Text; // sets text written in the username textbox into a session
                            uLbl.Text = "Password is correct!";
                            // Store user's username for setting Membership information
                            Person.SessionUsername = Session["loginUN"].ToString();
                            Response.Redirect("ChildManage.aspx"); // redirects to another page
                        }
                        else
                        {
                            uLbl.Text = "Password is not correct!";
                        }

                    }
                    else if (x == 0) // no matching usernames in database
                    {
                        uLbl.Text = "Username is not correct!";
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Exception in DBHandler", ex);
                    Response.Write(ex.ToString());
                }
                finally
                {
                    myConnection.Close();
                }
            }
            else
            {
                // Check username against database and login
                OleDbConnection myConnection = DBConnectivity.GetConn();
                string parentUNQuery = "SELECT count(*) FROM [Parent] WHERE userName = '" + uNTB.Text + "'";
                OleDbCommand ParentUNCommand = new OleDbCommand(parentUNQuery, myConnection);

                try
                {
                    myConnection.Open();
                    x = Convert.ToInt32(ParentUNCommand.ExecuteScalar().ToString()); // finds the first matching row for query
                    if (x > 0)
                    {
                        string ParentPWQuery = "SELECT password FROM [Parent] WHERE userName = '" + uNTB.Text + "'";
                        OleDbCommand ParentPWCommand = new OleDbCommand(ParentPWQuery, myConnection);
                        string parentPassword = ParentPWCommand.ExecuteScalar().ToString().Replace(" ", ""); // deletes any spaces in the password

                        if (parentPassword == pTB.Text)
                        {
                            Session["loginUN"] = uNTB.Text;
                            uLbl.Text = "Password is correct!";
                            // Store user's username for setting Membership information
                            Person.SessionUsername = Session["loginUN"].ToString();
                            Response.Redirect("ParentManage.aspx");
                        }
                        else
                        {
                            uLbl.Text = "Password is not correct!";
                        }

                    }
                    else if (x == 0)
                    {
                        uLbl.Text = "Username is not correct!";
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Exception in DBHandler", ex);
                    Response.Write(ex.ToString());
                    Console.WriteLine(ex.ToString());
                }
                finally
                {
                    myConnection.Close();
                }
            }
        }
    }
}