using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Coursework_Subsystem_A
{
    public partial class AdminSite : System.Web.UI.MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["loginUN"] != null)
            {
                NotLoggedInPH.Visible = false;
                LoggedInPH.Visible = true;
                helloLbl.Text = Session["loginUN"].ToString() + " is logged in.";
            }
        }
    }
}