<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="ParentAddAddress.aspx.cs" Inherits="Coursework_Subsystem_A.Account.ParentAddAddress" %>
<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" runat="server">
    <style type="text/css">
        .auto-style1 {
            width: 100%;
        }
        .auto-style2 {
            text-align: right;
            width: 285px;
        }
        .auto-style3 {
            width: 218px;
            text-align: left;
        }
        #Reset1 {
            width: 106px;
        }
    </style>
</asp:Content>
<asp:Content ID="FeaturedContent" ContentPlaceHolderID="FeaturedContent" runat="server">
    <section class="featured">
        <div class="content-wrapper">
            <hgroup class="title" style="background-color:rgb(84,71,56); height:5px;">
               <!-- <h1><%: Title %> --><h1>Add Your Address</h1>
            </hgroup>
            <p></p>
        </div>
    </section>
</asp:Content>
<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    
    <p>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <br />
        <table class="auto-style1">
            <tr>
                <td class="auto-style2">Name</td>
                <td class="auto-style3">
                    <asp:Label ID="nameLbl" runat="server"></asp:Label>
                </td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style2">House Name</td>
                <td class="auto-style3">
            <asp:TextBox ID="hNTB" runat="server" Width="218px"></asp:TextBox>
                </td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style2">House Number</td>
                <td class="auto-style3">
            <asp:TextBox ID="hNOTB" runat="server" Width="218px"></asp:TextBox>
                </td>
                <td>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ControlToValidate="hNOTB" ErrorMessage="House number is required" ForeColor="Red"></asp:RequiredFieldValidator>
                </td>
            </tr>
            <tr>
                <td class="auto-style2">Street Name</td>
                <td class="auto-style3">
            <asp:TextBox ID="sNTB" runat="server" Width="218px"></asp:TextBox>
                </td>
                <td>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server" ControlToValidate="sNTB" ErrorMessage="Street Name is required" ForeColor="Red"></asp:RequiredFieldValidator>
                </td>
            </tr>
            <tr>
                <td class="auto-style2">City</td>
                <td class="auto-style3">
            <asp:TextBox ID="cTB" runat="server" Width="218px"></asp:TextBox>
                </td>
                <td>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator5" runat="server" ControlToValidate="cTB" ErrorMessage="City is required" ForeColor="Red"></asp:RequiredFieldValidator>
                </td>
            </tr>
            <tr>
                <td class="auto-style2">Postcode</td>
                <td class="auto-style3">
            <asp:TextBox ID="pTB" runat="server" Width="218px"></asp:TextBox>
                </td>
                <td>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator6" runat="server" ControlToValidate="pTB" ErrorMessage="Postcode is required" ForeColor="Red"></asp:RequiredFieldValidator>
                </td>
            </tr>
            <tr>
                <td class="auto-style2">Country</td>
                <td class="auto-style3">
            <asp:DropDownList ID="countryDDL" runat="server" Height="35px" Width="225px">
                <asp:ListItem>- Select Country -</asp:ListItem>
                <asp:ListItem>United Kingdom</asp:ListItem>
                <asp:ListItem>Republic of Ireland</asp:ListItem>
                <asp:ListItem>Isle of Man</asp:ListItem>
                <asp:ListItem>Northern Ireland</asp:ListItem>
                <asp:ListItem>France</asp:ListItem>
                <asp:ListItem>Germany</asp:ListItem>
                <asp:ListItem>Holland</asp:ListItem>
                <asp:ListItem>Belgium</asp:ListItem>
                <asp:ListItem>Spain</asp:ListItem>
                <asp:ListItem>Italy</asp:ListItem>
                <asp:ListItem>Gibralta</asp:ListItem>
                <asp:ListItem>Republic of Korea</asp:ListItem>
                <asp:ListItem>Democratic People&#39;s Republic of Korea</asp:ListItem>
                <asp:ListItem>China</asp:ListItem>
                <asp:ListItem>Hong Kong</asp:ListItem>
                <asp:ListItem>Japan</asp:ListItem>
                <asp:ListItem>United States of America</asp:ListItem>
                <asp:ListItem>Australia</asp:ListItem>
            </asp:DropDownList>
                </td>
                <td>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator7" runat="server" ControlToValidate="countryDDL" ErrorMessage="Country is required" ForeColor="Red" InitialValue="- Select Country -"></asp:RequiredFieldValidator>
                </td>
            </tr>
            <tr>
                <td class="auto-style2">&nbsp;</td>
                <td class="auto-style3">&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style2">&nbsp;</td>
                <td class="auto-style3">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Label ID="uLbl" runat="server" Font-Bold="True" ForeColor="Red" style="text-align: center"></asp:Label>
                </td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style2">&nbsp;</td>
                <td class="auto-style3">
            <asp:Button ID="submitBtn" runat="server" Text="Submit" Width="106px" OnClick="submitBtn_Click" />
            <input id="Reset1" type="reset" value="reset" /></td>
                <td>&nbsp;</td>
            </tr>
        </table>
    </p>
    
</asp:Content>
