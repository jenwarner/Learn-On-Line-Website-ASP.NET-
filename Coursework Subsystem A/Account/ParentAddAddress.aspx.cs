using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.OleDb;

namespace Coursework_Subsystem_A.Account
{
    public partial class ParentAddAddress : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            uLbl.Text = "";
            // find parent full name with username
            nameLbl.Text = DBConnectivity.FindParentNameWithUsername(Session["loginUN"].ToString());
        }

        protected void submitBtn_Click(object sender, EventArgs e)
        {
            // calls to db connectivity class method, parsing in data from the various textboxes
            DBConnectivity.AddParentAddress(Session["loginUN"].ToString(), hNTB.Text, hNOTB.Text, sNTB.Text, cTB.Text, pTB.Text, countryDDL.SelectedItem.ToString());
            uLbl.Text = "Your address has been added successfully";

        }
    }
}