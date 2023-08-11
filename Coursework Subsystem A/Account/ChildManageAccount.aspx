<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="ChildManageAccount.aspx.cs" Inherits="Coursework_Subsystem_A.Account.ChildManageAccount" %>
<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="FeaturedContent" runat="server">
    <section class="featured">
        <div class="content-wrapper">
            <hgroup class="title" style="background-color:rgb(84,71,56); height:5px;">
               <!-- <h1><%: Title %> --><h1>My Account</h1>
            </hgroup>
            <p></p>
        </div>
    </section>
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="MainContent" runat="server">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                <asp:Label ID="mainLbl" runat="server"></asp:Label>
            <br />
    <table class="auto-style1">
         <tr>
            <td class="auto-style2">Change Username</td>
            <td class="auto-style4">
                <asp:TextBox ID="uNTB" runat="server" Width="400px"></asp:TextBox>
            </td>
            <td>
                <asp:Button ID="updateUNBtn" runat="server" Height="41px" OnClick="updateUNBtn_Click" Text="Update" Width="214px" />
            </td>
        </tr>
        <tr>
            <td class="auto-style2">&nbsp;</td>
            <td class="auto-style4">
                <asp:Label ID="uNLbl" runat="server"></asp:Label>
            </td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style2">Change Password</td>
            <td class="auto-style4">
                <asp:TextBox ID="pTB" runat="server" TextMode="Password" Width="400px"></asp:TextBox>
            </td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style5"></td>
            <td class="auto-style6">
                <asp:Label ID="pWLbl" runat="server"></asp:Label>
            </td>
            <td class="auto-style7"></td>
        </tr>
        <tr>
            <td class="auto-style2">Confirm Password</td>
            <td class="auto-style4">
                <asp:TextBox ID="rTB" runat="server" TextMode="Password" Width="400px"></asp:TextBox>
            </td>
            <td>
                <asp:Button ID="updateRPWBtn" runat="server" Height="41px" OnClick="updateRPWBtn_Click" Text="Update" Width="214px" />
            </td>
        </tr>
        <tr>
            <td class="auto-style8"></td>
            <td class="auto-style9">
                <asp:CompareValidator ID="CompareValidator1" runat="server" ControlToCompare="pTB" ControlToValidate="rTB" ErrorMessage="You must re-enter your password" ForeColor="Red"></asp:CompareValidator>
                &nbsp;&nbsp;&nbsp;
                </td>
            <td class="auto-style10"></td>
        </tr>
        <tr>
            <td class="auto-style2">&nbsp;</td>
            <td class="auto-style4">&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        </table>
</asp:Content>
