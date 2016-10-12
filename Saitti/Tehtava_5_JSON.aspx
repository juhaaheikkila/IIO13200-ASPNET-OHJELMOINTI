<%@ Page Title="" Language="C#" MasterPageFile="~/Tehtävä_4_MasterPage.master" AutoEventWireup="true" CodeFile="Tehtava_5_JSON.aspx.cs" Inherits="Default5" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="body" runat="Server">
    <p>Valitse paikkakunta:</p>
    <asp:DropDownList ID="lstLocations" OnSelectedIndexChanged="lstLocations_SelectedIndexChanged" runat="server" AutoPostBack="True" /><br />
    <p>Valittu asema:<asp:Label ID="lblSelectedLocation" runat="server" Text="..."></asp:Label></p>

    <asp:Button ID="btnGetTrain" runat="server" Text="Hae lähtevät junat" OnClick="btnGetTrain_Click" /><br />
    <asp:Literal ID="ltResult" runat="server" />
    <asp:GridView ID="gvTrainInfo" runat="server"></asp:GridView>
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="footer" runat="Server">
</asp:Content>

