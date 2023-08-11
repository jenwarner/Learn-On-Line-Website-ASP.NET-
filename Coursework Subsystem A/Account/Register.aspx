<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Register.aspx.cs" Inherits="Coursework_Subsystem_A.Account.Register" %>
<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" runat="server">
    <style type="text/css">
        .auto-style1 {
            width: 100%;
        }
        .auto-style2 {
            height: 31px;
        }
        .auto-style3 {
            height: 31px;
            text-align: center;
            width: 229px;
        }
        .auto-style4 {
            text-align: center;
            width: 229px;
        }
        .auto-style5 {
            width: 229px;
        }
        .auto-style6 {
            height: 31px;
            width: 180px;
        }
        .auto-style7 {
            width: 180px;
            text-align: center;
        }
        .auto-style8 {
            text-align: left;
        }
        .auto-style9 {
            height: 31px;
            text-align: left;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="FeaturedContent" runat="server">
</asp:Content>
<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
    <asp:RadioButton ID="parentRB" runat="server" AutoPostBack="True" Checked="True" GroupName="RB" Text="Parent" TextAlign="Left" />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
    <asp:RadioButton ID="childRB" runat="server" AutoPostBack="True" GroupName="RB" Text="Student" TextAlign="Left" />
    <br />
    <br />
    <br />
    <table class="auto-style1">
        <tr>
            <td class="auto-style3">
                <asp:Label ID="fNLbl" runat="server" Text="First Name"></asp:Label>
            </td>
            <td class="auto-style6">
                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                <asp:TextBox ID="fNTB" runat="server" Width="180px"></asp:TextBox>
            </td>
            <td class="auto-style2">
                <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="fNTB" ErrorMessage="First name is required" ForeColor="Red"></asp:RequiredFieldValidator>
            </td>
        </tr>
        <tr>
            <td class="auto-style3">
                <asp:Label ID="lNLbl" runat="server" Text="Surname"></asp:Label>
            </td>
            <td class="auto-style6">
                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                <asp:TextBox ID="lNTB" runat="server" Width="180px"></asp:TextBox>
            </td>
            <td class="auto-style9">
                <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="lNTB" ErrorMessage="Last name is required" ForeColor="Red"></asp:RequiredFieldValidator>
            </td>
        </tr>
        <tr>
            <td class="auto-style3">
                <asp:Label ID="tNLbl" runat="server" Text="Tel No."></asp:Label>
            </td>
            <td class="auto-style6">
                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                <asp:TextBox ID="tNTB" runat="server" Width="180px"></asp:TextBox>
            </td>
            <td class="auto-style2">
                <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ControlToValidate="tNTB" ErrorMessage="Tel no is required" ForeColor="Red" style="text-align: left"></asp:RequiredFieldValidator>
                <br />
                <asp:RegularExpressionValidator ID="RegularExpressionValidator2" runat="server" ControlToValidate="tNTB" ErrorMessage="you must enter a valid tel no" ForeColor="Red" ValidationExpression="^(((\+44\s?\d{4}|\(?0\d{4}\)?)\s?\d{3}\s?\d{3})|((\+44\s?\d{3}|\(?0\d{3}\)?)\s?\d{3}\s?\d{4})|((\+44\s?\d{2}|\(?0\d{2}\)?)\s?\d{4}\s?\d{4}))(\s?\#(\d{4}|\d{3}))?$"></asp:RegularExpressionValidator>
            </td>
        </tr>
        <tr>
            <td class="auto-style4">
                <asp:Label ID="eLbl" runat="server" Text="Email"></asp:Label>
            </td>
            <td class="auto-style7">
                <asp:TextBox ID="eTB" runat="server" Width="180px"></asp:TextBox>
            </td>
            <td class="auto-style8">
                <asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server" ControlToValidate="eTB" ErrorMessage="email is required" ForeColor="Red"></asp:RequiredFieldValidator>
                <br />
                <asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" ControlToValidate="eTB" ErrorMessage="you must enter a valid email" ForeColor="Red" ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*"></asp:RegularExpressionValidator>
            </td>
        </tr>
        <tr>
            <td class="auto-style4">
                <asp:Label ID="uLbl" runat="server" Text="Username"></asp:Label>
            </td>
            <td class="auto-style7">
                <asp:TextBox ID="uNTB" runat="server" Width="180px"></asp:TextBox>
            </td>
            <td class="auto-style8">
                <asp:RequiredFieldValidator ID="RequiredFieldValidator5" runat="server" ControlToValidate="uNTB" ErrorMessage="username is required" ForeColor="Red"></asp:RequiredFieldValidator>
            </td>
        </tr>
        <tr>
            <td class="auto-style4">
                <asp:Label ID="pLbl" runat="server" Text="Password"></asp:Label>
            </td>
            <td class="auto-style7">
                <asp:TextBox ID="pTB" runat="server" TextMode="Password" Width="180px"></asp:TextBox>
            </td>
            <td class="auto-style8">
                <asp:RequiredFieldValidator ID="RequiredFieldValidator6" runat="server" ControlToValidate="pTB" ErrorMessage="password is required" ForeColor="Red"></asp:RequiredFieldValidator>
            </td>
        </tr>
        <tr>
            <td class="auto-style4">
                <asp:Label ID="rLbl" runat="server" Text="Confirm Password"></asp:Label>
            </td>
            <td class="auto-style7">
                <asp:TextBox ID="rTB" runat="server" TextMode="Password" Width="180px"></asp:TextBox>
            </td>
            <td class="auto-style8">
                <asp:RequiredFieldValidator ID="RequiredFieldValidator7" runat="server" ControlToValidate="rTB" ErrorMessage="please confirm your password" ForeColor="Red"></asp:RequiredFieldValidator>
                <br />
                <asp:CompareValidator ID="CompareValidator1" runat="server" ControlToCompare="pTB" ControlToValidate="rTB" ErrorMessage="Both passwords must be the same!" ForeColor="Red"></asp:CompareValidator>
            </td>
        </tr>
        <tr>
            <td class="auto-style4">
                <asp:Label ID="pULbl" runat="server" Text="Parent's Username"></asp:Label>
            </td>
            <td class="auto-style7">
                <asp:TextBox ID="pUTB" runat="server" Width="180px"></asp:TextBox>
            </td>
            <td class="auto-style8">
                <asp:RequiredFieldValidator ID="RequiredFieldValidator8" runat="server" ControlToValidate="pUTB" ErrorMessage="Your username is required" ForeColor="Red"></asp:RequiredFieldValidator>
            </td>
        </tr>
        <tr>
            <td class="auto-style4">
                &nbsp;</td>
            <td class="auto-style7">
                <asp:Label ID="outputLbl" runat="server" ForeColor="Red"></asp:Label>
            </td>
            <td class="auto-style8">
                &nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style5">&nbsp;</td>
            <td class="auto-style7">
                <asp:Button ID="submitBtn" runat="server" OnClick="submitBtn_Click" Text="Submit" />
                <input id="Reset1" type="reset" value="reset" /></td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style5">&nbsp;</td>
            <td class="auto-style7">&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
    </table>
</asp:Content>
