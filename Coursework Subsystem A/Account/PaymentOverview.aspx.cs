using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.OleDb;
using System.Globalization;

namespace Coursework_Subsystem_A.Account
{
    public partial class PaymentOverview : System.Web.UI.Page
    {
        double VAT = 1.2; // 20% VAT
        protected void Page_Load(object sender, EventArgs e)
        {
            cNLbl.Text = PaymentInfoStorage.GetCardholderName();
            cTLbl.Text = PaymentInfoStorage.GetCardType();
            cNoLbl.Text = PaymentInfoStorage.GetCardNumber().ToString();
            sDLbl.Text = PaymentInfoStorage.GetStartDate();
            eDLbl.Text = PaymentInfoStorage.GetEndDate();
            cV2Lbl.Text = PaymentInfoStorage.GetCV2().ToString();
            countLbl.Text = PaymentInfoStorage.GetChildCount().ToString();

            if (PaymentInfoStorage.gbp)
            {
                subTotalLbl.Text = PaymentInfoStorage.GetCurrency() + PaymentInfoStorage.GetCurrentSubTotal();
                double total = (PaymentInfoStorage.GetCurrentTotal() * VAT);
                totalLbl.Text = PaymentInfoStorage.GetCurrency() + (total).ToString();
                PaymentInfoStorage.SetCurrentTotal(total);
            }
            else if (PaymentInfoStorage.euro)
            {
                double subtotal = PaymentInfoStorage.GetCurrentSubTotal();
                subTotalLbl.Text = PaymentInfoStorage.GetCurrency() + subtotal;
                double total = (PaymentInfoStorage.GetCurrentTotal()* VAT);
                totalLbl.Text = PaymentInfoStorage.GetCurrency() + (total).ToString();
                PaymentInfoStorage.SetCurrentTotal(total);
            }
            else if (PaymentInfoStorage.usd)
            {
                double subtotal = PaymentInfoStorage.GetCurrentSubTotal();
                subTotalLbl.Text = PaymentInfoStorage.GetCurrency() + PaymentInfoStorage.GetCurrentSubTotal();
                double total = (PaymentInfoStorage.GetCurrentTotal()* VAT);
                totalLbl.Text = PaymentInfoStorage.GetCurrency() + (total).ToString();
                PaymentInfoStorage.SetCurrentTotal(total);
            }
            else if (PaymentInfoStorage.ausd)
            {
                double subtotal = PaymentInfoStorage.GetCurrentSubTotal();
                subTotalLbl.Text = PaymentInfoStorage.GetCurrency() + PaymentInfoStorage.GetCurrentSubTotal();
                double total = (PaymentInfoStorage.GetCurrentTotal()* VAT);
                totalLbl.Text = PaymentInfoStorage.GetCurrency() + (total).ToString();
                PaymentInfoStorage.SetCurrentTotal(total);
            }

            
            List<Address> address = DBConnectivity.LoadAddressByParentForRegister(Session["loginUN"].ToString());
            // displays address in a table
            foreach (var a in address)
            {
                TableRow addressRow = new TableRow();
                TableCell cell5 = new TableCell();
                cell5.Text = a.HouseName.ToString();
                TableCell cell6 = new TableCell();
                cell6.Text = a.HouseNumber.ToString();
                TableCell cell7 = new TableCell();
                cell7.Text = a.StreetName.ToString();
                TableCell cell8 = new TableCell();
                cell8.Text = a.City.ToString();
                TableCell cell9 = new TableCell();
                cell9.Text = a.Postcode.ToString();
                TableCell cell10 = new TableCell();
                cell10.Text = a.Country.ToString();

                addressRow.Cells.Add(cell5);
                addressRow.Cells.Add(cell6);
                addressRow.Cells.Add(cell7);
                addressRow.Cells.Add(cell8);
                addressRow.Cells.Add(cell9);
                addressRow.Cells.Add(cell10);

                Table2.Rows.Add(addressRow);
            }
        }

        protected void payBtn_Click(object sender, EventArgs e)
        {
            // store dates in string variable
            string sDate = (System.DateTime.Today.Day + "/" + System.DateTime.Today.Month + "/" + System.DateTime.Today.Year.ToString());
            string eDate = (System.DateTime.Today.Day +"/"+System.DateTime.Today.Month +"/" +(System.DateTime.Today.Year+1)).ToString();
            OleDbConnection myConnection = DBConnectivity.GetConn();
            string myQuery = "SELECT Parent.ID FROM Parent WHERE userName = @uName";
            OleDbCommand myCommand = new OleDbCommand(myQuery, myConnection);
            myCommand.Parameters.AddWithValue("@uName", Session["loginUN"].ToString());

            try
            {
                myConnection.Open();
                int x = int.Parse(myCommand.ExecuteScalar().ToString()); // returns parent id from Session username
                string myQuery2 = "UPDATE Membership SET active = @active, pID = @pID, BeginDate = @beginDate, EndDate = @endDate WHERE pID = @pID";
                OleDbCommand myCommand2 = new OleDbCommand(myQuery2, myConnection);
                myCommand2.Parameters.AddWithValue("@active", 1); // active membership
                myCommand2.Parameters.AddWithValue("@pID", x);
                myCommand2.Parameters.AddWithValue("@bDate", sDate);
                myCommand2.Parameters.AddWithValue("@eDate", eDate);
                myCommand2.Parameters.AddWithValue("@pID", x);

                myCommand2.ExecuteNonQuery();
                Response.Redirect("PaymentConfirmation.aspx");
            }
            catch (Exception ex)
            {
                Response.Write(ex.ToString());
            }
            finally
            {
                myConnection.Close();
            }
        }

        protected void cancelBtn_Click(object sender, EventArgs e)
        {
            Response.Redirect("CancelOrder.aspx");
        }
    }
}