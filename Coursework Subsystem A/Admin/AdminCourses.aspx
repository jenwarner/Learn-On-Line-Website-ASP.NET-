<%@ Page Title="" Language="C#" MasterPageFile="~/AdminSite.Master" AutoEventWireup="true" CodeBehind="AdminCourses.aspx.cs" Inherits="Coursework_Subsystem_A.Account.AdminCourses" %>
<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" runat="server">
</asp:Content>
<asp:Content ID="FeaturedContent" ContentPlaceHolderID="FeaturedContent" runat="server">
    <section class="featured">
        <div class="content-wrapper">
            <hgroup class="title" style="background-color:rgb(84,71,56); height:5px;">
               <!-- <h1><%: Title %> --><h1>Courses</h1>
            </hgroup>
            <p></p>
        </div>
    </section>
</asp:Content>
<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <p>Hypothetical course list</p>Edit courses<br />
    <br />
    Add courses<br />
</asp:Content>
