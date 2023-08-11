<%@ Page Title="" Language="C#" MasterPageFile="~/AdminSite.Master" AutoEventWireup="true" CodeBehind="ManageDatabase.aspx.cs" Inherits="Coursework_Subsystem_A.Admin.ManageDatabase" %>
<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" runat="server">
    <style type="text/css">
        .auto-style1 {
            width: 100%;
        }
        .auto-style2 {
            width: 360px;
            text-align: right;
        }
        .auto-style3 {
            width: 523px;
            text-align: left;
        }
        .auto-style4 {
            width: 925px;
        }
        .auto-style5 {
            width: 282px;
            text-align: right;
        }
        .auto-style6 {
            width: 282px;
            text-align: right;
            height: 26px;
        }
        .auto-style7 {
            width: 925px;
            height: 26px;
        }
        .auto-style8 {
            height: 26px;
        }
        .auto-style9 {
            width: 282px;
            text-align: right;
            height: 33px;
        }
        .auto-style10 {
            width: 925px;
            height: 33px;
        }
        .auto-style11 {
            height: 33px;
        }
        .auto-style12 {
            width: 285px;
        }
        .auto-style13 {
            width: 527px;
        }
    </style>
</asp:Content>
<asp:Content ID="FeaturedContent" ContentPlaceHolderID="FeaturedContent" runat="server">
    <section class="featured">
        <div class="content-wrapper">
            <hgroup class="title" style="background-color:rgb(84,71,56); height:5px;">
               <!-- <h1><%: Title %> --><h1>Manage Database</h1>
            </hgroup>
            <p></p>
        </div>
    </section>
</asp:Content>
<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    <p>
        &nbsp;</p>
    <h5 style="margin-left: 400px">
        Remove Child</h5>
    <p>
        Select a parent from the drop down menu to view their children stored in the database</p>
    <table class="auto-style1">
        <tr>
            <td class="auto-style2" style="text-align: right">&nbsp;Search by Parent</td>
            <td class="auto-style3" style="text-align: left">
                <asp:DropDownList ID="parentDDL" runat="server" AutoPostBack="True" Height="41px" Width="279px">
                </asp:DropDownList>
            </td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style2">&nbsp;</td>
            <td class="auto-style3">&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style2">&nbsp;</td>
            <td class="auto-style3">&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style2">&nbsp;</td>
            <td class="auto-style3">
                <asp:Table ID="Table1" runat="server" Width="562px">
                    <asp:TableRow runat="server">
                        <asp:TableCell runat="server">ID</asp:TableCell>
                        <asp:TableCell runat="server">First Name</asp:TableCell>
                        <asp:TableCell runat="server">Surname</asp:TableCell>
                        <asp:TableCell runat="server">Parent ID</asp:TableCell>
                    </asp:TableRow>
                </asp:Table>
            </td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style2">&nbsp;</td>
            <td class="auto-style3">&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style2">&nbsp;</td>
            <td class="auto-style3">
                Enter ID to erase&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                <asp:TextBox ID="TextBox1" runat="server" style="text-align: left" Width="99px"></asp:TextBox>
            </td>
            <td>
                &nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style2">&nbsp;</td>
            <td class="auto-style3">
                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                <asp:Button ID="deleteBtn" runat="server" OnClick="deleteBtn_Click" Text="Delete" Width="100px" />
            </td>
            <td>
                &nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style2">&nbsp;</td>
            <td class="auto-style3">
                <asp:Label ID="uLbl" runat="server" ForeColor="Red"></asp:Label>
            </td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style2">&nbsp;</td>
            <td class="auto-style3">&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
    </table>

    <br />
    <br />
    <h5 style="margin-left: 400px">
        Remove Address</h5>
    <asp:Label ID="addressLbl" runat="server" Font-Bold="True" Font-Size="Medium"></asp:Label>
    <br />
    <table class="auto-style1">
        <tr>
            <td class="auto-style5">&nbsp;</td>
            <td class="auto-style4">
                <asp:Table ID="Table2" runat="server" Width="931px">
                    <asp:TableRow runat="server">
                        <asp:TableCell runat="server">ID</asp:TableCell>
                        <asp:TableCell runat="server">House Name</asp:TableCell>
                        <asp:TableCell runat="server">House Number</asp:TableCell>
                        <asp:TableCell runat="server">Street Name</asp:TableCell>
                        <asp:TableCell runat="server">City</asp:TableCell>
                        <asp:TableCell runat="server">Postcode</asp:TableCell>
                        <asp:TableCell runat="server">Country</asp:TableCell>
                        <asp:TableCell runat="server">Parent ID</asp:TableCell>
                    </asp:TableRow>
                </asp:Table>
            </td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style5">&nbsp;</td>
            <td class="auto-style4">&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style9">&nbsp;</td>
            <td class="auto-style10">
                Enter ID to erase&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                <asp:TextBox ID="TextBox2" runat="server" Width="100px"></asp:TextBox>
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            </td>
            <td class="auto-style11">&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style5">&nbsp;</td>
            <td class="auto-style4">
                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                <asp:Button ID="deleteAddressBtn" runat="server" OnClick="deleteAddressBtn_Click" Text="Delete" Width="100px" style="margin-right: 0px" />
            </td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style6"></td>
            <td class="auto-style7">
                <asp:Label ID="uLbl1" runat="server" ForeColor="Red"></asp:Label>
            </td>
            <td class="auto-style8"></td>
        </tr>
        <tr>
            <td class="auto-style6"></td>
            <td class="auto-style7"></td>
            <td class="auto-style8"></td>
        </tr>
        </table>

    <br />
    <h5 style="margin-left: 400px">
        Remove Selected Parent</h5>
    <table class="auto-style1">
        <tr>
            <td class="auto-style12">
                <asp:Label ID="parentLbl" runat="server" Font-Bold="True"></asp:Label>
            </td>
            <td class="auto-style13">
                <asp:Button ID="deleteParentBtn" runat="server" OnClick="deleteParentBtn_Click" Text="Remove Parent" Width="421px" />
            </td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style12">&nbsp;</td>
            <td class="auto-style13">
                <asp:Label ID="uLbl2" runat="server" ForeColor="Red"></asp:Label>
            </td>
            <td>&nbsp;</td>
        </tr>
    </table>

</asp:Content>
