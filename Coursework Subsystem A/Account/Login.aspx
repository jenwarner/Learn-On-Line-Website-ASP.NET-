<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="Coursework_Subsystem_A.Account.Login" %>
<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" runat="server">
    <style type="text/css">
        .auto-style1 {
            width: 100%;
        }
        .auto-style2 {
            text-align: right;
            width: 440px;
        }
        .auto-style3 {
            width: 440px;
        }
        .auto-style4 {
            width: 278px;
        }
    </style>
</asp:Content>
<asp:Content ID="FeaturedContent" ContentPlaceHolderID="FeaturedContent" runat="server">
     <section class="featured">
        <div class="content-wrapper">
            <hgroup class="title" style="background-color:rgb(84,71,56); height:5px;">
               <!-- <h1><%: Title %> --><h1>Login</h1>
            </hgroup>
            <p></p>
        </div>
    </section>
</asp:Content>
<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
    <asp:RadioButton ID="parentRB" runat="server" AutoPostBack="True" Checked="True" GroupName="RB" Text="Parent" TextAlign="Left" />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
    <asp:RadioButton ID="childRB" runat="server" AutoPostBack="True" GroupName="RB" Text="Student" TextAlign="Left" />
    <br />
    <table class="auto-style1">
        <tr>
            <td class="auto-style2">Username</td>
            <td class="auto-style4">
                <asp:TextBox ID="uNTB" runat="server" Width="180px"></asp:TextBox>
            </td>
            <td>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="uNTB" ErrorMessage="Please enter username" ForeColor="Red"></asp:RequiredFieldValidator>
            </td>
        </tr>
        <tr>
            <td class="auto-style2">Password</td>
            <td class="auto-style4">
                <asp:TextBox ID="pTB" runat="server" TextMode="Password" Width="180px"></asp:TextBox>
            </td>
            <td>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="pTB" ErrorMessage="Please enter password" ForeColor="Red"></asp:RequiredFieldValidator>
            </td>
        </tr>
        <tr>
            <td class="auto-style2">&nbsp;</td>
            <td class="auto-style4">
                <asp:Label ID="uLbl" runat="server" ForeColor="Red"></asp:Label>
            </td>
            <td>
                &nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style3">&nbsp;</td>
            <td class="auto-style4">
                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                <asp:Button ID="loginBtn" runat="server" OnClick="loginBtn_Click" Text="Login" Width="55px" />
            </td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style3">&nbsp;</td>
            <td class="auto-style4">&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
    </table>
</asp:Content>
