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
    public partial class Payment : System.Web.UI.Page
    {
        double to = 0;
        Int32 count = 0;
        string parentName = "";
        protected void Page_Load(object sender, EventArgs e)
        {
            //// TODO: remove all database connectivity from this class
            
            OleDbConnection myConnection = DBConnectivity.GetConn(); // returns OleDb connection string
            
            try
            {
                myConnection.Open();
                //get active membership info
                int y = DBConnectivity.ReturnActiveMembership();
                if (y == 1)
                {
                    string endDate = DBConnectivity.ReturnEndDateForActiveSubscription();

                    outLbl.Text = "You currently have an active subscription." + " End Date: " + endDate; // user with active subscription will not be able to proceed with payment.
                    outLbl.Text += ". You will receive a renewal request nearer the end date.";
                    // hides labels and textboxes
                    cNLbl0.Visible = false; eRB.Visible = false; Table1.Visible = false; cV2TB.Visible = false;
                    cNLbl.Visible = false; gBPRB.Visible = false; cardDDL.Visible = false; startDay.Visible = false; startMonth.Visible = false; sYear.Visible = false;
                    totalLbl0.Visible = false; uRB.Visible = false; cNoTB.Visible = false; endDay.Visible = false; endMonth.Visible = false; endYear.Visible = false;
                    totalLbl.Visible = false; ausRB.Visible = false; regChildBtn.Visible = false; submitBtn.Visible = false; cV2Lbl.Visible=false;
                    billingAdLbl.Visible = false; cNLbl0.Visible = false; cardTypeLbl.Visible = false; cardNoLbl.Visible = false; sDateLbl.Visible = false;
                    eDateLbl.Visible = false;
                }
                else // active == 0
                {
                    outLbl.Text = "You currently do not have an active subscription. Please fill in the form below to purchase our services.";

                    //string myQuery4 = "SELECT count(*) FROM CHILD WHERE cID =" + DBConnectivity.ReturnIDFromSessionUsername();
                    //OleDbCommand myCommand4 = new OleDbCommand(myQuery4, myConnection);
                    //count = int.Parse(myCommand4.ExecuteScalar().ToString()); // return child count
                    count = DBConnectivity.ReturnChildCount();
                    if (count == 0)
                    {
                        childCountLbl.Text = "You have " + count + " child(ren). Please register a child here: "; regChildBtn.Visible = true;
                    }
                    else
                    {
                        childCountLbl.Text = "You have " + count + " child(ren)."; regChildBtn.Visible = false;
                    }
                    PaymentInfoStorage.SetChildCount(count); // stores the number of children a parent has
                    to = ChildPrice.getVariable() * count;
                    
                    if (gBPRB.Checked)
                    {
                        totalLbl.Text = "£" +to;   
                    }
                    else if (eRB.Checked)
                    {
                        double euro = to * PaymentInfoStorage.GetEuroExchange(); // sets exchange rate
                        totalLbl.Text = "€" + euro;
                    }
                    else if (uRB.Checked)
                    {
                        double usd = to * PaymentInfoStorage.GetUSDExchange();
                        totalLbl.Text = "$" + usd;
                    }
                    else if (ausRB.Checked)
                    {
                        double ausd = to * PaymentInfoStorage.GetAUSDExchange();
                        totalLbl.Text = "$" + ausd;
                    }
                    // get cardholder info from db
                    //string myQuery5 = "SELECT firstName + ' ' + surname as parentName FROM Parent WHERE ID = " + DBConnectivity.ReturnIDFromSessionUsername();
                    //OleDbCommand myCommand5 = new OleDbCommand(myQuery5, myConnection);
                    //string cN = myCommand5.ExecuteScalar().ToString();
                    cNLbl.Text = parentName;
                    // get address from db
                    List<Address> address = DBConnectivity.LoadAddressByParentForRegister(Person.SessionUsername);
                    // displays parents address in table
                    foreach (var a in address)
                    {
                        TableRow addressRow = new TableRow();
                        TableCell cell0 = new TableCell();
                        cell0.Text = a.AddressID.ToString();
                        TableCell cell1 = new TableCell();
                        cell1.Text = a.HouseName.ToString();
                        TableCell cell2 = new TableCell();
                        cell2.Text = a.HouseNumber.ToString();
                        TableCell cell3 = new TableCell();
                        cell3.Text = a.StreetName.ToString();
                        TableCell cell4 = new TableCell();
                        cell4.Text = a.City.ToString();
                        TableCell cell5 = new TableCell();
                        cell5.Text = a.Postcode.ToString();
                        TableCell cell6 = new TableCell();
                        cell6.Text = a.Country.ToString();
                        TableCell cell7 = new TableCell();
                        cell7.Text = a.PID.ToString();

                        addressRow.Cells.Add(cell1);
                        addressRow.Cells.Add(cell2);
                        addressRow.Cells.Add(cell3);
                        addressRow.Cells.Add(cell4);
                        addressRow.Cells.Add(cell5);
                        addressRow.Cells.Add(cell6);

                        Table1.Rows.Add(addressRow);
                    }
                }

            }
            catch (Exception ex)
            {
                Response.Write(ex);
            }
            finally
            {
                myConnection.Close();
            }

            
            
            
        }
        protected void Page_Init(object sender, EventArgs e)
        {
            // card start date drop down list
            // populating the days drop down list
            for (int day = 1; day < 32; day++)
            {
                ListItem li = new ListItem();
                li.Text = day.ToString();
                li.Value = day.ToString();
                startDay.Items.Add(li);
            } // populating the month drop down list
            DateTimeFormatInfo dtfi = new DateTimeFormatInfo();
            for (int month = 1; month < 13; month++)
            {
                ListItem li = new ListItem();
                li.Text = month.ToString();
                li.Value = month.ToString();
                startMonth.Items.Add(li);
            } // populating the years drop down list
            int thisYear = System.DateTime.Now.Year;
            int startYear = thisYear;
            for (int year = startYear; year > startYear - 20; year--)
            {
                ListItem li = new ListItem();
                li.Text = year.ToString();
                li.Value = year.ToString();
                sYear.Items.Add(li);

            }
            // card end date drop down list
            // populating the days drop down list
            for (int day = 1; day < 32; day++)
            {
                ListItem li = new ListItem();
                li.Text = day.ToString();
                li.Value = day.ToString();
                endDay.Items.Add(li);
            } // populating the month drop down list
            DateTimeFormatInfo dtfi1 = new DateTimeFormatInfo();
            for (int month = 1; month < 13; month++)
            {
                ListItem li = new ListItem();
                li.Text = month.ToString();
                li.Value = month.ToString();
                endMonth.Items.Add(li);
            } // populating the years drop down list
            int thisYear1 = System.DateTime.Now.Year;
            int startYear1 = thisYear1;
            for (int year = startYear1; year > startYear1 - 10; year--)
            {
                ListItem li = new ListItem();
                li.Text = year.ToString();
                li.Value = year.ToString();
                endYear.Items.Add(li);

            }
        }

        protected void regChildBtn_Click(object sender, EventArgs e)
        {
            Response.Redirect("ManageChild.aspx");
        }

        protected void submitBtn_Click(object sender, EventArgs e)
        {
            if (gBPRB.Checked) // gbp radio button
            {
                double gb = to;
                PaymentInfoStorage.SetCurrency("£"); // set currency symbol
                PaymentInfoStorage.gbp = true;
                PaymentInfoStorage.SetCurrentTotal(gb); // set total without any conversion
                PaymentInfoStorage.SetCurrentSubTotal(gb); // set subtotal without any conversion
            }
            else if (eRB.Checked) // euro radio button
            {
                PaymentInfoStorage.SetCurrency("€");
                PaymentInfoStorage.euro = true;
                double euro = to * PaymentInfoStorage.GetEuroExchange();
                PaymentInfoStorage.SetCurrentTotal(euro);
                PaymentInfoStorage.SetCurrentSubTotal(euro);
            }
            else if (uRB.Checked) // usd radio button
            {
                PaymentInfoStorage.SetCurrency("$");
                PaymentInfoStorage.usd = true;
                double usd = to * PaymentInfoStorage.GetUSDExchange();
                PaymentInfoStorage.SetCurrentTotal(usd);
                PaymentInfoStorage.SetCurrentSubTotal(usd);
            }
            else if (ausRB.Checked) // ausd radio button
            {
                PaymentInfoStorage.SetCurrency("$");
                PaymentInfoStorage.ausd = true;
                double ausd = to * PaymentInfoStorage.GetAUSDExchange();
                PaymentInfoStorage.SetCurrentTotal(ausd);
                PaymentInfoStorage.SetCurrentSubTotal(ausd);
            }
            // store payment details
            PaymentInfoStorage.SetCardholderName(cNLbl.Text);
            PaymentInfoStorage.SetCardType(cardDDL.SelectedItem.Text);
            PaymentInfoStorage.SetCardNumber(long.Parse(cNoTB.Text));
            PaymentInfoStorage.SetStartDate(startDay.SelectedItem.Text + "/" + startMonth.SelectedItem.Text + "/" + sYear.SelectedItem.Text);
            PaymentInfoStorage.SetEndDate(endDay.SelectedItem.Text + "/" + endMonth.SelectedItem.Text + "/" + endYear.SelectedItem.Text);

            try
            {
                
                PaymentInfoStorage.SetCV2(int.Parse(cV2TB.Text));
                
            }
            catch (FormatException ex)
            {
                Response.Write("You must enter a number!");
            }
            Response.Redirect("PaymentOverview.aspx");
        }
    }
}