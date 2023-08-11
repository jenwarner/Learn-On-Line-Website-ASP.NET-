using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Coursework_Subsystem_A.Account
{
    public partial class ChildManage : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["loginUN"] != null)
            { 
                // sets a greeting with the current time and date at time of login for the user
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
        // calls to another page if button clicked
        protected void mAccBtn_Click(object sender, EventArgs e)
        {
            Response.Redirect("ChildManageAccount.aspx");
        }

        protected void vCoursesBtn_Click(object sender, EventArgs e)
        {
            Response.Redirect("../Courses.aspx");
        }

        protected void quizBtn_Click(object sender, EventArgs e)
        {
            Response.Redirect("Quiz.aspx");
        }
    }
}