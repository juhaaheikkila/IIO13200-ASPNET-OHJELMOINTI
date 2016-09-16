<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Index.aspx.cs" Inherits="Index" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>IIO13200 .NET Ohjelmointi</title>
    <link href="CSS/demo.css" rel="stylesheet" type="text/css" />
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h1>IIO13200. NET Ohjelmointi</h1>
            
            <h2>Viikkotehtävät:</h2>
            <h3># Tehtävä 1 (8.9.2016), Ikkunan tarjouslaskuri:</h3>
            <p>Tehtävä:</p>
            <p>Keski-suomalainen ikkunoita valmistava yritys Oy K-S Ikkuna ja Aukko Ab tarvitsee webbi-sovellusta, jolla asiakkaat voivat laskea tarjoushinnan alumiinikarmisille ikkunoille. Hinta lasketaan ikkuna-lasin ja karmimenekin sekä työmenekin perusteella. Asiakas syöttää ikkunan leveyden ja korkeuden sekä karmin leveyden (oletusarvo 45 mm). Tämän jälkeen hän napsauttaa komentopainiketta "Laske tarjoushinta"  ja sovellus laskee ikkunalasin pinta-alan sekä alumiinikarmin menekin ja laskee näiden perusteella hinnan ikkunalle. Toteuta myös tarvittava syötteiden tarkistus ja/tai virhekäsittely. Fiksua olisi myös tallentaa muuttuvat arvot Web.Config-tiedostoon ja lukea ne sieltä, eikä kovakoodata niitä...</p>
            <p>Ratkaisu:</p>
            <p>** vakiot tallennettuna: web.config</p>
            <p>** linkki: <a href="Tehtava_1_IkkunaLaskuri.aspx">tarjouslaskuri</a></p>
            <p></p>
            <h3># Tehtävä 2 (15.9.2016), Oppimistavoite: business-luokan käyttö ASP.NET -sovelluksessa:</h3>
            <p>Tehtävä:</p>
            <p>Tee ASP.NET-sovellus lottorivien arvontaa varten. Käyttäjä voi valita montako riviä arvotaan. Lotto-vaihtoehtoja Suomessa on kaksi: Suomi ja VikingLotto. Suomi-lotossa arvotaan seitsemän (7) numero 39:sta, Viking Lotossa arvotaan kuusi (6) numeroa 48:sta. Toteuta käyttöliittymä ASP.NET-teknologialla.</p>
            <p>Tarkoituksena on erottaa käyttöliittymä ja ns. business-logiikka toisistaan. Toteuta (tai käytä viime keväistä) BLLotto.cs-tiedostoon Lotto-niminen luokka, sijoita tämä tiedosto App_Code-kansioon.Testaa huolellisesti toteuttamaasi luokkaa, että se varmasti toimii oikein eri tilanteissa ja antaa oikeita tuloksia.</p>
            <p>Ratkaisu:</p>
            <p>** linkki: <a href="Tehtava_2_1_Suomi_lotto.aspx">1. Suomi-lotto</a></p>
            <p>** linkki: <a href="Tehtava_2_2_Viking_lotto.aspx">2. Viking-lotto</a></p>
            <p># Tehtävä 3 (8.9.2016):</p>
            <p># Tehtävä 4 (8.9.2016):</p>
            <p># Tehtävä 5 (8.9.2016):</p>

            <h3>Perus HTML kontrolleja</h3>
            <a href="TestiAamu.html">Testi html-sivu (aamu)</a>
            <p>
                Esimerkki ASP.NET DataKontrollista
                <asp:HyperLink ID="HyperLink1" runat="server" NavigateUrl="~/ShowPhotos.aspx">Show Photos</asp:HyperLink>
            </p>
            <p>
                Esimerkki kuinka koodissa rakennetaan HTML:ää
                <asp:HyperLink ID="HyperLink2" runat="server" NavigateUrl="~/ShowCustomers.aspx">Show WineCustomers</asp:HyperLink>
            </p>
        </div>
    </form>
</body>
</html>
