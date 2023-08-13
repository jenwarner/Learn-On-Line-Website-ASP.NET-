using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Coursework_Subsystem_A.Account
{
    public partial class CancelOrder : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            // sets payment variables to null values
            PaymentInfoStorage.SetCardholderName("");
            PaymentInfoStorage.SetCardType("");
            PaymentInfoStorage.SetCardNumber(0);
            PaymentInfoStorage.SetStartDate("");
            PaymentInfoStorage.SetEndDate("");
            PaymentInfoStorage.SetCV2(0);
            PaymentInfoStorage.SetChildCount(0);
            PaymentInfoStorage.SetCurrency("");
            PaymentInfoStorage.SetCurrentTotal(0);
            PaymentInfoStorage.SetCurrentSubTotal(0);

        }
    }
}