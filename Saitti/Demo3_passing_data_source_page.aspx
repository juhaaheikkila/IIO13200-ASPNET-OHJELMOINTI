<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Demo3_passing_data_source_page.aspx.cs" Inherits="Demo3_passing_data_source_page" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Data tranfer source-page</title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h1>Source page</h1>
            Message to send:
            <asp:TextBox ID="txtMessage" runat="server" OnTextChanged="txtMessage_TextChanged" />
            <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ErrorMessage="Pakollinen tieto!" ControlToValidate="txtMessage"></asp:RequiredFieldValidator><br />
                Vakioviestit: <asp:DropDownList ID="ddlMessages" runat="server" AutoPostBack="True" OnSelectedIndexChanged="ddlMessages_SelectedIndexChanged"></asp:DropDownList><br />
            <asp:Button ID="btnQuery" runat="server" Text="Case1: Query String" OnClick="btnQuery_Click" /><br />
            <asp:Button ID="btnSession" runat="server" Text="Case2: Session" OnClick="btnSession_Click" /><br />
            <asp:Button ID="btnCookie" runat="server" Text="Case3: Cookie" OnClick="btnCookie_Click" /><br />
            <asp:Button ID="btnPublicProperty" runat="server" Text="Case4: Property" OnClick="btnPublicProperty_Click" /><br />

        </div>
    </form>
</body>
</html>
