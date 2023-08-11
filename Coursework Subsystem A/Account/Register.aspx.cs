using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.OleDb;

namespace Coursework_Subsystem_A.Account
{
    public partial class Register : System.Web.UI.Page
    {
        Int32 x = 0;
        protected void Page_Load(object sender, EventArgs e)
        {
            outputLbl.Text = "";
            if (childRB.AutoPostBack == true && IsPostBack)
            {
                tNLbl.Visible = true;
                tNTB.Visible = true;
                eLbl.Visible = true;
                eTB.Visible = true;
                tNLbl.Text = "Date of Birth";
                tNTB.Text = "DD/MM/YYYY";
                eLbl.Text = "Sex";
                eTB.Text = "Male/Female";
                pULbl.Visible = true;
                pUTB.Visible = true;
                RequiredFieldValidator8.Visible = true;
                RegularExpressionValidator1.Visible = false;
                RegularExpressionValidator2.Visible = false;
                childRB.AutoPostBack = false;
                parentRB.AutoPostBack = true;
                if (IsPostBack)
                {
                    OleDbConnection myConnection = DBConnectivity.GetConn();
                    string myQuery = "SELECT count(*) FROM [Child] WHERE userName = '" + uNTB.Text + "'";
                    OleDbCommand myCommand = new OleDbCommand(myQuery, myConnection);

                    try
                    {
                        myConnection.Open();
                        x = Convert.ToInt32(myCommand.ExecuteScalar().ToString());
                        if (x > 0)
                        {
                            outputLbl.Text = "Username already exists!";
                        }
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine("Exception in DBHandler", ex);
                        Response.Write(ex.ToString());
                        Console.WriteLine(ex.ToString());
                    }
                    finally
                    {
                        myConnection.Close();
                    }
                }
            }
            else
            {
                // hides fields not required for parents to register
                tNLbl.Visible = false;
                tNTB.Visible = false;
                eLbl.Visible = false;
                eTB.Visible = false;
                pULbl.Visible = false;
                pUTB.Visible = false;
                RequiredFieldValidator8.Visible = false;
                RegularExpressionValidator1.Visible = true;
                RegularExpressionValidator2.Visible = true;
                childRB.AutoPostBack = true;
                parentRB.AutoPostBack = false;

                if (IsPostBack)
                {
                    OleDbConnection myConnection = DBConnectivity.GetConn();
                    string myQuery = "SELECT count(*) FROM Parent WHERE userName = '" + uNTB.Text + "'";
                    OleDbCommand myCommand = new OleDbCommand(myQuery, myConnection);

                    try
                    {
                        myConnection.Open();
                        x = Convert.ToInt32(myCommand.ExecuteScalar().ToString());
                        if (x > 0)
                        {
                            outputLbl.Text = "Username already exists!";
                        }
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine("Exception in DBHandler", ex);
                        Response.Write(ex.ToString());
                        Console.WriteLine(ex.ToString());
                    }
                    finally
                    {
                        myConnection.Close();
                    }
                }
            }
        }

        protected void submitBtn_Click(object sender, EventArgs e)
        {
            if (childRB.AutoPostBack == true && parentRB.AutoPostBack == false)
            {
                if (x == 0) // if there are no username matches in the database
                {
                    OleDbConnection myConnection = DBConnectivity.GetConn();
                    try
                    {
                        myConnection.Open();
                        string myParentQuery = "SELECT Parent.ID FROM Parent WHERE userName = @pUName";

                    OleDbCommand myParentCommand = new OleDbCommand(myParentQuery, myConnection);
                    myParentCommand.Parameters.AddWithValue("@pUName", pUTB.Text);

                    int y = int.Parse(myParentCommand.ExecuteScalar().ToString());
                    outputLbl.Text = y.ToString();

                    string myQuery = "INSERT INTO Child ([firstName],[surname],[dob],[sex],[userName],[cID],[password]) VALUES (@fName,@lName,@dob,@sex,@userName,@cID,@password)";
                    OleDbCommand myCommand = new OleDbCommand(myQuery, myConnection);
                    myCommand.Parameters.AddWithValue("@fName", fNTB.Text);
                    myCommand.Parameters.AddWithValue("@lName", lNTB.Text);
                    myCommand.Parameters.AddWithValue("@dob", tNTB.Text);
                    myCommand.Parameters.AddWithValue("@sex", eTB.Text);
                    myCommand.Parameters.AddWithValue("@userName", uNTB.Text);
                    myCommand.Parameters.AddWithValue("@cID", y);
                    myCommand.Parameters.AddWithValue("@password", pTB.Text);

                        myCommand.ExecuteNonQuery();

                        outputLbl.Text = "Registration successful!";
                    }
                    catch (Exception ex)
                    {
                        Response.Write(ex.ToString());
                        outputLbl.Text = "Unable to register as we can't find a parent with your username. Please check your spelling or register yourself first.";
                    }
                    finally
                    {
                        myConnection.Close();
                    }
                }
                childRB.AutoPostBack = false;
                parentRB.AutoPostBack = true;
            }
            else
            {
                if (x == 0)
                {
                    OleDbConnection myConnection = DBConnectivity.GetConn();

                    DBConnectivity.SaveParent(fNTB.Text, lNTB.Text, 0, "N/A", uNTB.Text, pTB.Text);

                    // second find parent id
                    string findParentQuery = "SELECT Parent.ID FROM Parent WHERE userName = @uName";
                    OleDbCommand myFindCommand = new OleDbCommand(findParentQuery, myConnection);
                    myFindCommand.Parameters.AddWithValue("@uName", uNTB.Text);
                    try
                    {
                        myConnection.Open();
                        int parentID = int.Parse(myFindCommand.ExecuteScalar().ToString());

                        // third insert into membership with parent id
                        string myQuery3 = "INSERT INTO Membership ([Active],[pID]) VALUES (@active,@pID)";
                        OleDbCommand myCommand3 = new OleDbCommand(myQuery3, myConnection);
                        myCommand3.Parameters.AddWithValue("@active", 0);
                        myCommand3.Parameters.AddWithValue("@pID", parentID);
                        myCommand3.ExecuteNonQuery();
                        outputLbl.Text = "Registration successful!";
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
                childRB.AutoPostBack = true;
                parentRB.AutoPostBack = false;
            }
        }
    }
}