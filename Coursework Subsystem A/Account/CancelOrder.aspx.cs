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
            PaymentInfoStorage.setCardholderName("");
            PaymentInfoStorage.setCardType("");
            PaymentInfoStorage.setCardNumber(0);
            PaymentInfoStorage.setStartDate("");
            PaymentInfoStorage.setEndDate("");
            PaymentInfoStorage.setCV2(0);
            PaymentInfoStorage.setChildCount(0);
            PaymentInfoStorage.setCurrency("");
            PaymentInfoStorage.setCurrentTotal(0);
            PaymentInfoStorage.setCurrentSubTotal(0);

        }
    }
}