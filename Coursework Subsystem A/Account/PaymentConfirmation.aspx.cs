using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Coursework_Subsystem_A.Account
{
    public partial class PaymentConfirmation : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //displays amount paid
            paidLbl.Text = PaymentInfoStorage.GetCurrency() + PaymentInfoStorage.GetCurrentTotal().ToString();
            // displays amount of VAT paid
            vatLbl.Text = (PaymentInfoStorage.GetCurrentTotal() - PaymentInfoStorage.GetCurrentSubTotal()).ToString();
        }
    }
}