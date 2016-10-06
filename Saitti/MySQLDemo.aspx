<%@ Page Title="" Language="C#" MasterPageFile="~/Tehtävä_4_MasterPage.master" AutoEventWireup="true" CodeFile="MySQLDemo.aspx.cs" Inherits="Default4" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">

</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="body" runat="Server">
    <h2>SQLDataSourcen avulla</h2>
    <asp:SqlDataSource ID="srcMysli" runat="server"
        ConnectionString="<%$ConnectionStrings:Mysli %>"
        ProviderName ="MySql.Data.MySqlClient"
        DeleteCommand ="DELETE FROM Pelaaja WHERE PelaajaID=@PelaajaID"
        SelectCommand="SELECT * FROM Pelaaja"
        UpdateCommand ="UPDATE Pelaaja SET Nimi=@Nimi, Seura=@Seura, Pelipaikka=@Pelipaikka, Nro=@Nro, Maalit=@Maalit, Syotot=@Syotot WHERE (PelaajaID=@PelaajaID)" />
    <asp:GridView ID="gvPlayers" runat="server" DataSourceID="srcMysli" >
        <Columns>
            <asp:CommandField ShowEditButton="True" />
        </Columns>
    </asp:GridView>

    <asp:Button ID="btnGetCities" runat="server" Text="Hae kaupungit Mysql" OnClick="btnGetCities_Click" />
    <asp:GridView ID="gvCities" runat="server" />
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="footer" runat="Server">
    <asp:Label ID="lblMessage" runat="server" Text="Label"></asp:Label>
</asp:Content>

