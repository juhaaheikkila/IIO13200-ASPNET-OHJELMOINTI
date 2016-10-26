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

            <h2 style="font-family: 'Segoe UI', Tahoma, Geneva, Verdana, sans-serif; font-size: 8pt">Luentojen demot</h2>
            <div id="demo_DataTrasfer" class="tehtava">
                <p>Demo, 22.9.2016: tiedon välityksesä sivujen välillä ja data validation </p>
                <p>1. QueryString</p>
                <p>2. Session</p>
                <p>3. Cookies</p>
                <p>4. Parametrina</p>
                <asp:HyperLink NavigateUrl="~/Demo3_passing_data_source_page.aspx" Text="Source page" runat="server" Target="_blank">Source page</asp:HyperLink><br />
                <asp:HyperLink NavigateUrl="~/Demo3_passing_data_target_page.aspx" Text="Target page" runat="server" Target="_blank">Target page</asp:HyperLink><br />
            </div>
            <div id="Demo_MySql" class="tehtava">
                <p>Demo, 6.10.2016, MySQL</p>
                <asp:HyperLink NavigateUrl="~/MySQLDemo.aspx" Text="Source page" runat="server" Target="_blank">Demo-sivu</asp:HyperLink><br />
            </div>
            <p>Demo, 6.10.2016, JSON</p>
            <code>http://student.labranet.jamk.fi/~salesa/mat/JsonTest
                [{"name":"Jutta Urpilainen","gender":"Female","birthday":"1975-8-4","party":"SDP","position":"ex-Minister of Treasure"},
 {"name":"Alexander Stubb","gender":"Male","birthday":"1968-4-1","party":"Kokoomus","position":"ex-Minister of Treasure"},
 {"name":"Timo Soini","gender":"Male","birthday":"1962-5-30","party":"Perussuomalaiset","position":"Minister of Foreign Affairs"},
 {"name":"Jyrki Katainen","gender":"Male","birthday":"1971-10-14","party":"Kokoomus","position":"ex-Prime Minister "}, {"name":"Tosi-Petteri Orpo","gender":"Male","birthday":"1969-6-9","party":"Kokoomus","position":"Minister of Treasure "},
 {"name":"Sanni Lahn-Graasonen","gender":"Female","birthday":"1989-6-9","party":"Kokoomus","position":"Minister of Education and Culture"},
 {"name":"Juha Sipilä","gender":"Male","birthday":"1961-04-25","party":"Keskusta","position":"Prime Minister ","linkki":"http://valtioneuvosto.fi/documents/10184/1432004/P%C3%A4%C3%A4ministeri+Sipil%C3%A4+i/42e872c9-ab67-4d77-923f-231ea7189672?t=1441185100000&width=580"}]
            </code>
            <p>Demo 5 xml kontrolli xsl työntekijät, 13.10.2016</p>
            <asp:HyperLink NavigateUrl="~/demo5_xml_kontrolli_xsl_työntekijät.aspx" Text="Demo xml ja xsl" runat="server" Target="_blank">Demo-sivu</asp:HyperLink><br />
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
                <h3># Tehtävä 3 Calender -kontrolli (22.9.2016): 
                <asp:Button ID="btnShowHide_3" runat="server" Text="Näytä kuvaus" OnClick="btnShowHideInfo_Click" BorderStyle="None" />
                </h3>
                <div id="Tehtävä_Info_3" runat="server" class="tehtavan_kuvaus" visible="false">
                    <p class="tehtavan_kuvaus_title">Tehtävä:</p>
                    <p>Toteuta ASP.NET:llä yksinkertainen simppeli sovellus, jolla käyttäjä voi laskea kuluvan päivän ja syntymäpäivänssä erotuksen päivinä.</p>
                    <p>
                        ASP.NETissä on valmis kalenteri-kontrolli (asp:Calender), käytäs sitä eli:
                    </p>
                    <ul>
                        <li>käyttäjä valitsee haluamansa päivämäärän kalenterista </li>
                        <li>jolloin sovellus ilmoittaa montako vuotta, kuukautta ja päivää valitusta päivämäärästä on tähän päivään.</li>
                    </ul>

                </div>
                <div id="Tehtävä_Ratkaisu_3" runat="server" class="tehtavan_ratkaisu">
                    <p class="tehtavan_kuvaus_title">Ratkaisu:</p>
                    <p></p>
                    <p>
                        ** linkki:
                        <asp:HyperLink runat="server" NavigateUrl="~/Tehtava_3_Kalenteri_kontrolli.aspx">Calender-kontrolli</asp:HyperLink>
                    </p>
                </div>
            </div>

            <div id="Tehtävä_4" class="tehtava">
                <h3># Tehtävä 4 MasterPagea käyttävä webbi-sivu (29.9.2016)
                <asp:Button ID="btnShowHide_4" runat="server" Text="Näytä kuvaus" OnClick="btnShowHideInfo_Click" BorderStyle="None" />
                </h3>
                <div id="Tehtävä_Info_4" runat="server" class="tehtavan_kuvaus" visible="false">
                    <p class="tehtavan_kuvaus_title">Tehtävä:</p>
                    <p>
                        Toteuta ASP.NET:lla alla olevien kuvien mukainen MasterPagea käyttävä webbi-sivu, joka kahdella eri tavalla hakee asiakastietoja twelve-palvelimen DemoxOy-tietokannan asiakas-taulusta.
                    </p>
                    <ul>
                        <li>Tapa 1) SQLDataSourcen avulla</li>
                        <li>Tapa 2) DBDemoxOy-luokan metodien avulla. Luokka (että tarvittava connection string) löytyvät storagelta Jakoon\IIO13200\Mallit\DbDemoxOy.cs-kansiosta.</li>
                    </ul>
                    <p>
                        Tässä varulta myös valmis connection string:
                    <code>
                        <add name="Asiakkaat" connectionstring="Data Source=twelve.labranet.jamk.fi;Initial Catalog=DemoxOy;Persist Security Info=True;User ID=koodari;Password=ope_kertonut_tunnilla" providername="System.Data.SqlClient" />
                    </code>
                    </p>
                    <p>
                        ohjeet yhteyden tekoon: http://student.labranet.jamk.fi/vpn/
                    <br />
                        vpn ohje: http://student.labranet.jamk.fi/wp/wp-content/uploads/2014/09/LabraNet_Remote_Access_Guide.pdf
                    </p>
                </div>
                <div id="Tehtävä_Ratkaisu_4" runat="server" class="tehtavan_ratkaisu">
                    <p class="tehtavan_kuvaus_title">Ratkaisu:</p>
                    <p></p>
                    <p>
                        ** linkki:
                        <asp:HyperLink runat="server" NavigateUrl="~/Tehtava_4_SQOLDataSource.aspx">SQLDataSourcen-avulla</asp:HyperLink>
                    </p>
                    <p>
                        ** linkki:
                        <asp:HyperLink runat="server" NavigateUrl="~/Tehtava_4_DBDemoxOy.aspx">DBDemoxOy-luokan metodien avulla</asp:HyperLink>
                    </p>
                </div>
            </div>
            <div id="Tehtävä_6" class="tehtava">
                <h3># Tehtävä 6 Levykauppa X (13.10.2016):
                <asp:Button ID="btnShowHide_6" runat="server" Text="Näytä kuvaus" OnClick="btnShowHideInfo_Click" BorderStyle="None" />
                </h3>
                <div id="Tehtävä_Info_6" runat="server" class="tehtavan_kuvaus" visible="false">
                    <p class="tehtavan_kuvaus_title">Tehtävä:</p>
                    <img src="Images/LevykauppaX3.jpg" /><br />
                    <img src="Images/LevykauppaX3B.jpg" /><br />
                    <p>Tee oheisen kuvan mukainen ASP.NET- sivu, jossa esitetään XML-tiedostossa LevykauppaX.XML määriteltyjä levyjä kansikuvineen.</p>
                    <p>Levyn ISBN on samalla tunniste kuvatiedostolle, eli samannimiset kuvatiedostot löydät Images-kansiosta.</p>
                    <p>Luo sovellukseesi Images-kansio johon sijoitat kuvat.</p>
                    <p>Oheisessa ratkaisussa on käytetty XmlDataSourcea-tietolähteenä ja Tablen sisällä olevaa DataList-kontrollia tiedon esittämiseen.</p>
                    <p>Muitakin ratkaisuja saa käyttää.</p>
                    <p>Napsauttamalla levyn ISBN-numeroa käyttäjä siirretään toiselle sivulle jossa näytetään levyn tarkemmat tiedot mm. levyllä olevat biisit.</p>
                    <p>Tehtävässä käytettävä/tarvittava LevykauppaX.xml -tiedosto löytyy myös storagelta. Storagelta löytyy tarvittavat kuvatiedostot Images-kansiosta.</p>
                    <p>Voit tehdä halutessasi myös oman toteutuksen jostakin muista artikkeleista esim autoista, kirjoista, DVD.stä --> hae muutama aiheeseen sopiva kuva netistä jolla voit demota toteutustasi.</p>
                </div>
                <div id="Div2" runat="server" class="tehtavan_ratkaisu">
                    <p class="tehtavan_kuvaus_title">Ratkaisu:</p>
                    <p>
                        ** linkki:
                        <asp:HyperLink runat="server" NavigateUrl="~/Tehtava_6_Levykauppa_X.aspx">Levykauppa X ikkuna</asp:HyperLink>
                    </p>
                </div>
            </div>
            <div id="Tehtävä_8" class="tehtava">
                <a name="Tehtävä_8"></a>
                <h3># Tehtävä 8 FinnKino (13.10.2016)
                <asp:Button ID="btnShowHide_8" runat="server" Text="Näytä kuvaus" OnClick="btnShowHideInfo_Click" BorderStyle="None" />
                </h3>
                <div id="Tehtävä_Info_8" runat="server" class="tehtavan_kuvaus" visible="false">
                <p>FinnKino</p>
                    <p>
                       Toteuta oheisen kuvan mukainen webbi-sivu jossa esitetään kuvilla tällä viikolla FinnKinossa esitettävät elokuvat. Tarvittavat tiedot teattereista, elokuvista ja elokuvien kuvista löytyvä täältä Finnkinon sivulta: http://www.finnkino.fi/xml --> Käytä tarvittavia xml-feedejä.
Sivun ulkoasun saat valita vapaasti mutta se voisi olla jotakuinkin oheisen kuvan mukainen.
Toiminnallisuutta toteuta siten että käyttäjän klikatessa (1) sivun vasemmalta haluamaansa Teatteria, esitetään kuvina oikean puoleisessa taulukossa kyseisessä teatterissa pyörivät Elokuvat. Linkit elokuvien kuviin saat em. Finnkinon xml-feedeistä.
                    </p>
                </div>
                <div id="Div3" runat="server" class="tehtavan_ratkaisu">
                    <p class="tehtavan_kuvaus_title">Ratkaisu:</p>
                    <p></p>
                    <p>
                        ** linkki:
                        <asp:HyperLink runat="server" NavigateUrl="~/Tehtava_8_FinnKino.aspx">FinnKino tämän viikon elokuvat</asp:HyperLink>
                    </p>
                </div>
            </div>

            <div id="Tehtävä_9" class="tehtava">
                <a name="Tehtävä_9"></a>
                <h3># Tehtävä 9 VR:n junatiedot JSON.NET (6.10.2016)
                <asp:Button ID="btnShowHide_9" runat="server" Text="Näytä kuvaus" OnClick="btnShowHideInfo_Click" BorderStyle="None" />
                </h3>
                <div id="Tehtävä_Info_9" runat="server" class="tehtavan_kuvaus" visible="false">
                    viikko tehtävä yhdeksän 6.10.2016
                <p>VR:n junatiedot JSON.NET</p>
                    <p>
                        <ul>
                            <li>Toteuta ASP.NET:llä tai WPF-sovellus, jolla haetaan avointa dataa Suomen rataverkostolla kulkevista junista.</li>
                            <li>Palvelun kuvaus löytyy:
                                http://rata.digitraffic.fi/api/v1/doc/index.html
                                http://rata.digitraffic.fi/api/v1/doc/index.html
                            </li>
                            <li>API palauttaa data JSON-muodossa. Muunna JSON olioiksi käyttämällä NewtonSoftin valmista kirjastoa. </li>
                            <li>Tee toiminnallisuus, jolla käyttäjä voi valita haluamansa liikennepaikan, ja hakea sieltä kuluvan päivänä liikennöivät junat.
                                UI:hin että DBPlaceco-luokkaan.
                            </li>

                        </ul>
                    </p>
                </div>
                <div id="Tehtävä_Ratkaisu_9" runat="server" class="tehtavan_ratkaisu">
                    <p class="tehtavan_kuvaus_title">Ratkaisu:</p>
                    <p></p>
                    <p>
                        ** linkki:
                        <asp:HyperLink runat="server" NavigateUrl="~/Tehtava_9_JSON.aspx">VR:n junatiedot JSON.NET</asp:HyperLink>
                    </p>
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
