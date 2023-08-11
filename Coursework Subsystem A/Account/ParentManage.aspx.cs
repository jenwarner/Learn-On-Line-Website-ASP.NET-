using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.OleDb;

namespace Coursework_Subsystem_A.Account
{
    public partial class ParentManage : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["loginUN"] != null)
            {
                // greeting with current date and time
                if (DateTime.Now.Hour < 12)
                {
                    greetingLbl.Text = "Good Morning, " + Session["loginUN"].ToString() + ".";
                    dateLbl.Text = Convert.ToString(DateTime.Now);
                }
                else if (DateTime.Now.Hour < 17)
                {
                    greetingLbl.Text = "Good Afternoon, " + Session["loginUN"].ToString() + ".";
                    dateLbl.Text = Convert.ToString(DateTime.Now);
                }
                else
                {
                    greetingLbl.Text = "Good Evening, " + Session["loginUN"].ToString() + ".";
                    dateLbl.Text = Convert.ToString(DateTime.Now);
                }
            }
        }

        protected void pManageAccountBtn_Click(object sender, EventArgs e)
        {
            Response.Redirect("ParentManageAccount.aspx");
        }

        protected void mCBtn_Click(object sender, EventArgs e)
        {
            Response.Redirect("ManageChild.aspx");
        }

        protected void paymentBtn_Click(object sender, EventArgs e)
        {
            Response.Redirect("Payment.aspx");
        }
        protected void vBtn_Click(object sender, EventArgs e)
        {
            OleDbConnection myConnection = DBConnectivity.GetConn();
            string myQuery = "SELECT Parent.ID FROM Parent WHERE userName = @uName";
            OleDbCommand myCommand = new OleDbCommand(myQuery, myConnection);
            myCommand.Parameters.AddWithValue("@uName", Session["loginUN"].ToString());

            try
            {
                myConnection.Open();
                int x = int.Parse(myCommand.ExecuteScalar().ToString());

                string myQuery2 = "SELECT Active FROM Membership WHERE pID = " + x;
                OleDbCommand myCommand2 = new OleDbCommand(myQuery2, myConnection);
                int y = int.Parse(myCommand2.ExecuteScalar().ToString());
                if (y == 1) // active membership
                {
                    Response.Redirect("ViewChildren.aspx");
                }
                else // inactive membership
                {
                    vCLbl.Text = "You must have an active membership to proceed!";
                }
            }
            catch (Exception ex)
            {
                vCLbl.Text = ex.ToString();
            }
            finally
            {
                myConnection.Close();
            }          
        }
    }
}