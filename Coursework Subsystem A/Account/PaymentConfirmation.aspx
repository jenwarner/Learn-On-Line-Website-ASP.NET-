<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="PaymentConfirmation.aspx.cs" Inherits="Coursework_Subsystem_A.Account.PaymentConfirmation" %>
<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" runat="server">
    <style type="text/css">
        .auto-style1 {
            width: 100%;
        }
        .auto-style2 {
            width: 361px;
            text-align: right;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="FeaturedContent" runat="server">
    <section class="featured">
        <div class="content-wrapper">
            <hgroup class="title" style="background-color:rgb(84,71,56); height:5px;">
               <!-- <h1><%: Title %> --><h1>Order Confirmation</h1>
            </hgroup>
            <p></p>
        </div>
</section>
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="MainContent" runat="server">
    <p>Order Successful. An email confirmation will be sent shortly.</p>
    <table class="auto-style1">
        <tr>
            <td class="auto-style2" style="text-align: right">Amount Paid</td>
            <td>
                <asp:Label ID="paidLbl" runat="server"></asp:Label>
            </td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style2">VAT</td>
            <td>
                <asp:Label ID="vatLbl" runat="server"></asp:Label>
            </td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style2">&nbsp;</td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
    </table>
</asp:Content>
