using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.OleDb;

namespace Coursework_Subsystem_A.Admin
{
    public partial class AddAdmin : System.Web.UI.Page
    {
          Int32 x = 0;
        protected void Page_Load(object sender, EventArgs e)
        {
            uLbl.Text = "";
            if (IsPostBack)
            {
                OleDbConnection myConnection = DBConnectivity.GetConn();
                string myQuery = "SELECT count(*) FROM Admin WHERE userName = '" + uTB.Text + "'";
                OleDbCommand myCommand = new OleDbCommand(myQuery, myConnection);

                try
                {
                    myConnection.Open();
                    x = Convert.ToInt32(myCommand.ExecuteScalar().ToString()); // returns first id from table whose id matches the query
                    if (x > 0)
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

                try
                {
                    myConnection.Open();

                    string myQuery = "INSERT INTO Admin ([firstName],[surname],[userName],[password]) VALUES (@fName,@lName,@uName,@password)";
                    OleDbCommand myCommand = new OleDbCommand(myQuery, myConnection);
                    myCommand.Parameters.AddWithValue("@fName", fNTB.Text);
                    myCommand.Parameters.AddWithValue("@lName", lNTB.Text);
                    myCommand.Parameters.AddWithValue("@userName", uTB.Text);
                    myCommand.Parameters.AddWithValue("@password", pWTB.Text);
                    myCommand.ExecuteNonQuery();
                    uLbl.Text = fNTB.Text + " " + lNTB.Text + " has been added sucessfully";
                }
                catch (Exception ex)
                {
                    uLbl.Text = ex.ToString();
                }
                finally
                {
                    myConnection.Close();
                }
            }
        }
    }
}