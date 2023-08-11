using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Coursework_Subsystem_A
{
    public partial class DefaultLogOut : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            // deletes data in Session and redirects to default homepage
            Session.Abandon();
            Session.Clear();
            Session.RemoveAll();
            Response.AppendHeader("Refresh", "5;url=Default.aspx");
        }
    }
}