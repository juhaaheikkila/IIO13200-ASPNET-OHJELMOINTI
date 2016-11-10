<%@ Page Title="" Language="C#" MasterPageFile="~/0. SaitinMasteri.master" AutoEventWireup="true" CodeFile="Tehtava_5_Asiakastiedot_EntityFrameworkilla.aspx.cs" Inherits="Tehtava_5_Asiakastiedot_EntityFrameworkilla" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
    <link rel="stylesheet" href="CSS/InputForm.css" />
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="body" runat="Server">
    <h1>Asiakastiedot EntityFrameworkilla</h1>
    <div class="w3-row">
        <div id="divNavigation" class="w3-third" runat="server">

            <asp:Button
                ID="btnGetAllCustomers" runat="server"
                CssClass="w3-btn stbutton"
                OnClick="btnGetAllCustomers_Click"
                Text="Hae kaikki asiakkaat" />
            <br />

            <asp:DropDownList ID="ddlCountries" runat="server"
                CssClass="w3-btn stbutton select"
                OnSelectedIndexChanged="ddlCountries_SelectedIndexChanged"
                AutoPostBack="true" />
            <br />

            <asp:Button ID="btnGetAllCustomersByCountry" runat="server"
                CssClass="w3-btn stbutton"
                OnClick="btnGetAllCustomersByCountry_Click"
                Text="Hae asiakkaat maittain" />
            <br />
            <br />

            <asp:Button ID="btnAddNewCustomer" runat="server"
                CssClass="w3-btn stbutton w3-green"
                OnClick="btnAddNewCustomer_Click"
                Text="Lisää uusi asiakas" />
            <br />

        </div>

        <div class="w3-twothird">
            <div id="ResultList" runat="server">
                <asp:Literal ID="ltResult" runat="server" />
                <asp:GridView ID="gvCustomers" runat="server" />
            </div>
            <div id="NewCustomer" runat="server" visible="false">
                <div class="contact_form">
                    <ul>
                        <li>
                            <h2>Uusi asiakas</h2>
                            <span class="required_notification">* Denotes Required Field</span>
                        </li>
                        <li>
                            <label for="customerID">Tunnus:</label>
                            <asp:TextBox ID="customerID" runat="server" required></asp:TextBox>
                            <span class="form_hint">Asiakkaan tunnuskoodi</span>
                        </li>
                        <li>
                            <label for="customerName">Nimi:</label>
                            <asp:TextBox ID="customerName" runat="server" required></asp:TextBox>
                            <span class="form_hint">Asiakkaan nimi</span>
                        </li>
                        <li>
                            <label for="customerContactPerson">Yhteyshenkilö:</label>
                            <asp:TextBox ID="customerContactPerson" runat="server" required></asp:TextBox>
                            <span class="form_hint">Asiakkaan yhteyshenkilön nimi</span>
                        </li>

                        <li>
                            <label for="customerCountry">Maa:</label>
                            <asp:TextBox ID="customerCountry" runat="server" required></asp:TextBox>
                            <span class="form_hint">Asiakkaan maa</span>
                        </li>
                        <li>
                            <label for="customerZIP">Postitoimipaikka:</label>
                            <asp:TextBox ID="customerZIP" runat="server"></asp:TextBox>
                            <span class="form_hint">Asiakkaan postitoimipaikka</span>
                        </li>
                        <li>
                            <label for="customerZIPCode">Postinumero:</label>
                            <asp:TextBox ID="customerZIPCode" runat="server"></asp:TextBox>
                            <span class="form_hint">Asiakkaan postitoimipaikka</span>
                        </li>
                        <li>
                            <label for="customerBuys">Ostot:</label>
                            <asp:TextBox ID="customerBuys" runat="server" required></asp:TextBox>
                            <span class="form_hint">Asiakkaan ostot</span>
                        </li>

                        <li>
                            <label for="customerYear">Vuosi:</label>
                            <asp:TextBox ID="customerYear" runat="server"></asp:TextBox>
                            <span class="form_hint">Vuosi</span>
                        </li>
                    </ul>
                </div>
                <!--Action-buttons -->
                <br />
                <asp:Button ID="btnCustomerSave" runat="server"
                    CssClass="w3-btn stbutton w3-green"
                    OnClick="btnCustomerSave_Click"
                    Text="Tallenna" />

                <asp:Button ID="btnCustomerCancel" runat="server"
                    CssClass="w3-btn stbutton w3-deep-orange"
                    OnClick="btnCustomerCancel_Click"
                    Text="Peruuta"
                    formnovalidate="true" />
            </div>
            <br />

        </div>
    </div>
    <div class="w3-row">
    </div>
    <div class="w3-row">
    </div>

</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="footer" runat="Server">
</asp:Content>

