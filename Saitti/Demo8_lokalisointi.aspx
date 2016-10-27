<%@ Page Title="" Language="C#" MasterPageFile="~/0. SaitinMasteri.master" AutoEventWireup="true" CodeFile="Demo8_lokalisointi.aspx.cs" Inherits="Demo8_lokalisointi" culture="auto" meta:resourcekey="PageResource1" uiculture="auto" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="body" runat="Server">
    <h1>
        <asp:Literal ID="ltHello" runat="server"
            meta:resourcekey="ltHelloResource1"></asp:Literal>
        Tänään on <%=DateTime.Today.ToShortDateString()%>
    </h1>
    <div class="w3-container">
        <asp:Label ID="lblHello" runat="server" Text="Tähän vaihtuva teksti" meta:resourcekey="lblHelloResource1" /><br />
        <asp:Image runat="server" ImageUrl="<%$ Resources:Lippu %>" Width="100" />
        <asp:Button ID="btnSayHello" runat="server" Text="<%$ Resources:Buttoseen %>" OnClick="btnSayHello_Click" />
        <asp:Label ID="lblTitle" runat="server" Text="Label"></asp:Label>
    </div>
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="footer" runat="Server">
</asp:Content>
