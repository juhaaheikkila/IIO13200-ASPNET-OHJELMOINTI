<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Demo3_passing_data_target_page.aspx.cs" Inherits="Demo3_passing_data_target_page" %>
<%@ PreviousPageType VirtualPath="~/Demo3_passing_data_source_page.aspx" %>
<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Data transfer target page</title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h1>Target page</h1>
            The message send to this page is:
            <div id="mytext" runat="server" />
        </div>
        <br />
        <asp:HyperLink ID="HyperLink1" runat="server" NavigateUrl="~/Demo3_passing_data_source_page.aspx" >takaisin</asp:HyperLink><br />
    </form>
</body>
</html>
