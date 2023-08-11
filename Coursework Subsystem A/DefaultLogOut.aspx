<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="DefaultLogOut.aspx.cs" Inherits="Coursework_Subsystem_A.DefaultLogOut" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head id="Head1" runat="server">
    <title>Logout</title>
</head>
<body style="background-color:#f4f1e5">
    <form id="form1" runat="server">
    <div style="font-size:14px;font-family:Arial, Helvetica, sans-serif">
        <asp:Label ID="Label1" runat="server" Text="Logout successful."></asp:Label>
        <asp:HyperLink ID="HyperLink1" runat="server" NavigateUrl="~/Default.aspx">
            You will redirect in 5 seconds. If you haven't, click here.</asp:HyperLink>
    </div>
    </form>
</body>
</html>
