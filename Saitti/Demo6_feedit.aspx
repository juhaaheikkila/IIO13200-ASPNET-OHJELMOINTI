<%@ Page Title="" Language="C#" MasterPageFile="~/0. SaitinMasteri.master" AutoEventWireup="true" CodeFile="Demo6_feedit.aspx.cs" Inherits="Demo6_feedit" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="body" Runat="Server">
    <asp:Button ID="btnGetFeeds" runat="server" Text ="Feedit Iltasanomat" OnClick="btnGetFeeds_Click" />

    <asp:Button ID="btnGetFeedsYLE" runat="server" Text ="Feedit YLE pääutiset" OnClick="btnGetFeedsYLE_Click" />
<asp:XmlDataSource ID ="myDataSource" runat="server"></asp:XmlDataSource>
    <div id="myDiv" runat="server" />

</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="footer" Runat="Server">
</asp:Content>

