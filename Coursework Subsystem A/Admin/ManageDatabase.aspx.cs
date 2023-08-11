using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Coursework_Subsystem_A.Admin
{
    public partial class ManageDatabase : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack) // first time
            {
                // displays all parents in a drop down list
                parentDDL.DataSource = DBConnectivity.LoadParents();
                parentDDL.DataTextField = "ParentName";
                parentDDL.DataValueField = "ParentID";
                parentDDL.DataBind();
                // lists children in a table
                List<Child> child = DBConnectivity.LoadChildrenByParent(int.Parse(parentDDL.SelectedValue));
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
                // lists address in a table
                List<Address> address = DBConnectivity.LoadAddressByParent(int.Parse(parentDDL.SelectedValue));

                foreach (var a in address)
                {
                    TableRow addressRow = new TableRow();
                    TableCell cell4 = new TableCell();
                    cell4.Text = a.AddressID.ToString();
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
                    TableCell cell11 = new TableCell();
                    cell11.Text = a.PID.ToString();

                    addressRow.Cells.Add(cell4);
                    addressRow.Cells.Add(cell5);
                    addressRow.Cells.Add(cell6);
                    addressRow.Cells.Add(cell7);
                    addressRow.Cells.Add(cell8);
                    addressRow.Cells.Add(cell9);
                    addressRow.Cells.Add(cell10);
                    addressRow.Cells.Add(cell11);

                    Table2.Rows.Add(addressRow);
                }
            }
            else
            {

            List<Child> child = DBConnectivity.LoadChildrenByParent(int.Parse(parentDDL.SelectedValue));
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
            List<Address> address = DBConnectivity.LoadAddressByParent(int.Parse(parentDDL.SelectedValue));

            foreach (var a in address)
            {
                TableRow addressRow = new TableRow();
                TableCell cell4 = new TableCell();
                cell4.Text = a.AddressID.ToString();
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
                TableCell cell11 = new TableCell();
                cell11.Text = a.PID.ToString();

                addressRow.Cells.Add(cell4);
                addressRow.Cells.Add(cell5);
                addressRow.Cells.Add(cell6);
                addressRow.Cells.Add(cell7);
                addressRow.Cells.Add(cell8);
                addressRow.Cells.Add(cell9);
                addressRow.Cells.Add(cell10);
                addressRow.Cells.Add(cell11);

                Table2.Rows.Add(addressRow);
            }

            }

            addressLbl.Text = parentDDL.SelectedItem.Text + "'s address(es).";
            parentLbl.Text = "Remove " + parentDDL.SelectedItem.Text + " from the database?";
        }

        protected void deleteBtn_Click(object sender, EventArgs e)
        {
            try
            {
                DBConnectivity.DeleteChild(int.Parse(TextBox1.Text)); // removes child which matches id entered in the textbox
                uLbl.Text = TextBox1.Text;
                uLbl.Text = "record sucessfully deleted";
            }
            catch (FormatException ex)
            {
                uLbl.Text = ex.ToString();
            }
        }
        protected void deleteAddressBtn_Click(object sender, EventArgs e)
        {
            try
            {
                DBConnectivity.DeleteAddress(int.Parse(TextBox2.Text)); // removes address which matches id entered in the textbox
                uLbl1.Text = TextBox1.Text;
                uLbl1.Text = "record sucessfully deleted";
            }
            catch (FormatException ex)
            {
                uLbl1.Text = ex.ToString();
            }
        }

        protected void deleteParentBtn_Click(object sender, EventArgs e)
        {
            try
            {
                // deletes parent, membership, address and all children
                DBConnectivity.DeleteMembershipByParentID(int.Parse(parentDDL.SelectedValue));
                DBConnectivity.DeleteAddress(int.Parse(parentDDL.SelectedValue));
                DBConnectivity.DeleteChild(int.Parse(parentDDL.SelectedValue));
                DBConnectivity.DeleteParent(int.Parse(parentDDL.SelectedValue));
                uLbl2.Text = "record sucessfully deleted";
            }
            catch (FormatException ex)
            {
                uLbl2.Text = ex.ToString();
            }
        }
    }
}