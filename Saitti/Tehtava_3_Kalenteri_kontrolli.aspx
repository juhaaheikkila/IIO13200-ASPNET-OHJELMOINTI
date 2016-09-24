<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Tehtava_3_Kalenteri_kontrolli.aspx.cs" Inherits="Tehtava_3_Kalenteri_kontrolli" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Kalenteri-kontrolli</title>
    <link href="CSS/demo.css" rel="stylesheet" type="text/css" />
</head>
<body>
    <form id="form1" runat="server">
        <div id="kalenteri">
            <h1>Tänään on:
                <asp:Label ID="lblToday" runat="server" Text="..."></asp:Label></h1>
            <p>Valitse haluamasi päivä: </p>
        </div>
        <div id="results">
            <p>
                Valittu päivä:
                <asp:TextBox ID="txtDate" runat="server" TextMode="Date" ToolTip="Valitse päivämäärä" OnTextChanged="txtDate_TextChanged" CausesValidation="True"></asp:TextBox>
                <asp:Button ID="btnOpenCalendar" runat="server" Text="kalenteri" OnClick="btnOpenCalendar_Click" UseSubmitBehavior="False" />
                <asp:Calendar ID="Calendar1" runat="server" OnSelectionChanged="Calendar1_SelectionChanged" NextMonthText="&amp;gt;&amp;gt;" PrevMonthText="&amp;lt;&amp;lt;" SelectMonthText="&amp;gt;"></asp:Calendar>

                <br />
                <asp:Label ID="lblSelectedDate" runat="server" Text="..."></asp:Label>
            </p>
            <p>
                Valitun päivän ja tämän päivän erotus:
                <li>
                    <asp:Label ID="lblResult" runat="server" Text="..."></asp:Label>
                </li>
            </p>
        </div>
        <div id="footer">
            <p>
                <asp:Label ID="lblMessages" runat="server" />
            </p>
        </div>
    </form>
</body>
</html>
