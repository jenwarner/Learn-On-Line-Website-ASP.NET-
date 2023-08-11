using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.OleDb;

namespace Coursework_Subsystem_A
{
    public partial class SiteMaster : MasterPage
    {
        
        private const string AntiXsrfTokenKey = "__AntiXsrfToken";
        private const string AntiXsrfUserNameKey = "__AntiXsrfUserName";
        private string _antiXsrfTokenValue;

        protected void Page_Init(object sender, EventArgs e)
        {
            // The code below helps to protect against XSRF attacks
            var requestCookie = Request.Cookies[AntiXsrfTokenKey];
            Guid requestCookieGuidValue;
            if (requestCookie != null && Guid.TryParse(requestCookie.Value, out requestCookieGuidValue))
            {
                // Use the Anti-XSRF token from the cookie
                _antiXsrfTokenValue = requestCookie.Value;
                Page.ViewStateUserKey = _antiXsrfTokenValue;
            }
            else
            {
                // Generate a new Anti-XSRF token and save to the cookie
                _antiXsrfTokenValue = Guid.NewGuid().ToString("N");
                Page.ViewStateUserKey = _antiXsrfTokenValue;

                var responseCookie = new HttpCookie(AntiXsrfTokenKey)
                {
                    HttpOnly = true,
                    Value = _antiXsrfTokenValue
                };
                if (FormsAuthentication.RequireSSL && Request.IsSecureConnection)
                {
                    responseCookie.Secure = true;
                }
                Response.Cookies.Set(responseCookie);
            }

            Page.PreLoad += master_Page_PreLoad;
        }

        protected void master_Page_PreLoad(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                // Set Anti-XSRF token
                ViewState[AntiXsrfTokenKey] = Page.ViewStateUserKey;
                ViewState[AntiXsrfUserNameKey] = Context.User.Identity.Name ?? String.Empty;
            }
            else
            {
                // Validate the Anti-XSRF token
                if ((string)ViewState[AntiXsrfTokenKey] != _antiXsrfTokenValue
                    || (string)ViewState[AntiXsrfUserNameKey] != (Context.User.Identity.Name ?? String.Empty))
                {
                    throw new InvalidOperationException("Validation of Anti-XSRF token failed.");
                }
            }
        }

        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["loginUN"] != null)
            {
                NotLoggedInPH.Visible = false;
                LoggedInPH.Visible = true;
                helloLbl.Text = Session["loginUN"].ToString() + " is logged in.";

            }
        }

        protected void myAccBtn_Click(object sender, EventArgs e)
        {
            OleDbConnection myConnection = DBConnectivity.GetConn();
            string myParentQuery = "SELECT count(*) FROM Parent WHERE userName = '"+Session["loginUN"].ToString()+"'";
            OleDbCommand myParentCommand = new OleDbCommand(myParentQuery, myConnection);

            try
            {
                myConnection.Open();
                int x = int.Parse(myParentCommand.ExecuteScalar().ToString());

                if (x == 0)
                {
                    // child commands
                    string myChildQuery = "SELECT count(*) FROM Child WHERE userName = '" + Session["loginUN"].ToString() + "'";
                    OleDbCommand myChildCommand = new OleDbCommand(myChildQuery, myConnection);
                    int y = int.Parse(myChildCommand.ExecuteScalar().ToString());

                    /*if (y == 0)
                    {
                        
                    }*/
                    if (y > 0)
                    {
                        // link to child manage page
                        Response.Redirect("../Account/ChildManage.aspx");
                    }
                }
                else if (x > 0)
                {
                    // link to parent manage page
                    Response.Redirect("../Account/ParentManage.aspx");
                }
            }
            catch (Exception ex)
            {

            }
            finally
            {
                myConnection.Close();
            }
        }
        
    }
}