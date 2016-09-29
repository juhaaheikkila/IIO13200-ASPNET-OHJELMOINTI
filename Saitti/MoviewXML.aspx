<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPageIP.master" AutoEventWireup="true" CodeFile="MoviewXML.aspx.cs" Inherits="MoviewXML" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="body" runat="Server">
    <!-- XMLData source määrittely -->
    <asp:XmlDataSource ID="srcMovies" runat="server" DataFile="~/App_Data/Movies.xml" XPath="//Movie"></asp:XmlDataSource>
    <!-- GridView-kontrolli esittää datan -->
    <h1>Esas movies from XML-file</h1>
    <asp:GridView ID="gvMovies" DataSourceID="srcMovies" HeaderStyle-BackColor="Blue" HeaderStyle-ForeColor="White" runat="server"></asp:GridView>
    <!-- datan esittäminen html:ssä -->
    <h1>Elokuvat listattuna</h1>
    <asp:Repeater ID="Repeater1" DataSourceID="srcMovies" runat="server">
        <HeaderTemplate>
            <table style="width: 50%" border="1">
                <tr>
                    <td>Elokuva</td>
                    <td>Ohjaaja</td>
                </tr>
        </HeaderTemplate>
        <ItemTemplate>
            <!-- <p><%# Eval("Name") %> ohjaaja: <%# Eval("Director") %></p>-->
            <tr>
                <td><%# Eval("Name") %></td>
                <td><%# Eval("Director") %></td>
            </tr>
        </ItemTemplate>
        <FooterTemplate>
            </table>
        </FooterTemplate>
    </asp:Repeater>
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="footer" runat="Server">
</asp:Content>

