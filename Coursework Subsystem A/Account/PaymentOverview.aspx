<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="PaymentOverview.aspx.cs" Inherits="Coursework_Subsystem_A.Account.PaymentOverview" %>
<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" runat="server">

</asp:Content>
<asp:Content ID="FeaturedContent" ContentPlaceHolderID="FeaturedContent" runat="server">
    <section class="featured">
        <div class="content-wrapper">
            <hgroup class="title" style="background-color:rgb(84,71,56); height:5px;">
               <!-- <h1><%: Title %> --><h1>Order Overview</h1>
            </hgroup>
            <p></p>
        </div>
    </section>
</asp:Content>
<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Billing Address<br />
        <table class="auto-style1">
            <tr>
                <td><asp:Table ID="Table2" runat="server" Width="931px">
                    <asp:TableRow ID="TableRow1" runat="server">
                        <asp:TableCell ID="TableCell1" runat="server">House Name</asp:TableCell>
                        <asp:TableCell ID="TableCell2" runat="server">House Number</asp:TableCell>
                        <asp:TableCell ID="TableCell3" runat="server">Street Name</asp:TableCell>
                        <asp:TableCell ID="TableCell4" runat="server">City</asp:TableCell>
                        <asp:TableCell ID="TableCell5" runat="server">Postcode</asp:TableCell>
                        <asp:TableCell ID="TableCell6" runat="server">Country</asp:TableCell>
                    </asp:TableRow>
                </asp:Table></td>
            </tr>
            <tr>
                <td>&nbsp;</td>
            </tr>
        </table>
    
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Card Details&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;&nbsp; 
        Order
    <table class="auto-style1">
        <tr>
            <td class="auto-style2">Cardholder Name</td>
            <td class="auto-style3">
            <asp:Label ID="cNLbl" runat="server"></asp:Label>
            </td>
            <td class="auto-style4">Children</td>
            <td style="text-align: left">
                <asp:Label ID="countLbl" runat="server"></asp:Label>
            </td>
        </tr>
        <tr>
            <td class="auto-style2">Card Type</td>
            <td class="auto-style3">
                <asp:Label ID="cTLbl" runat="server"></asp:Label>
            </td>
            <td class="auto-style4">&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style2">Card Number</td>
            <td class="auto-style3">
                <asp:Label ID="cNoLbl" runat="server"></asp:Label>
            </td>
            <td class="auto-style4">Subtotal</td>
            <td>
                <asp:Label ID="subTotalLbl" runat="server"></asp:Label>
            </td>
        </tr>
        <tr>
            <td class="auto-style2">Start Date</td>
            <td class="auto-style3">
                <asp:Label ID="sDLbl" runat="server"></asp:Label>
            </td>
            <td class="auto-style4">VAT</td>
            <td>&nbsp;&nbsp; 20%&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style2">End Date</td>
            <td class="auto-style3">
                <asp:Label ID="eDLbl" runat="server"></asp:Label>
            </td>
            <td class="auto-style4">&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style2">CV2</td>
            <td class="auto-style3">
                <asp:Label ID="cV2Lbl" runat="server"></asp:Label>
            </td>
            <td class="auto-style4"><b>Total</b></td>
            <td>
                <asp:Label ID="totalLbl" runat="server"></asp:Label>
            </td>
        </tr>
        <tr>
            <td class="auto-style2">&nbsp;</td>
            <td class="auto-style3">
                <asp:Button ID="payBtn" runat="server" Height="36px" Text="Pay" Width="107px" OnClick="payBtn_Click" />
                <asp:Button ID="cancelBtn" runat="server" OnClick="cancelBtn_Click" Text="Cancel" Width="108px" />
            </td>
            <td class="auto-style4">&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
    </table>
    
</asp:Content>
