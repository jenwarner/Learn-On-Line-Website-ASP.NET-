using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Globalization;
using System.Data.OleDb;

namespace Coursework_Subsystem_A.Admin
{
    public partial class AddChild : System.Web.UI.Page
    {
        Int32 x = 0;
        protected void Page_Load(object sender, EventArgs e)
        {
            uLbl.Text = "";
            if (IsPostBack)
            {
                OleDbConnection myConnection = DBConnectivity.GetConn();
                string myQuery = "SELECT count(*) FROM Child WHERE userName = '" + uTB.Text + "'";
                OleDbCommand myCommand = new OleDbCommand(myQuery, myConnection);

                try
                {
                    myConnection.Open();
                    x = Convert.ToInt32(myCommand.ExecuteScalar().ToString());
                    if (x > 0) // if entered username already exists in the database
                    {
                        uLbl.Text = "Username already exists!";
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Exception in DBHandler", ex);
                    Response.Write(ex.ToString());
                }
                finally
                {
                    myConnection.Close();
                }
            }

        }
        protected void Page_Init(object sender, EventArgs e){
            // drop down list for child's date of birth
            // populating the days drop down list
            for (int day = 1; day < 32; day ++)
            { 
                ListItem li = new ListItem();
                li.Text = day.ToString();
                li.Value = day.ToString();
                birthDay.Items.Add(li);
            }
            DateTimeFormatInfo dtfi = new DateTimeFormatInfo(); 
            // populating the month drop down list
            for (int month = 1; month < 13; month ++)
            { 
                ListItem li = new ListItem();
                li.Text = dtfi.GetMonthName(month) + " (" + month.ToString() + ")";
                li.Value = month.ToString();
                birthMonth.Items.Add(li);
            } // populating the years drop down list
            int thisYear = System.DateTime.Now.Year;
            int startYear = thisYear - 05;
            for (int year = startYear; year > startYear - 100; year --)
            {
                ListItem li = new ListItem();
                li.Text = year.ToString();
                li.Value = year.ToString();
                birthYear.Items.Add(li);
            
            }
        }

        protected void submitBtn_Click(object sender, EventArgs e)
        {
            string dob = birthDay.SelectedItem.Text + "/" + birthMonth.SelectedItem.Text + "/" + birthYear.SelectedItem.Text; // stores dob in string
            if (x == 0) // if username entered in textbox does not already exist in database
            {
                OleDbConnection myConnection = DBConnectivity.GetConn(); // get connection string
                try
                {
                    myConnection.Open();
                    string myParentQuery = "SELECT Parent.ID FROM Parent WHERE userName = @pUName";

                    OleDbCommand myParentCommand = new OleDbCommand(myParentQuery, myConnection);
                    myParentCommand.Parameters.AddWithValue("@pUName", pUTB.Text);

                    int y = int.Parse(myParentCommand.ExecuteScalar().ToString());
                    uLbl.Text = y.ToString();
                    // insert data from text fields into the child table
                    string myQuery = "INSERT INTO Child ([firstName],[surname],[dob],[sex],[userName],[cID],[password]) VALUES (@fName,@lName,@dob,@sex,@userName,@cID,@password)";
                    OleDbCommand myCommand = new OleDbCommand(myQuery, myConnection);
                    myCommand.Parameters.AddWithValue("@fName", fNTB.Text);
                    myCommand.Parameters.AddWithValue("@lName", lNTB.Text);
                    myCommand.Parameters.AddWithValue("@dob", dob);
                    myCommand.Parameters.AddWithValue("@sex", sexDDL.SelectedValue);
                    myCommand.Parameters.AddWithValue("@userName", uTB.Text);
                    myCommand.Parameters.AddWithValue("@cID", y);
                    myCommand.Parameters.AddWithValue("@password", pWTB.Text);

                    myCommand.ExecuteNonQuery();
                    uLbl.Text = fNTB.Text + " " + lNTB.Text + " has been added sucessfully";
                }
                catch (Exception ex)
                {
                    uLbl.Text = "Parent username cannot be found";
                }
                finally
                {
                    myConnection.Close();
                }
            }
        }
    }
}