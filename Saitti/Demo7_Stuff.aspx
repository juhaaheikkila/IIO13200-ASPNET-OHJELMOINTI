<%@ Page Title="" Language="C#" MasterPageFile="~/0. SaitinMasteri.master" AutoEventWireup="true" CodeFile="Demo7_Stuff.aspx.cs" Inherits="_Default" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="body" runat="Server">
    <asp:SqlDataSource ID="SqlDataSource2" runat="server" 
        ConflictDetection="CompareAllValues" 
        ConnectionString="<%$ ConnectionStrings:Oppilaat %>" 
        DeleteCommand="DELETE FROM [testi] WHERE [id] = @original_id AND [name] = @original_name AND [description] = @original_description" 
        InsertCommand="INSERT INTO [testi] ([name], [description]) VALUES (@name, @description)" 
        OldValuesParameterFormatString="original_{0}" 
        SelectCommand="SELECT [id], [name], [description] FROM [testi]" 
        UpdateCommand="UPDATE [testi] SET [name] = @name, [description] = @description WHERE [id] = @original_id AND [name] = @original_name AND [description] = @original_description">
        <DeleteParameters>
            <asp:Parameter Name="original_id" Type="Int32" />
            <asp:Parameter Name="original_name" Type="String" />
            <asp:Parameter Name="original_description" Type="String" />
        </DeleteParameters>
        <InsertParameters>
            <asp:Parameter Name="name" Type="String" />
            <asp:Parameter Name="description" Type="String" />
        </InsertParameters>
        <UpdateParameters>
            <asp:Parameter Name="name" Type="String" />
            <asp:Parameter Name="description" Type="String" />
            <asp:Parameter Name="original_id" Type="Int32" />
            <asp:Parameter Name="original_name" Type="String" />
            <asp:Parameter Name="original_description" Type="String" />
        </UpdateParameters>
    </asp:SqlDataSource>
    <asp:SqlDataSource ID="SqlDataSource1" runat="server"
        ConnectionString="<%$ ConnectionStrings:Oppilaat %>"
        DeleteCommand="DELETE FROM [testi] WHERE [id] = @id"
        InsertCommand="INSERT INTO [testi] ([name], [description]) VALUES (@name, @description)"
        SelectCommand="SELECT [id], [name], [description] FROM [testi]"
        UpdateCommand="UPDATE [testi] SET [name] = @name, [description] = @description WHERE [id] = @id">
        <DeleteParameters>
            <asp:Parameter Name="id" Type="Int32" />
        </DeleteParameters>
        <InsertParameters>
            <asp:Parameter Name="name" Type="String" />
            <asp:Parameter Name="description" Type="String" />
        </InsertParameters>
        <UpdateParameters>
            <asp:Parameter Name="name" Type="String" />
            <asp:Parameter Name="description" Type="String" />
            <asp:Parameter Name="id" Type="Int32" />
        </UpdateParameters>
    </asp:SqlDataSource>
    <h1 class="w3-container w3-indigo">Stuffeja and wares from all over the world</h1>
    <div class="w3-row">
        <!-- vasen esittää kaikki stuffit -->
        <div class="w3-container w3-half">
            <h2 class="w3-container w3-blue">Please select stuff to edit: </h2>
            <asp:GridView ID="gvStuff" runat="server"
                AutoGenerateColumns="false"
                OnSelectedIndexChanged="gvStuff_SelectedIndexChanged"
                DataSourceID="SqlDataSource2">
                <Columns>
                    <asp:ButtonField DataTextField="id" HeaderText="ID" CommandName="select"/>
                    <asp:BoundField DataField="name" HeaderText="Name"/>
                    <asp:BoundField DataField="description" HeaderText="Description"/>
                </Columns>

            </asp:GridView>
        </div>
        <!-- oikea esittää valitun stuffin muokkaus -->
        <div class="w3-container w3-half">
            <h2 class="w3-container w3-blue">Selected Stuff: <asp:Label ID="lblSelectedStuff" runat="server" Text="..." /></h2>
            
            <asp:DetailsView ID="dvStuff" runat="server" DataSourceID="SqlDataSource2">
                <Fields>
                    <asp:CommandField ShowDeleteButton="True" ShowEditButton="True" ShowInsertButton="True" />
                </Fields>

            </asp:DetailsView>
        </div>

        

    </div>
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="footer" runat="Server">
</asp:Content>

