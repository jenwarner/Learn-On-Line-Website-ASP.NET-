using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.OleDb;

namespace Coursework_Subsystem_A.Account
{
    public partial class AdminLogin : System.Web.UI.Page
    {
        Int32 x = 0;
        protected void Page_Load(object sender, EventArgs e)
        {
            
        }

        protected void loginBtn_Click(object sender, EventArgs e)
        {
            // Check username against database and login
            OleDbConnection myConnection = DBConnectivity.GetConn();
            string adminUNQuery = "SELECT count(*) FROM Admin WHERE userName = '" + uNTB.Text + "'";
            OleDbCommand adminUNCommand = new OleDbCommand(adminUNQuery, myConnection);

            try
            {
                myConnection.Open();
                x = Convert.ToInt32(adminUNCommand.ExecuteScalar().ToString());
                if (x > 0)
                {
                    string adminPWQuery = "SELECT password FROM Admin WHERE userName = '" + uNTB.Text + "'";
                    OleDbCommand adminPWCommand = new OleDbCommand(adminPWQuery, myConnection);
                    string adminPassword = adminPWCommand.ExecuteScalar().ToString().Replace(" ", "");

                    if (adminPassword == pTB.Text)
                    {
                        Session["loginUN"] = uNTB.Text; // stores username written in the textbox into the Session
                        oLbl.Text = "Password is correct!";
                        Response.Redirect("AdminManage.aspx"); // redirects to page if password is correct
                    }
                    else
                    {
                        oLbl.Text = "Password is not correct!";
                    }

                }
                else if (x == 0)
                {
                    oLbl.Text = "Username is not correct!";
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Exception in DBHandler", ex);
                oLbl.Text = ex.ToString();;
            }
            finally
            {
                myConnection.Close();
            }
        }
    }
}