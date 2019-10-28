<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="showBooks.aspx.cs" Inherits="BookInformationKeeper.WebForm1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    
    
    <input type="text" runat="server" class="form-control" id="searchNameID" placeholder="Book Name">
    <asp:Button ID="searchButton" runat="server" Text="Button" OnClick="searchButton_Click" />
    

    <asp:GridView ID="booksGridView" runat="server" AutoGenerateColumns="False">
        <Columns>
            <asp:TemplateField HeaderText="Name">
                <ItemTemplate>
                    <%#Eval("BookName") %>
                </ItemTemplate>
            </asp:TemplateField>
            <asp:TemplateField HeaderText="ISBN">
                <ItemTemplate>
                    <%#Eval("Isbn") %>
                </ItemTemplate>
            </asp:TemplateField>
            <asp:TemplateField HeaderText="Author">
                <ItemTemplate>
                    <%#Eval("Author") %>
                </ItemTemplate>
            </asp:TemplateField>
        </Columns>

    </asp:GridView>

  
    

</asp:Content>
