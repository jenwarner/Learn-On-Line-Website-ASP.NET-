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
    public partial class ManageChild : System.Web.UI.Page
    {
        Int32 x = 0;
        protected void Page_Load(object sender, EventArgs e)
        {
            uLbl.Text = "";
            if (!Page.IsPostBack) // first time loading
            {
                List<Child> child = DBConnectivity.LoadChildrenByParentUsername(Session["loginUN"].ToString());
                // lists all the children of a parent in a table
                foreach (var c in child)
                {
                    TableRow row = new TableRow();
                    TableCell cell0 = new TableCell();
                    cell0.Text = c.ID.ToString();
                    TableCell cell1 = new TableCell();
                    cell1.Text = c.FirstName;
                    TableCell cell2 = new TableCell();
                    cell2.Text = c.Surname;
                    TableCell cell3 = new TableCell();
                    cell3.Text = c.CID.ToString();

                    row.Cells.Add(cell0);
                    row.Cells.Add(cell1);
                    row.Cells.Add(cell2);
                    row.Cells.Add(cell3);

                    Table1.Rows.Add(row);
                    TextBox1.Focus();
                }
            }
            else
            {
                List<Child> child = DBConnectivity.LoadChildrenByParentUsername(Session["loginUN"].ToString());

                foreach (var c in child)
                {
                    TableRow row = new TableRow();
                    TableCell cell0 = new TableCell();
                    cell0.Text = c.ID.ToString();
                    TableCell cell1 = new TableCell();
                    cell1.Text = c.FirstName;
                    TableCell cell2 = new TableCell();
                    cell2.Text = c.Surname;
                    TableCell cell3 = new TableCell();
                    cell3.Text = c.CID.ToString();

                    row.Cells.Add(cell0);
                    row.Cells.Add(cell1);
                    row.Cells.Add(cell2);
                    row.Cells.Add(cell3);

                    Table1.Rows.Add(row);
                    TextBox1.Focus();
                }
                OleDbConnection myConnection = DBConnectivity.GetConn();
                string myQuery = "SELECT count(*) FROM Child WHERE userName = '" + uTB.Text + "'";
                OleDbCommand myCommand = new OleDbCommand(myQuery, myConnection);

                try
                {
                    myConnection.Open();
                    x = Convert.ToInt32(myCommand.ExecuteScalar().ToString());
                    if (x > 0)
                    {
                        uLbl.Text = "UN already exists!";
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
        protected void Page_Init(object sender, EventArgs e)
        {
            // populating the days drop down list
            for (int day = 1; day < 32; day++)
            {
                ListItem li = new ListItem();
                li.Text = day.ToString();
                li.Value = day.ToString();
                birthDay.Items.Add(li);
            } // populating the month drop down list
            DateTimeFormatInfo dtfi = new DateTimeFormatInfo();
            for (int month = 1; month < 13; month++)
            {
                ListItem li = new ListItem();
                li.Text = dtfi.GetMonthName(month) + " (" + month.ToString() + ")";
                li.Value = month.ToString();
                birthMonth.Items.Add(li);
            } // populating the years drop down list
            int thisYear = System.DateTime.Now.Year;
            int startYear = thisYear - 05;
            for (int year = startYear; year > startYear - 100; year--)
            {
                ListItem li = new ListItem();
                li.Text = year.ToString();
                li.Value = year.ToString();
                birthYear.Items.Add(li);

            }
        }
        protected void deleteBtn_Click(object sender, EventArgs e)
        {
            try
            {
                DBConnectivity.DeleteChild(int.Parse(TextBox1.Text));
                uLbl.Text = TextBox1.Text;
                uLbl.Text = "record sucessfully deleted";
            }
            catch (FormatException ex)
            {
                uLbl.Text = ex.ToString();
            }
        }

        protected void submitBtn_Click(object sender, EventArgs e)
        {
            string dob = birthDay.SelectedItem.Text + "/" + birthMonth.SelectedItem.Text + "/" + birthYear.SelectedItem.Text; // stores selected dob in string
            if (x == 0)
            {
                OleDbConnection myConnection = DBConnectivity.GetConn();
                try
                {
                    myConnection.Open();
                    string myParentQuery = "SELECT Parent.ID FROM Parent WHERE userName = @pUName"; // gets username for parent id

                    OleDbCommand myParentCommand = new OleDbCommand(myParentQuery, myConnection);
                    myParentCommand.Parameters.AddWithValue("@pUName", Session["loginUN"].ToString());

                    int y = int.Parse(myParentCommand.ExecuteScalar().ToString());
                    uLbl.Text = y.ToString();
                    // intserts data into the child table from the various textboxes
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
                    Response.Write(ex.ToString());
                }
                finally
                {
                    myConnection.Close();
                }
                
                uLbl.Text = fNTB.Text + " " + lNTB.Text + " has been added sucessfully";
            }
        }
    }
}