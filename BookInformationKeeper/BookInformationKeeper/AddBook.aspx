<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="AddBook.aspx.cs" Inherits="BookInformationKeeper.AddBook" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <form>
        <div class="form-group">
            <label for="exampleInputEmail1">Name</label>
            <input type="text" runat="server" class="form-control" id="nameID" placeholder="Book Name">
        </div>
        <div class="form-group">
            <label for="exampleInputPassword1">ISBN</label>
            <input type="text" runat="server" class="form-control" id="isbnID" placeholder="XXXXX (13 Digits)">
        </div>
        <div class="form-group">
            <label for="exampleInputPassword1">Author</label>
            <input type="text" runat="server" class="form-control" id="authorID" placeholder="Mr. X">
        </div>
        <div>
            <asp:Button ID="saveButton" class="btn btn-primary" runat="server" Text="Save" OnClick="saveButton_Click" />

        </div>
        
        <asp:Label ID="saveButtonLabel" runat="server" Text=""></asp:Label>
        
    </form>
</asp:Content>
