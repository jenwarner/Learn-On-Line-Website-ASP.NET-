<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="ParentManageAccount.aspx.cs" Inherits="Coursework_Subsystem_A.Account.ParentManageAccount" %>
<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" runat="server">
    <style type="text/css">
        .auto-style1 {
            width: 100%;
        }
        .auto-style2 {
        width: 614px;
        text-align: right;
    }
        .auto-style4 {
            width: 563px;
            text-align: center;
        }
        .auto-style5 {
            width: 614px;
            text-align: right;
            height: 31px;
        }
        .auto-style6 {
            width: 563px;
            height: 31px;
            text-align: center;
        }
        .auto-style7 {
            height: 31px;
        }
    .auto-style8 {
        width: 614px;
        text-align: right;
        height: 26px;
    }
    .auto-style9 {
        width: 563px;
        text-align: center;
        height: 26px;
    }
    .auto-style10 {
        height: 26px;
    }
    </style>
</asp:Content>
<asp:Content ID="FeaturedContent" ContentPlaceHolderID="FeaturedContent" runat="server">
    <section class="featured">
        <div class="content-wrapper">
            <hgroup class="title" style="background-color:rgb(84,71,56); height:5px;">
               <!-- <h1><%: Title %> --><h1>Manage Account</h1>
            </hgroup>
            <p></p>
        </div>
    </section>
</asp:Content>
<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <table class="auto-style1">
        <tr>
            <td class="auto-style2">&nbsp;</td>
            <td class="auto-style4">
                <asp:Label ID="mainLbl" runat="server"></asp:Label>
            </td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style2">Change First Name</td>
            <td class="auto-style4">
                <asp:TextBox ID="fNTB" runat="server" Width="400px"></asp:TextBox>
            </td>
            <td>
                <asp:Button ID="updateFNBtn" runat="server" Height="41px" OnClick="updateFNBtn_Click" Text="Update" Width="214px" />
            </td>
        </tr>
        <tr>
            <td class="auto-style2">&nbsp;</td>
            <td class="auto-style4">
                <asp:Label ID="fNLbl" runat="server"></asp:Label>
            </td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style2">Change Surname</td>
            <td class="auto-style4">
                <asp:TextBox ID="lNTB" runat="server" Width="400px"></asp:TextBox>
            </td>
            <td>
                <asp:Button ID="updateLNBtn" runat="server" Height="41px" OnClick="updateLNBtn_Click" Text="Update" Width="214px" />
            </td>
        </tr>
        <tr>
            <td class="auto-style8"></td>
            <td class="auto-style9">
                <asp:Label ID="sNLbl" runat="server"></asp:Label>
            </td>
            <td class="auto-style10"></td>
        </tr>
        <tr>
            <td class="auto-style8">Change Tel No.</td>
            <td class="auto-style9">
                <asp:TextBox ID="tNTB" runat="server" Width="400px"></asp:TextBox>
            </td>
            <td class="auto-style10">
                <asp:Button ID="updateTNBtn" runat="server" Height="41px" OnClick="updateTNBtn_Click" Text="Update" Width="214px" />
            </td>
        </tr>
        <tr>
            <td class="auto-style8">&nbsp;</td>
            <td class="auto-style9">
                <asp:Label ID="tNLbl" runat="server"></asp:Label>
            </td>
            <td class="auto-style10">&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style8">Change Email</td>
            <td class="auto-style9">
                <asp:TextBox ID="eTB" runat="server" Width="400px"></asp:TextBox>
            </td>
            <td class="auto-style10">
                <asp:Button ID="updateEBtn" runat="server" Height="41px" OnClick="updateEBtn_Click" Text="Update" Width="214px" />
            </td>
        </tr>
        <tr>
            <td class="auto-style8">&nbsp;</td>
            <td class="auto-style9">
                <asp:Label ID="eLbl" runat="server"></asp:Label>
            </td>
            <td class="auto-style10">&nbsp;</td>
        </tr>
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
        <tr>
            <td class="auto-style2">Add Address(es)</td>
            <td class="auto-style4">
                <asp:Button ID="addressBtn" runat="server" Height="41px" Text="Add Address" OnClick="addressBtn_Click" />
            </td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style2">&nbsp;</td>
            <td class="auto-style4">&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style2"><b>Delete Account (this will also remove your children&#39;s account)</b></td>
            <td class="auto-style4">
                <asp:Button ID="deleteAccountBtn" runat="server" Height="41px" Text="Delete Account" OnClick="deleteAccountBtn_Click" />
            </td>
            <td>&nbsp;</td>
        </tr>
    </table>
</asp:Content>
