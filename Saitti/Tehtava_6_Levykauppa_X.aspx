<%@ Page Title="" Language="C#" MasterPageFile="~/0. SaitinMasteri.master" AutoEventWireup="true" CodeFile="Tehtava_6_Levykauppa_X.aspx.cs" Inherits="_Default" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="body" Runat="Server">
    <asp:XmlDataSource ID="xmlLevykauppaX" runat="server" DataFile="~/App_Data/LevykauppaX.xml"></asp:XmlDataSource>
    <asp:DataList ID="dlLevyt" runat="server" DataSourceID="xmlLevykauppaX" RepeatColumns="1">
        
    </asp:DataList>

    <asp:GridView ID="gvData" runat="server"></asp:GridView>

</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="footer" Runat="Server">
</asp:Content>

