<%@ Page Language="C#" AutoEventWireup="true" CodeFile="JE.aspx.cs" Inherits="JE" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Journal Entry document</title>
    <link rel="stylesheet" href="http://www.w3schools.com/lib/w3.css" />
    <link rel="stylesheet" href="CSS/Site_Styles.css" />
</head>
<body>
    <form id="frmJE" runat="server">
        <div class='fixed_menu'>
            <div class="fixed_menu_content clearfix">
                <ul>
                    <li>
                        <asp:Button ID="btnSave" runat="server" Text="Save" class="action_left" /></li>
                    <li>
                        <asp:Button ID="btnPrint" runat="server" Text="Print" class="action_left" /></li>
                    <li>
                        <asp:Button ID="btnChangePeriod" runat="server" Text="Change period" class="action_left" /></li>
                    <li>
                        <asp:Button ID="btnClose" runat="server" Text="Close" class="action_right" /></li>
                </ul>
            </div>
        </div>

        <div id="JEHeader">
            <table style="width: 100%">
                <tr>
                    <td style="width: 33%">LOGO
                    </td>
                    <td style="width: 33%">
                        <h1>JE Document</h1>
                    </td>
                    <td style="width: 33%">
                        <asp:Label ID="lblInfo" runat="server" Text="..."></asp:Label>
                    </td>
                </tr>
            </table>

        </div>
        <div id="JEContent">
            <div class="JELabel">FA koodi:</div>
            <div class="JEData">FA631</div>
            <div class="JEInfo">Valitse käytettävä FA-koodi</div>
        </div>
        <div id="JEFooter" class="JEFooter">

            <asp:Label ID="lblMessage" runat="server" Text="..."></asp:Label>
        </div>

    </form>
</body>
</html>
