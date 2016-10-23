<%@ Page Title="" Language="C#" MasterPageFile="~/0. SaitinMasteri.master" AutoEventWireup="true" CodeFile="Tehtava_6_LevynTiedot.aspx.cs" Inherits="Tehtava_6_LevynTiedot" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="body" Runat="Server">
    <asp:XmlDataSource ID="xmlLevykauppaX" runat="server" DataFile="~/App_Data/LevykauppaX.xml"></asp:XmlDataSource>
    <div id="myDiv" runat="server" />
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="footer" Runat="Server">
</asp:Content>

