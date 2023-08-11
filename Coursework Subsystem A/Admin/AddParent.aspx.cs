using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.OleDb;

namespace Coursework_Subsystem_A
{
    public partial class AddParent : System.Web.UI.Page
    {
        Int32 x = 0;
        protected void Page_Load(object sender, EventArgs e)
        {
            uLbl.Text = "";
            if (IsPostBack)
            {
                OleDbConnection myConnection = DBConnectivity.GetConn();
                string myQuery = "SELECT count(*) FROM Parent WHERE userName = '" + uTB.Text + "'";
                OleDbCommand myCommand = new OleDbCommand(myQuery, myConnection);

                try
                {
                    myConnection.Open();
                    x = Convert.ToInt32(myCommand.ExecuteScalar().ToString());
                    if (x > 0) // if database already contains entered username
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

        protected void submitBtn_Click(object sender, EventArgs e)
        {
            if (x == 0)
            {
                OleDbConnection myConnection = DBConnectivity.GetConn();
                //first
                string myParentQuery = "INSERT INTO Parent ([firstName],[surname],[telNo],[email],[userName],[password],[postcode]) VALUES (@fName,@lName,@telNo,@email,@userName,@password,@postcode)";
                OleDbCommand myParentCommand = new OleDbCommand(myParentQuery, myConnection);
                myParentCommand.Parameters.AddWithValue("@fName", fNTB.Text);
                myParentCommand.Parameters.AddWithValue("@lName", lNTB.Text);
                myParentCommand.Parameters.AddWithValue("@telNo", tNTB.Text);
                myParentCommand.Parameters.AddWithValue("@email", eTB.Text);
                myParentCommand.Parameters.AddWithValue("@userName", uTB.Text);
                myParentCommand.Parameters.AddWithValue("@password", pWTB.Text);
                myParentCommand.Parameters.AddWithValue("@postcode", pTB.Text.ToUpper());
          
                try
                {
                    myConnection.Open();
                    //first insert parent
                    myParentCommand.ExecuteNonQuery();
                    //second find parent id
                    string findParentQuery = "SELECT Parent.ID FROM Parent WHERE userName = @uName";
                    OleDbCommand myFindCommand = new OleDbCommand(findParentQuery, myConnection);
                    myFindCommand.Parameters.AddWithValue("@uName", uTB.Text);
                    int parentID = int.Parse(myFindCommand.ExecuteScalar().ToString());

                    //third insert address with parent id
                    string myAddressQuery = "INSERT INTO Address ([houseName],[houseNumber],[streetName],[city],[postcode],[country],[pID]) VALUES (@hName,@hNumber,@sName,@city,@postcode,@country,@pID)";
                    OleDbCommand myAddressCommand = new OleDbCommand(myAddressQuery, myConnection);
                    myAddressCommand.Parameters.AddWithValue("@hName", hNTB.Text);
                    myAddressCommand.Parameters.AddWithValue("@hNumber", hNOTB.Text);
                    myAddressCommand.Parameters.AddWithValue("@sName", sNTB.Text);
                    myAddressCommand.Parameters.AddWithValue("@city", cTB.Text);
                    myAddressCommand.Parameters.AddWithValue("@postcode", pTB.Text.ToUpper());
                    myAddressCommand.Parameters.AddWithValue("@country", countryDDL.SelectedItem.ToString());
                    myAddressCommand.Parameters.AddWithValue("@pID", parentID);
                    myAddressCommand.ExecuteNonQuery();
                    //fourth insert non active membership with parent id
                    string myQuery2 = "INSERT INTO Membership ([Active],[pID]) VALUES (@active, @pID)";
                    OleDbCommand myCommand2 = new OleDbCommand(myQuery2, myConnection);
                    myCommand2.Parameters.AddWithValue("@active", 0);
                    myCommand2.Parameters.AddWithValue("@pID", parentID);

                    myCommand2.ExecuteNonQuery();

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
            }
        }

        protected void viewParentsBtn_Click(object sender, EventArgs e)
        {
            Response.Redirect("ViewAllParents.aspx");
        }
    }
}