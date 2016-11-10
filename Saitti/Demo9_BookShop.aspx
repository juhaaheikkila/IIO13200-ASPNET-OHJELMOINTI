<%@ Page Title="" Language="C#" MasterPageFile="~/0. SaitinMasteri.master" AutoEventWireup="true" CodeFile="Demo9_BookShop.aspx.cs" Inherits="Demo9_BookShop" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="body" runat="Server">
    <h1>Esan KirjakauppaX</h1>
    <asp:Label ID="lblMessages" runat="server" />
    <div class="w3-row">
        <!-- vasen lohko asiakkaat -->
        <div class="w3-container w3-third">
            <asp:Button ID="btnGetCustomers" runat="server" CssClass="w3-btn" OnClick="btnGetCustomers_Click" Text="Hae asiakkaat" />
            <br />
            <br />
            
            <asp:GridView ID="gvCustomers" runat="server" />
        </div>
        <!-- keskilohko: asiakas CRUD -->
        <div class="w3-container w3-third">
            <h2>Asiakkaan lisäys, muokkaus, poisto</h2>
            <asp:DropDownList ID="ddlCustomers" runat="server" OnSelectedIndexChanged="ddlCustomers_SelectedIndexChanged" AutoPostBack="True" />
            <p>Etunimi: <asp:TextBox ID="txtFirstName" runat="server"></asp:TextBox></p>
            <p>Sukunimi: <asp:TextBox ID="txtLastName" runat="server"></asp:TextBox></p>
            <asp:Button ID="btnNewCustomer" runat="server" Text="Luo uusi" CssClass="w3-btn" OnClick="btnNewCustomer_Click"/>
            <asp:Button ID="btnSaveCustomer" runat="server" Text="Tallenna" CssClass="w3-btn" OnClick="btnSaveCustomer_Click"/>
            <asp:Button ID="btnDeleteCustomer" runat="server" Text="Poista" CssClass="w3-btn" OnClick="btnDeleteCustomer_Click"/>
        </div>
        <!-- oikea lohko kirjat -->
        <div class="w3-container w3-third">
            <asp:Button ID="btnGetBooks" runat="server" CssClass="w3-btn w3-blue" OnClick="btnGetBooks_Click" Text="Hae kirjat" />
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

