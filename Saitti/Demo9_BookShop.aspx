<%@ Page Title="" Language="C#" MasterPageFile="~/0. SaitinMasteri.master" AutoEventWireup="true" CodeFile="Demo9_BookShop.aspx.cs" Inherits="Demo9_BookShop" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="body" runat="Server">
    <h1>Esan KirjakauppaX</h1> <asp:Label ID="lblMessages" runat="server" />
    <div class="w3-row">
        <!-- vasen lohko asiakkaat -->
        <div class="w3-container w3-third">
            <asp:Button ID="btnGetCustomers" runat="server" CssClass="w3-btn" OnClick="btnGetCustomers_Click" Text="Hae asiakkaat"/>
            <br />
            <br />
            <asp:DropDownList ID="ddlCustomers" runat="server" OnSelectedIndexChanged="ddlCustomers_SelectedIndexChanged" AutoPostBack="True" />
            <asp:GridView ID="gvCustomers" runat="server" />

        </div>

        <!-- oikea lohko kirjat -->
        <div class="w3-container w3-twothird">
            <asp:Button ID="btnGetBooks" runat="server" CssClass="w3-btn" OnClick="btnGetBooks_Click" Text="Hae kirjat" />
            <br />
            <br />

            <asp:GridView ID="gvBooks" runat="server" />
        </div>

    </div>
    <div class="w3-row">
        
        <asp:Literal ID="ltResult" runat="server" />
    </div>
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="footer" runat="Server">
    
</asp:Content>

