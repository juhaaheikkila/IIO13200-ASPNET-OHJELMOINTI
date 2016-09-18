<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Tehtava_2_1_Suomi_lotto.aspx.cs" Inherits="Tehtava_2_1_Suomi_lotto" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Suomi-lotto</title>
</head>
<body>
    <form id="form1" runat="server">

        <div>
            <h1>
                <asp:Label ID="lblTitle" runat="server" Text="..."></asp:Label>
            </h1>
            <div id="actionbuttons">
                <asp:Button ID="btnArvoNumerot" runat="server" Text="Arvo numerot" OnClick="btnArvoNumerot_Click" />
            </div>
            <div id="tulokset">
                <p>
                    Arvottavien rivien lukumäärä: 
            <asp:TextBox ID="txtRivienLukumaara" runat="server" class="w3-input"></asp:TextBox>
                </p>
                <asp:Label ID="lblResults" Text="..." runat="server" />
            </div>
            <div id="data">
                <p>Tulokset:</p>
                <asp:GridView ID="gvArvotutnumerot" runat="server" />
            </div>

            <div id="footer">
                <asp:Label ID="lblMessages" runat="server" />
            </div>
        </div>
    </form>
</body>
</html>
