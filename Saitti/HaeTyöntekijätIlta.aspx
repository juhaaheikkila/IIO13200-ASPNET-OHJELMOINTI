<%@ Page Language="C#" AutoEventWireup="true" CodeFile="HaeTyöntekijätIlta.aspx.cs" Inherits="HaeTyöntekijätIlta" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Iltavuorolaiset</title>
    <link rel="stylesheet" href="http://www.w3schools.com/lib/w3.css" />

</head>
<body>
    <form id="form1" runat="server">
        <div id="nappulat">
            <asp:Button ID="btnHae" class="w3-btn w3-green" runat = "server" Text="Hae työntekijät" OnClick="btnHae_Click" />
        </div>
        
        <div id="esitys" class ="w3-green">
            <asp:GridView ID="gvData" runat="server"></asp:GridView>
        </div>

        <div id="footer" class ="w3-container w3-teal">
            <asp:Label ID="lblMessage" runat="server" Text="..."></asp:Label>
        </div>
    </form>
</body>
</html>
