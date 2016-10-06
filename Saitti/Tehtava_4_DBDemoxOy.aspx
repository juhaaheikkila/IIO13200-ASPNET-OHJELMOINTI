<%@ Page Title="" Language="C#" MasterPageFile="~/Tehtävä_4_MasterPage.master" AutoEventWireup="true" CodeFile="Tehtava_4_DBDemoxOy.aspx.cs" Inherits="Tehtava_4_DBDemoxOy" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">

</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="body" Runat="Server">
    <h1>Tehtävä 4 - asiakastiedot DBDemoxOy-luokan metodeilla haettuna </h1>
    <!-- GV kontrolli esittää dataa -->
    <asp:GridView ID="gvAsiakkaat" runat="server" />
    <asp:Label ID ="lblResults" runat ="server" text="..."/>

    
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="footer" Runat="Server">
    footer
</asp:Content>

