<%@ Page Title="" Language="C#" MasterPageFile="~/AdminSite.Master" AutoEventWireup="true" CodeBehind="AddParent.aspx.cs" Inherits="Coursework_Subsystem_A.AddParent" %>
<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" runat="server">
    <style type="text/css">
    .auto-style1 {
        width: 100%;
    }
    .auto-style2 {
        width: 264px;
    }
    .auto-style3 {
        width: 264px;
        text-align: right;
    }
    .auto-style4 {
        width: 228px;
        text-align: center;
    }
    .auto-style5 {
        width: 264px;
        text-align: right;
        height: 26px;
    }
    .auto-style6 {
        width: 228px;
        height: 26px;
    }
    .auto-style7 {
        height: 26px;
    }
    .auto-style8 {
        width: 264px;
        text-align: right;
        height: 29px;
    }
    .auto-style9 {
        width: 228px;
        height: 29px;
    }
    .auto-style10 {
        height: 29px;
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
               <!-- <h1><%: Title %> --><h1>Add Parent to Database</h1>
            </hgroup>
            <p></p>
        </div>
    </section>
</asp:Content>
<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <p>
    Add a Parent to database ADMIN USE (for special circumstances e.g if parent telephoned company to register :))</p>
<table class="auto-style1">
    <tr>
        <td class="auto-style2" style="text-align: right">First Name</td>
        <td class="auto-style4">
            <asp:TextBox ID="fNTB" runat="server" Width="218px"></asp:TextBox>
        </td>
        <td>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="fNTB" ErrorMessage="First name is required" ForeColor="Red"></asp:RequiredFieldValidator>
        </td>
    </tr>
    <tr>
        <td class="auto-style3">Last Name</td>
        <td class="auto-style4">
            <asp:TextBox ID="lNTB" runat="server" Width="218px"></asp:TextBox>
        </td>
        <td>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="lNTB" ErrorMessage="Last name is required" ForeColor="Red"></asp:RequiredFieldValidator>
        </td>
    </tr>
    <tr>
        <td class="auto-style3">Telephone Number</td>
        <td class="auto-style4">
            <asp:TextBox ID="tNTB" runat="server" Width="218px"></asp:TextBox>
        </td>
        <td>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator10" runat="server" ControlToValidate="lNTB" ErrorMessage="Telephone number is required" ForeColor="Red"></asp:RequiredFieldValidator>
        </td>
    </tr>
    <tr>
        <td class="auto-style3">House Name</td>
        <td class="auto-style4">
            <asp:TextBox ID="hNTB" runat="server" Width="218px"></asp:TextBox>
        </td>
        <td>&nbsp;</td>
    </tr>
    <tr>
        <td class="auto-style5">House Number</td>
        <td class="auto-style6">
            <asp:TextBox ID="hNOTB" runat="server" Width="218px"></asp:TextBox>
        </td>
        <td class="auto-style7">
            <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ControlToValidate="hNOTB" ErrorMessage="House number is required" ForeColor="Red"></asp:RequiredFieldValidator>
        </td>
    </tr>
    <tr>
        <td class="auto-style8">Street Name</td>
        <td class="auto-style9">
            <asp:TextBox ID="sNTB" runat="server" Width="218px"></asp:TextBox>
        </td>
        <td class="auto-style10">
            <asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server" ControlToValidate="sNTB" ErrorMessage="Street Name is required" ForeColor="Red"></asp:RequiredFieldValidator>
        </td>
    </tr>
    <tr>
        <td class="auto-style3">City</td>
        <td class="auto-style4">
            <asp:TextBox ID="cTB" runat="server" Width="218px"></asp:TextBox>
        </td>
        <td>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator5" runat="server" ControlToValidate="cTB" ErrorMessage="City is required" ForeColor="Red"></asp:RequiredFieldValidator>
        </td>
    </tr>
    <tr>
        <td class="auto-style3">Postcode</td>
        <td class="auto-style4">
            <asp:TextBox ID="pTB" runat="server" Width="218px"></asp:TextBox>
        </td>
        <td>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator6" runat="server" ControlToValidate="pTB" ErrorMessage="Postcode is required" ForeColor="Red"></asp:RequiredFieldValidator>
        </td>
    </tr>
    <tr>
        <td class="auto-style3">&nbsp;</td>
        <td class="auto-style4">&nbsp;</td>
        <td>&nbsp;</td>
    </tr>
    <tr>
        <td class="auto-style3">Country</td>
        <td class="auto-style4">
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
        <td class="auto-style3">&nbsp;</td>
        <td class="auto-style4">&nbsp;</td>
        <td>&nbsp;</td>
    </tr>
    <tr>
        <td class="auto-style3">Email</td>
        <td class="auto-style4">
            <asp:TextBox ID="eTB" runat="server" Width="218px"></asp:TextBox>
        </td>
        <td>
            <asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" ControlToValidate="eTB" ErrorMessage="You must enter a valid email" ForeColor="Red" ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*"></asp:RegularExpressionValidator>
        </td>
    </tr>
    <tr>
        <td class="auto-style3">Username</td>
        <td class="auto-style4">
            <asp:TextBox ID="uTB" runat="server" Width="218px"></asp:TextBox>
        </td>
        <td>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator8" runat="server" ControlToValidate="uTB" ErrorMessage="Username is required" ForeColor="Red"></asp:RequiredFieldValidator>
        </td>
    </tr>
    <tr>
        <td class="auto-style3">Password</td>
        <td class="auto-style4">
            <asp:TextBox ID="pWTB" runat="server" Width="218px" TextMode="Password"></asp:TextBox>
        </td>
        <td>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator9" runat="server" ControlToValidate="pWTB" ErrorMessage="Password is required" ForeColor="Red"></asp:RequiredFieldValidator>
        </td>
    </tr>
    <tr>
        <td class="auto-style3">Confirm Password</td>
        <td class="auto-style4">
            <asp:TextBox ID="rTB" runat="server" Width="218px" TextMode="Password"></asp:TextBox>
        </td>
        <td>
            <asp:CompareValidator ID="CompareValidator1" runat="server" ControlToCompare="pWTB" ControlToValidate="rTB" ErrorMessage="Both passwords must be the same!" ForeColor="Red"></asp:CompareValidator>
        </td>
    </tr>
    <tr>
        <td class="auto-style3">&nbsp;</td>
        <td class="auto-style4">&nbsp;</td>
        <td>&nbsp;</td>
    </tr>
    <tr>
        <td class="auto-style3">&nbsp;</td>
        <td class="auto-style4">
            <asp:Label ID="uLbl" runat="server" Font-Bold="True" ForeColor="Red"></asp:Label>
        </td>
        <td>&nbsp;</td>
    </tr>
    <tr>
        <td class="auto-style3">&nbsp;</td>
        <td class="auto-style4">
            <asp:Button ID="submitBtn" runat="server" Text="Submit" Width="106px" OnClick="submitBtn_Click" />
            <input id="Reset1" type="reset" value="reset" /></td>
        <td>&nbsp;</td>
    </tr>
</table>
</asp:Content>
