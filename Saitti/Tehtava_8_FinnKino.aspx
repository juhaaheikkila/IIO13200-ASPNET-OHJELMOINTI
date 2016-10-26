<%@ Page Title="" Language="C#" MasterPageFile="~/0. SaitinMasteri.master" AutoEventWireup="true" CodeFile="Tehtava_8_FinnKino.aspx.cs" Inherits="Tahtava_8_FinnKino" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="body" runat="Server">
    <table>
        <tr>
            <td width="180px">Valitse paikkakunta:</td>
            <td>
                <asp:DropDownList ID="lstLocations" OnSelectedIndexChanged="lstLocations_SelectedIndexChanged" runat="server" AutoPostBack="True" /><br />
            </td>
        </tr>
        <tr>
            <td colspan="2">
                <div id="myDiv" runat="server"/>

            </td>
        </tr>
    </table>
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="footer" runat="Server">
</asp:Content>

