<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Tehtava_1_IkkunaLaskuri.aspx.cs" Inherits="Tehtava_1_IkkunaLaskuri" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Oy K-S Ikkuna ja Aukko Ab </title>
    <link rel="stylesheet" href="http://www.w3schools.com/lib/w3.css" />
</head>
<body>
    <form id="frmIkkunaLaskuri" runat="server">
    <div>
        <h1>Oy K-S Ikkuna ja Aukko Ab </h1>
        <p>Laske ikkunan kustannukset:</p>
        <table class="">

            <tr>
                <td rowspan="10">
                    <img src="../Images/KS_IA_IkkunaMitat.jpg" />
                </td>
                    <td valign="top">
                        <table>
                            <tr>
                                <td>Ikkunan Leveys (L):</td>
                                <td> <asp:TextBox ID="txtLength" runat="server" class="w3-input" style="text-align:right; font-weight: 700;" OnTextChanged="txtLength_TextChanged"></asp:TextBox></td>
                                <td>[MM]</td>
                            </tr>
                            <tr>
                                <td>Ikkunan Korkeus (H):</td>
                                <td><asp:TextBox ID="txtHeight" runat="server" class="w3-input" style="text-align:right; font-weight: 700;" OnTextChanged="txtHeight_TextChanged"></asp:TextBox></td>
                                <td>[MM]</td>
                            </tr>
                            <tr>
                                <td>Karmipuun leveys (W):</td>
                                <td><asp:TextBox ID="txtWidth" runat="server" class="w3-input" style="text-align:right; font-weight: 700;" OnTextChanged="txtWidth_TextChanged">45</asp:TextBox></td>
                                <td>[MM]</td>
                            </tr>
                            <tr>
                                <td>Laske:</td>
                                <td colspan="2"><asp:Button ID="btnCalculate" runat="server" Text="Laske tarjoushinta" OnClick="btnCalculate_Click" /></td>
                                
                            </tr>
                                <tr>
                                <td>Ikkunan pinta-ala:</td>
                                <td align="right"><asp:Label ID="lblIkkunanPintaAla" runat="server" Text="..."></asp:Label></td>
                                <td>[M2]</td>
                            </tr>
                                <tr>
                                <td>Karmin piiri:</td>
                                <td align="right"><asp:Label ID="lblKarminPiiri" runat="server" Text="..."></asp:Label></td>
                                <td>[M]</td>
                            </tr>
                            <tr>
                                <td>Tarjoushinta (ilman ALV):</td>
                                <td align="right"><asp:Label ID="lblTarjousHinta" runat="server" Text="..."></asp:Label></td>
                                <td>€</td>
                            </tr>
                        </table>
                    </td>
                </tr>
                <tr>
                    <td colspan ="2">    
                        <asp:Label ID="lblMessage" runat="server" Text="..."></asp:Label>
                    </td>
                        
                       
                </tr>
            </table>
        </div>
    </form>
</body>
</html>
