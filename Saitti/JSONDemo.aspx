<%@ Page Title="" Language="C#" MasterPageFile="~/Tehtävä_4_MasterPage.master" AutoEventWireup="true" CodeFile="JSONDemo.aspx.cs" Inherits="JSONDemo" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="body" Runat="Server">
    <asp:Button ID="btnGet"  runat="server" Text="Hae JSON teksti" OnClick="btnGet_Click"/>
    <asp:Button ID="btnGetPerson"   runat ="server" Text="Hae JSON ja muuta olioksi" OnClick="btnGetPerson_Click"/>
    <asp:Button ID="btnGetPolitics" runat="server" Text="Hae JSON ja muuta oliokokoelmaksi" onclick="btnGetPolitics_Click"/>
    <br />
    <asp:Literal ID="ltResult" runat="server" />
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="footer" Runat="Server">
</asp:Content>

