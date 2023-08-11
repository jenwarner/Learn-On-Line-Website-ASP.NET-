using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Coursework_Subsystem_A.Account
{
    public partial class Prices : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            currentPriceLbl.Text = "£" + ChildPrice.getVariable().ToString();
        }

        protected void submitBtn_Click(object sender, EventArgs e)
        {
            try
            {
                ChildPrice.setVariable(double.Parse(priceTB.Text));
            }
            catch (FormatException fe)
            {
                oLbl.Text = fe.ToString();
            }
        }
    }
}