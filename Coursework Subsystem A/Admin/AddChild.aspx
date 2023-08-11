<%@ Page Title="" Language="C#" MasterPageFile="~/AdminSite.Master" AutoEventWireup="true" CodeBehind="AddChild.aspx.cs" Inherits="Coursework_Subsystem_A.Admin.AddChild" %>
<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" runat="server">
    <style type="text/css">
        .auto-style1 {
            width: 100%;
        }
        .auto-style2 {
            text-align: right;
            width: 281px;
        }
        .auto-style3 {
        width: 243px;
        text-align: left;
    }
        #Reset1 {
            width: 104px;
        }
        .auto-style4 {
            text-align: right;
            width: 281px;
            height: 29px;
        }
        .auto-style5 {
        width: 243px;
        text-align: left;
        height: 29px;
    }
        .auto-style6 {
            height: 29px;
        }
    </style>
</asp:Content>
<asp:Content ID="FeaturedContent" ContentPlaceHolderID="FeaturedContent" runat="server">
    <section class="featured">
        <div class="content-wrapper">
            <hgroup class="title" style="background-color:rgb(84,71,56); height:5px;">
               <!-- <h1><%: Title %> --><h1>Add Child to Database</h1>
            </hgroup>
            <p></p>
        </div>
    </section>
</asp:Content>
<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <p>
    Add a Child to database ADMIN USE (for special circumstances e.g if parent telephoned company to register :))</p>
    <table class="auto-style1">
        <tr>
            <td class="auto-style2">First Name</td>
            <td class="auto-style3">
            <asp:TextBox ID="fNTB" runat="server" Width="218px"></asp:TextBox>
            </td>
            <td>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="fNTB" ErrorMessage="First name is required" ForeColor="Red"></asp:RequiredFieldValidator>
            </td>
        </tr>
        <tr>
            <td class="auto-style2">Last Name</td>
            <td class="auto-style3">
            <asp:TextBox ID="lNTB" runat="server" Width="218px"></asp:TextBox>
            </td>
            <td>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="lNTB" ErrorMessage="Last name is required" ForeColor="Red"></asp:RequiredFieldValidator>
            </td>
        </tr>
        <tr>
            <td class="auto-style4">Date of Birth</td>
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
            <td class="auto-style2">Sex</td>
            <td class="auto-style3">
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
            <td class="auto-style2">&nbsp;</td>
            <td class="auto-style3">&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style2">Username</td>
            <td class="auto-style3">
            <asp:TextBox ID="uTB" runat="server" Width="218px"></asp:TextBox>
            </td>
            <td>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator8" runat="server" ControlToValidate="uTB" ErrorMessage="Username is required" ForeColor="Red"></asp:RequiredFieldValidator>
            </td>
        </tr>
        <tr>
            <td class="auto-style2">Password</td>
            <td class="auto-style3">
            <asp:TextBox ID="pWTB" runat="server" Width="218px" TextMode="Password"></asp:TextBox>
            </td>
            <td>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator9" runat="server" ControlToValidate="pWTB" ErrorMessage="Password is required" ForeColor="Red"></asp:RequiredFieldValidator>
            </td>
        </tr>
        <tr>
            <td class="auto-style4">Confirm Password</td>
            <td class="auto-style5">
            <asp:TextBox ID="rTB" runat="server" Width="218px" TextMode="Password"></asp:TextBox>
            </td>
            <td class="auto-style6">
            <asp:CompareValidator ID="CompareValidator1" runat="server" ControlToCompare="pWTB" ControlToValidate="rTB" ErrorMessage="Both passwords must be the same!" ForeColor="Red"></asp:CompareValidator>
            </td>
        </tr>
        <tr>
            <td class="auto-style4">&nbsp;</td>
            <td class="auto-style5">
                &nbsp;</td>
            <td class="auto-style6">
                &nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style4">Parent Username</td>
            <td class="auto-style5">
            <asp:TextBox ID="pUTB" runat="server" Width="218px"></asp:TextBox>
            </td>
            <td class="auto-style6">
            <asp:RequiredFieldValidator ID="RequiredFieldValidator11" runat="server" ControlToValidate="pUTB" ErrorMessage="Parent username is required" ForeColor="Red"></asp:RequiredFieldValidator>
            </td>
        </tr>
        <tr>
            <td class="auto-style2">&nbsp;</td>
            <td class="auto-style3">
            <asp:Label ID="uLbl" runat="server" Font-Bold="True" ForeColor="Red"></asp:Label>
            </td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style2">&nbsp;</td>
            <td class="auto-style3">
            <asp:Button ID="submitBtn" runat="server" Text="Submit" Width="106px" OnClick="submitBtn_Click"/>
            <input id="Reset1" type="reset" value="reset" /></td>
            <td>&nbsp;</td>
        </tr>
    </table>
</asp:Content>
