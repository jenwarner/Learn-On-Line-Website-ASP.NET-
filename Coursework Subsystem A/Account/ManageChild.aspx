<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="ManageChild.aspx.cs" Inherits="Coursework_Subsystem_A.Account.ManageChild" %>
<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" runat="server">
    <style type="text/css">
    .auto-style1 {
        width: 1304px;
    }
        .auto-style3 {
            height: 26px;
        }
        .auto-style4 {
            width: 28%;
        }
        .auto-style5 {
            width: 12%;
            text-align: left;
        }
        .auto-style6 {
            width: 28%;
            text-align: left;
        }
        .auto-style8 {
            width: 28%;
            text-align: right;
        }
        .auto-style9 {
            height: 26px;
            width: 12%;
        }
        .auto-style10 {
            width: 41%;
        }
        .auto-style11 {
            width: 41%;
            text-align: right;
        }
    </style>
</asp:Content>
<asp:Content ID="FeaturedContent" ContentPlaceHolderID="FeaturedContent" runat="server">
    <section class="featured">
        <div class="content-wrapper">
            <hgroup class="title" style="background-color:rgb(84,71,56); height:5px;">
               <!-- <h1><%: Title %> --><h1>Manage Children</h1>
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
        &nbsp;</p>
    <table class="auto-style1">
        <tr>
            <td class="auto-style10" style="text-align: right">&nbsp;</td>
            <td class="auto-style3" style="text-align: left">
                &nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style10">&nbsp;</td>
            <td class="auto-style3">&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style11">Your children</td>
            <td class="auto-style3">&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style10">&nbsp;</td>
            <td class="auto-style3">
                <asp:Table ID="Table1" runat="server" Width="562px">
                    <asp:TableRow ID="TableRow1" runat="server">
                        <asp:TableCell ID="TableCell1" runat="server">ID</asp:TableCell>
                        <asp:TableCell ID="TableCell2" runat="server">First Name</asp:TableCell>
                        <asp:TableCell ID="TableCell3" runat="server">Surname</asp:TableCell>
                        <asp:TableCell ID="TableCell4" runat="server">Parent ID</asp:TableCell>
                    </asp:TableRow>
                </asp:Table>
            </td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style10">&nbsp;</td>
            <td class="auto-style3">&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style10">&nbsp;</td>
            <td class="auto-style3">
                Enter ID to erase&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                <asp:TextBox ID="TextBox1" runat="server" style="text-align: left" Width="99px"></asp:TextBox>
            </td>
            <td>
                &nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style10">&nbsp;</td>
            <td class="auto-style3">
                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                <asp:Button ID="deleteBtn" runat="server" OnClick="deleteBtn_Click" Text="Delete" Width="100px" />
            </td>
            <td>
                &nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style10">&nbsp;</td>
            <td class="auto-style3">
                <asp:Label ID="uLbl" runat="server" ForeColor="Red"></asp:Label>
            </td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style10">&nbsp;</td>
            <td class="auto-style3">&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
    </table>

    <h5 style="margin-left: 400px">
        Register Child</h5>

    <br />

    <br />
    <table class="auto-style1">
        <tr>
            <td class="auto-style8">First Name</td>
            <td class="auto-style9">
            <asp:TextBox ID="fNTB" runat="server" Width="218px"></asp:TextBox>
            </td>
            <td>
                &nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style8">Last Name</td>
            <td class="auto-style9">
            <asp:TextBox ID="lNTB" runat="server" Width="218px"></asp:TextBox>
            </td>
            <td>
                &nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style8">Date of Birth</td>
            <td class="auto-style5">
                <asp:DropDownList ID="birthDay" runat="server" Height="32px" Width="55px">
                </asp:DropDownList>
                <asp:DropDownList ID="birthMonth" runat="server" Height="32px" Width="100px">
                </asp:DropDownList>
                <asp:DropDownList ID="birthYear" runat="server" Height="30px" Width="71px">
                </asp:DropDownList>
            </td>
            <td class="auto-style6"></td>
        </tr>
        <tr>
            <td class="auto-style8">Sex</td>
            <td class="auto-style9">
                <asp:DropDownList ID="sexDDL" runat="server" Height="31px" Width="227px">
                    <asp:ListItem>Male</asp:ListItem>
                    <asp:ListItem>Female</asp:ListItem>
                </asp:DropDownList>
            </td>
            <td>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator10" runat="server" ErrorMessage="You must select a value!" ForeColor="Red" ControlToValidate="sexDDL" InitialValue="Select"></asp:RequiredFieldValidator>
            </td>
        </tr>
        <tr>
            <td class="auto-style6">&nbsp;</td>
            <td class="auto-style9">&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style8">Username</td>
            <td class="auto-style9">
            <asp:TextBox ID="uTB" runat="server" Width="218px"></asp:TextBox>
            </td>
            <td>
                &nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style8">Password</td>
            <td class="auto-style9">
            <asp:TextBox ID="pWTB" runat="server" Width="218px"></asp:TextBox>
            </td>
            <td>
                &nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style8">Confirm Password</td>
            <td class="auto-style5">
            <asp:TextBox ID="rTB" runat="server" Width="218px"></asp:TextBox>
            </td>
            <td class="auto-style6">
            <asp:CompareValidator ID="CompareValidator1" runat="server" ControlToCompare="pWTB" ControlToValidate="rTB" ErrorMessage="Both passwords must be the same!" ForeColor="Red" style="text-align: left"></asp:CompareValidator>
            </td>
        </tr>
        <tr>
            <td class="auto-style6">&nbsp;</td>
            <td class="auto-style5">
                &nbsp;</td>
            <td class="auto-style6">
                &nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style8">&nbsp;</td>
            <td class="auto-style5">
                &nbsp;</td>
            <td class="auto-style6">
                &nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style4">&nbsp;</td>
            <td class="auto-style9">
            <asp:Label ID="Label1" runat="server" Font-Bold="True" ForeColor="Red"></asp:Label>
            </td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style4">&nbsp;</td>
            <td class="auto-style9">
            <asp:Button ID="submitBtn" runat="server" Text="Submit" Width="106px" OnClick="submitBtn_Click"/>
            <input id="Reset1" type="reset" value="reset" /></td>
            <td>&nbsp;</td>
        </tr>
    </table>
    <br />
</asp:Content>
