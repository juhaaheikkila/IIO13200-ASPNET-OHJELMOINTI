<%@ Page Title="" Language="C#" MasterPageFile="~/Tehtävä_4_MasterPage.master" AutoEventWireup="true" CodeFile="Tehtava_4_SQOLDataSource.aspx.cs" Inherits="Tehtava_4_SQOLDataSource" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="body" Runat="Server">
    <!--DataSource määrittely-->
    <asp:SqlDataSource ID="srcAsiakkaat" runat="server" ConnectionString="<%$ ConnectionStrings:Asiakkaat %>" SelectCommand="SELECT [astunnus], [asnimi], [yhteyshlo], [postitmp] FROM [asiakas] ORDER BY [astunnus]"></asp:SqlDataSource>
    <h1>Tehtävä 4 - asiakastiedot SQL Datasourcella haettuna </h1>
    <!-- GV kontrolli esittää dataa -->
    <asp:GridView ID="GridView1" runat="server" DataSourceID="srcAsiakkaat"></asp:GridView>
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="footer" Runat="Server">

</asp:Content>

