<%@ Page Title="" Language="C#" MasterPageFile="~/0. SaitinMasteri.master" AutoEventWireup="true" CodeFile="demo5_xml_kontrolli_xsl_työntekijät.aspx.cs" Inherits="demo4_xml_työntekijät" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="body" runat="Server">
    <asp:Xml
        ID="Xml1"
        DocumentSource="~/App_Data/Työntekijät2013.xml"
        TransformSource="~/App_Data/Demo.xsl"
        runat="server"></asp:Xml>
    <br />

    <asp:Label ID="lblDataInfo" runat="server" Text="Label"></asp:Label>
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="footer" runat="Server">
</asp:Content>

