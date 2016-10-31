<%@ Page Title="" Language="C#" MasterPageFile="~/0. SaitinMasteri.master" AutoEventWireup="true" CodeFile="Tehtava_7_palautteen anto.aspx.cs" Inherits="Tehtava_7_palautteen_anto" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="body" runat="Server">
    <!-- XMLData source määrittely -->
    <!--
    <asp:XmlDataSource
        ID="srcPalautteet"
        runat="server"
        DataFile="~/App_Data/Palautteet.xml"
        XPath="//palaute"
        TransformFile="~/App_Data/Palautteet.xsl"></asp:XmlDataSource>
    <asp:SqlDataSource ID="srcMysli" runat="server"
        ConnectionString="<%$ ConnectionStrings:MysliEsa %>"
        ProviderName="MySql.Data.MySqlClient"
        SelectCommand="SELECT * FROM [palaute]" />
    -->


    <div class="w3-row">
        <div class="w3-container w3-half">
            <h2 class="w3-container w3-blue">Anna palaute: </h2>
            <p>
                Pvm *:<br />
                <asp:TextBox ID="txtDate" runat="server" TextMode="Date" ToolTip="Valitse päivämäärä" OnTextChanged="txtDate_TextChanged" CausesValidation="False" AutoPostBack="True" Text="" Width="300" /><br />
                <br />
                <asp:RequiredFieldValidator runat="server"
                    ID="validateDate"
                    ControlToValidate="txtDate"
                    ErrorMessage="Kenttä on tyhjä"
                    SetFocusOnError="True">

                </asp:RequiredFieldValidator>
            </p>
            <p>
                Nimi *:<br />
                <asp:TextBox ID="txtName" runat="server" Width="300"></asp:TextBox><br />
                <asp:RequiredFieldValidator runat="server"
                    ControlToValidate="txtName"
                    ErrorMessage="Kenttä on tyhjä"
                    SetFocusOnError="True">

                </asp:RequiredFieldValidator>
            </p>
            <p>
                Olen oppinut *:<br />
                <br />
                <asp:TextBox ID="txtOlenOppinut" runat="server" Height="120" Width="300" TextMode="MultiLine"></asp:TextBox>
                <br />
                <asp:RequiredFieldValidator runat="server"
                    ControlToValidate="txtOlenOppinut"
                    ErrorMessage="Kenttä on tyhjä"
                    SetFocusOnError="True">

                </asp:RequiredFieldValidator>
            </p>
            Haluan oppia *:<br />
            <br />
            <asp:TextBox ID="txtHaluanOppia" runat="server" Height="120" Width="300" TextMode="MultiLine"></asp:TextBox>
            <br />
            <asp:RequiredFieldValidator runat="server"
                ControlToValidate="txtHaluanOppia"
                ErrorMessage="Kenttä on tyhjä"
                SetFocusOnError="True">

            </asp:RequiredFieldValidator>

            <br />
        </div>
        <div class="w3-container w3-half">
            <h2 class="w3-container w3-blue">Palaute jatkuu: </h2>
            <p>
                Hyvää *:<br />
                <br />
                <asp:TextBox ID="txtGoodStuff" runat="server" Height="120" Width="300" TextMode="MultiLine"></asp:TextBox><br />
                <asp:RequiredFieldValidator runat="server"
                    ControlToValidate="txtGoodStuff"
                    ErrorMessage="Kenttä on tyhjä"
                    SetFocusOnError="True">

                </asp:RequiredFieldValidator>
            </p>
            <p>
                Parannettavaa *:<br />
                <br />
                <asp:TextBox ID="txtNotSoGoodStuff" runat="server" Height="120" Width="300" TextMode="MultiLine"></asp:TextBox><br />
                <asp:RequiredFieldValidator runat="server"
                    ControlToValidate="txtGoodStuff"
                    ErrorMessage="Kenttä on tyhjä"
                    SetFocusOnError="True">

                </asp:RequiredFieldValidator>
            </p>
            <p>
                Muuta:<br />
                <br />
                <asp:TextBox ID="txtOther" runat="server" Height="120" Width="300" TextMode="MultiLine"></asp:TextBox>
            </p>
            <asp:Button ID="btnSendFeedBackXML" runat="server" OnClick="btnSendFeedBackXML_Click" Text="Lähetä palaute XML" />
            <asp:Button ID="btnSendFeedBackMySQL" runat="server" OnClick="btnSendFeedBackMySQL_Click" Text="Lähetä palaute Mysli" />
        </div>
    </div>
    <div id="div1" class="w3-row" runat="server">
        <asp:Button ID="btnShowFeedback" runat="server" Text="Näytä palautteet" OnClick="btnShowFeedback_Click" CausesValidation="false"/>
    </div>
    <div id="divTables" class="w3-row" runat="server">

        <h2 class="w3-container w3-blue">Annetut palautteet XML:
            <asp:Label ID="lblAnnetutPalautteetXML" runat="server" Text="..."></asp:Label></h2>

        <br />
        <asp:GridView ID="gvPalautteet" runat="server" />
        <br />
        <h2 class="w3-container w3-blue">Annetut palautteet MySQL:<asp:Label ID="lblAnnetutPalautteetMySQL" runat="server" Text="..."></asp:Label></h2>
        <asp:GridView ID="gvMySqlPalaute" runat="server">
        </asp:GridView>
    </div>
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="footer" runat="Server">
</asp:Content>

