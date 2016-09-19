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
            <div id="Tehtävä_1" class="tehtava">
                <h3># Tehtävä 1 (8.9.2016), Ikkunan tarjouslaskuri: 
                <asp:Button ID="btnShowHide_1" runat="server" Text="Näytä kuvaus" OnClick="btnShowHideInfo_Click" BorderStyle="None" />
                </h3>

                <div id="Tehtävä_Info_1" runat="server" class="tehtavan_kuvaus" visible="false">
                    <p class="tehtavan_kuvaus_title">Tehtävän kuvaus:</p>
                    <p>Keski-suomalainen ikkunoita valmistava yritys Oy K-S Ikkuna ja Aukko Ab tarvitsee webbi-sovellusta, jolla asiakkaat voivat laskea tarjoushinnan alumiinikarmisille ikkunoille. Hinta lasketaan ikkuna-lasin ja karmimenekin sekä työmenekin perusteella. Asiakas syöttää ikkunan leveyden ja korkeuden sekä karmin leveyden (oletusarvo 45 mm). Tämän jälkeen hän napsauttaa komentopainiketta "Laske tarjoushinta"  ja sovellus laskee ikkunalasin pinta-alan sekä alumiinikarmin menekin ja laskee näiden perusteella hinnan ikkunalle. Toteuta myös tarvittava syötteiden tarkistus ja/tai virhekäsittely. Fiksua olisi myös tallentaa muuttuvat arvot Web.Config-tiedostoon ja lukea ne sieltä, eikä kovakoodata niitä...</p>
                </div>
                <p></p>
                <div id="Tehtävä_Ratkaisu_1" runat="server" class="tehtavan_ratkaisu">
                    <p class="tehtavan_kuvaus_title">Ratkaisu:</p>
                    <p>** vakiot tallennettuna: web.config</p>
                    <p>** linkki: <a href="Tehtava_1_IkkunaLaskuri.aspx">tarjouslaskuri</a></p>
                </div>
                <p></p>
            </div>

            <div id="Tehtävä_2" class="tehtava">
                <h3># Tehtävä 2 (15.9.2016), Oppimistavoite: business-luokan käyttö ASP.NET -sovelluksessa: 
                <asp:Button ID="btnShowHide_2" runat="server" Text="Näytä kuvaus" OnClick="btnShowHideInfo_Click" BorderStyle="None" />

                </h3>

                <div id="Tehtävä_Info_2" runat="server" class="tehtavan_kuvaus" visible="false">
                    <p class="tehtavan_kuvaus_title">Tehtävä:</p>
                    <p>Tee ASP.NET-sovellus lottorivien arvontaa varten. Käyttäjä voi valita montako riviä arvotaan. Lotto-vaihtoehtoja Suomessa on kaksi: Suomi ja VikingLotto. Suomi-lotossa arvotaan seitsemän (7) numero 39:sta, Viking Lotossa arvotaan kuusi (6) numeroa 48:sta. Toteuta käyttöliittymä ASP.NET-teknologialla.</p>
                    <p>Tarkoituksena on erottaa käyttöliittymä ja ns. business-logiikka toisistaan. Toteuta (tai käytä viime keväistä) BLLotto.cs-tiedostoon Lotto-niminen luokka, sijoita tämä tiedosto App_Code-kansioon.Testaa huolellisesti toteuttamaasi luokkaa, että se varmasti toimii oikein eri tilanteissa ja antaa oikeita tuloksia.</p>
                </div>

                <div id="Tehtävä_Ratkaisu_2" runat="server" class="tehtavan_ratkaisu">
                    <p class="tehtavan_kuvaus_title">Ratkaisu:</p>
                    <p>
                        App_Code-kansiossa, BLLotto.cs-kirjasto, jossa LottoArvonta-luokka.
                        Kutsussa parametreinä:
                    </p>
                    <ul>
                        <li>gstrTitle: lotto-koneen otsikko Suomi- / Viking-lotto</li>
                        <li>gintNumeroita: numeroiden lukumäärä / rivi</li>
                        <li>gintRuudukko: ruudukon arvo</li>
                        <li>intRivienLukumaara: käyttäjän syöttmänä arvottavien rivien lukumäärä</li>
                    </ul>
                    <p>Tiedot näytetään GridView:ssä.</p>

                    <code>DataTable dtLotto = JAMK.ICT.BL.LottoArvonta.dtArvoLottoNumerot(gstrTitle, gintNumeroita, gintRuudukko, intRivienLukumaara);<br />
                        gvArvotutnumerot.DataSource = dtLotto;<br />
                        gvArvotutnumerot.DataBind();<br />
                    </code>
                    <p>** linkki: <a href="Tehtava_2_1_Suomi_lotto.aspx">1. Suomi-lotto</a></p>
                    <p>** linkki: <a href="Tehtava_2_2_Viking_lotto.aspx">2. Viking-lotto</a></p>
                </div>
            </div>

            <div id="Tehtävä3" class="tehtava">
                <h3># Tehtävä 3 ...tulossa validation controls tai jotain muuta...(22.9.2016): 
                <asp:Button ID="btnShowHide_3" runat="server" Text="Näytä kuvaus" OnClick="btnShowHideInfo_Click" BorderStyle="None" />
                </h3>
                <div id="Tehtävä_Info_3" runat="server" class="tehtavan_kuvaus" visible="false">
                    <p class="tehtavan_kuvaus_title">Tehtävä:</p>
                    <p></p>
                </div>
                <div id="Tehtävä_Ratkaisu_3" runat="server" class="tehtavan_ratkaisu">
                    <p class="tehtavan_kuvaus_title">Ratkaisu:</p>
                    <p></p>
                </div>
            </div>

            <div id="Tehtävä_4" class="tehtava">
                <h3># Tehtävä 4 (29.9.2016):
                <asp:Button ID="btnShowHide_4" runat="server" Text="Näytä kuvaus" OnClick="btnShowHideInfo_Click" BorderStyle="None" />
                </h3>
                <div id="Tehtävä_Info_4" runat="server" class="tehtavan_kuvaus" visible="false">
                    <p class="tehtavan_kuvaus_title">Tehtävä:</p>
                    <p>...</p>
                </div>
                <div id="Tehtävä_Ratkaisu_4" runat="server" class="tehtavan_ratkaisu">
                    <p class="tehtavan_kuvaus_title">Ratkaisu:</p>
                    <p></p>
                </div>
            </div>

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
        <div>
            <asp:Label ID="lblMessage" runat="server" Text="..."></asp:Label>
        </div>
    </form>
</body>
</html>
