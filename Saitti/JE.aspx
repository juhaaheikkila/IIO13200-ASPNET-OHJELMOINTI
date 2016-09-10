<%@ Page Language="C#" AutoEventWireup="true" CodeFile="JE.aspx.cs" Inherits="JE" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Journal Entry document</title>
    <link rel="stylesheet" href="http://www.w3schools.com/lib/w3.css" />
</head>
<body>
    <form id="frmJE" runat="server">
    <div id="JEActions" class="w3-amber">
        <asp:Button ID="btnSave" runat="server" Text="Save" />
        <asp:Button ID="btnClose" runat="server" Text="Close" />
       
    </div>
    <div id="JEHeader">
        LOGO
        <h1>JE Document</h1>

    </div>
    </form>
</body>
</html>
