<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Payment.aspx.cs" Inherits="Coursework_Subsystem_A.Account.Payment" %>
<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" runat="server">
    <style type="text/css">
    .auto-style1 {
        width: 100%;
    }
    .auto-style2 {
        text-align: right;
        width: 341px;
    }
    .auto-style3 {
        text-align: right;
        width: 341px;
        height: 26px;
    }
    .auto-style4 {
        height: 26px;
    }
    .auto-style5 {
        width: 547px;
    }
    .auto-style6 {
        height: 26px;
        width: 547px;
    }
        .auto-style7 {
            text-align: right;
            width: 341px;
            height: 33px;
        }
        .auto-style8 {
            width: 547px;
            height: 33px;
        }
        .auto-style9 {
            height: 33px;
        }
        #Reset1 {
            width: 108px;
        }
    </style>
</asp:Content>
<asp:Content ID="FeaturedContent" ContentPlaceHolderID="FeaturedContent" runat="server">
    <section class="featured">
        <div class="content-wrapper">
            <hgroup class="title" style="background-color:rgb(84,71,56); height:5px;">
               <!-- <h1><%: Title %> --><h1>Purchase Our Services</h1>
            </hgroup>
            <p></p>
        </div>
    </section>
</asp:Content>
<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    <asp:Label ID="outLbl" runat="server"></asp:Label>
<br />
<table class="auto-style1">
    <tr>
        <td class="auto-style2">&nbsp;</td>
        <td class="auto-style5">
            <asp:Label ID="childCountLbl" runat="server"></asp:Label>
            <asp:Button ID="regChildBtn" runat="server" Height="37px" OnClick="regChildBtn_Click" Text="Register Child" Width="161px" />
        </td>
        <td>&nbsp;</td>
    </tr>
    <tr>
        <td class="auto-style2">
            <asp:Label ID="totalLbl0" runat="server" Text="Total"></asp:Label>
        </td>
        <td class="auto-style5">
            <asp:Label ID="totalLbl" runat="server"></asp:Label>
        </td>
        <td>&nbsp;</td>
    </tr>
    <tr>
        <td class="auto-style2">&nbsp;</td>
        <td class="auto-style5">
            <asp:RadioButton ID="gBPRB" runat="server" AutoPostBack="True" Checked="True" GroupName="currency" Text="GBP" />
&nbsp;&nbsp;
            <asp:RadioButton ID="eRB" runat="server" AutoPostBack="True" GroupName="currency" Text="Euros" />
&nbsp;&nbsp;
            <asp:RadioButton ID="uRB" runat="server" AutoPostBack="True" GroupName="currency" Text="US Dollars" />
&nbsp;&nbsp;
            <asp:RadioButton ID="ausRB" runat="server" AutoPostBack="True" GroupName="currency" Text="Australian Dollars" />
        </td>
        <td>&nbsp;</td>
    </tr>
    <tr>
        <td class="auto-style2">
            <asp:Label ID="billingAdLbl" runat="server" Text="Billing Address"></asp:Label>
        </td>
        <td class="auto-style5">
                <asp:Table ID="Table1" runat="server" Width="931px">
                    <asp:TableRow runat="server">
                        <asp:TableCell runat="server">House Name</asp:TableCell>
                        <asp:TableCell runat="server">House Number</asp:TableCell>
                        <asp:TableCell runat="server">Street Name</asp:TableCell>
                        <asp:TableCell runat="server">City</asp:TableCell>
                        <asp:TableCell runat="server">Postcode</asp:TableCell>
                        <asp:TableCell runat="server">Country</asp:TableCell>
                    </asp:TableRow>
                </asp:Table>
        </td>
        <td>&nbsp;</td>
    </tr>
    <tr>
        <td class="auto-style3">
            <asp:Label ID="cNLbl0" runat="server" Text="Cardholder Name"></asp:Label>
        </td>
        <td class="auto-style6">
            <asp:Label ID="cNLbl" runat="server"></asp:Label>
        </td>
        <td class="auto-style4"></td>
    </tr>
    <tr>
        <td class="auto-style3">
            <asp:Label ID="cardTypeLbl" runat="server" Text="Card Type"></asp:Label>
        </td>
        <td class="auto-style6">
            <asp:DropDownList ID="cardDDL" runat="server" Height="30px" Width="260px">
                <asp:ListItem>Visa Debit</asp:ListItem>
                <asp:ListItem>Mastercard</asp:ListItem>
                <asp:ListItem>American Express</asp:ListItem>
            </asp:DropDownList>
        </td>
        <td class="auto-style4"></td>
    </tr>
    <tr>
        <td class="auto-style2">
            <asp:Label ID="cardNoLbl" runat="server" Text="Card Number"></asp:Label>
        </td>
        <td class="auto-style5">
            <asp:TextBox ID="cNoTB" runat="server" Height="25px" Width="247px"></asp:TextBox>
        &nbsp;<asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" ControlToValidate="cNoTB" ErrorMessage="You must enter a valid card number." ForeColor="Red" ValidationExpression="^4[0-9]{12}(?:[0-9]{3})?$"></asp:RegularExpressionValidator>
        </td>
        <td>&nbsp;</td>
    </tr>
    <tr>
        <td class="auto-style7">
            <asp:Label ID="sDateLbl" runat="server" Text="Start Date"></asp:Label>
        </td>
        <td class="auto-style8">
                <asp:DropDownList ID="startDay" runat="server" Height="32px" Width="55px">
                </asp:DropDownList>
                <asp:DropDownList ID="startMonth" runat="server" Height="32px" Width="100px">
                </asp:DropDownList>
                <asp:DropDownList ID="sYear" runat="server" Height="30px" Width="71px">
                </asp:DropDownList>
            </td>
        <td class="auto-style9">
            <asp:Image ID="Image1" runat="server" />
        </td>
    </tr>
    <tr>
        <td class="auto-style2">
            <asp:Label ID="eDateLbl" runat="server" Text="End Date"></asp:Label>
        </td>
        <td class="auto-style5">
                <asp:DropDownList ID="endDay" runat="server" Height="32px" Width="55px">
                </asp:DropDownList>
                <asp:DropDownList ID="endMonth" runat="server" Height="32px" Width="100px">
                </asp:DropDownList>
                <asp:DropDownList ID="endYear" runat="server" Height="30px" Width="71px">
                </asp:DropDownList>
            </td>
        <td>&nbsp;</td>
    </tr>
    <tr>
        <td class="auto-style2">
            <asp:Label ID="cV2Lbl" runat="server" Text="CV2"></asp:Label>
        </td>
        <td class="auto-style5">
            <asp:TextBox ID="cV2TB" runat="server" Width="44px" MaxLength="4"></asp:TextBox>
        &nbsp;<asp:RegularExpressionValidator ID="RegularExpressionValidator2" runat="server" ControlToValidate="cV2TB" ErrorMessage="You must enter a valid number." ForeColor="Red" ValidationExpression="^(?!000)\d{3,4}$"></asp:RegularExpressionValidator>
        </td>
        <td>&nbsp;</td>
    </tr>
    <tr>
        <td class="auto-style2">&nbsp;</td>
        <td class="auto-style5">&nbsp;</td>
        <td>&nbsp;</td>
    </tr>
    <tr>
        <td class="auto-style2">&nbsp;</td>
        <td class="auto-style5">
            <asp:Button ID="submitBtn" runat="server" Height="37px" OnClick="submitBtn_Click" Text="Submit" Width="111px" />
            <input id="Reset1" type="reset" value="reset" /></td>
        <td>&nbsp;</td>
    </tr>
    <tr>
        <td class="auto-style2">&nbsp;</td>
        <td class="auto-style5">&nbsp;</td>
        <td>&nbsp;</td>
    </tr>
</table>

</asp:Content>
