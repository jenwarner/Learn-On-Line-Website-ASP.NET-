using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Coursework_Subsystem_A.Account
{
    public partial class AdminManage : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["loginUN"] != null)
            {
                // sets greeting message and displays the current date and time
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
            connLbl.Text = DBConnectivity.ActiveConnection(); // shows if the connection to the database is successful
        }

        protected void manageAccountBtn_Click(object sender, EventArgs e)
        {
            Response.Redirect("AdminManageAccount.aspx");
        }

        protected void pricesBtn_Click(object sender, EventArgs e)
        {
            Response.Redirect("Prices.aspx");
        }
        protected void adminBtn_Click(object sender, EventArgs e)
        {
            Response.Redirect("AddAdmin.aspx");
        }

        protected void coursesBtn_Click(object sender, EventArgs e)
        {
            Response.Redirect("AdminCourses.aspx");
        }
    }
}