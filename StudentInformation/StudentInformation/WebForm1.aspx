<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="StudentInformation.WebForm1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
   <div class="form-row">
    <div class="form-group col-md-12">
          <div class="form-group">
    <label for="studentName">Student Name</label>
    <input type="text" runat="server" class="form-control" id="studentName" placeholder="XYZ"/>
              <asp:RequiredFieldValidator ID="RequiredFieldValidator1" Display="Dynamic" runat="server" ControlToValidate ="studentName" ErrorMessage="Name is required" ForeColor="Red"></asp:RequiredFieldValidator>
  </div>
 <div class="form-group">
     <label for="studentEmail">Email</label>
     <input type="email"  runat="server" class="form-control" id="studentEmail" placeholder="something@mail.com">
 </div>
          <div class="form-group">
    <label for="studentRegNo">Student RegNo. </label>
    <input type="text" runat="server"  class="form-control" id="studentRegNo" placeholder="XXXXXXX">
  </div>
          <div class="form-group">
    <label for="inputAddress">Phone No.</label>
    <input type="text" runat="server"  class="form-control" id="studentPhoneNo" placeholder="0xxxxxxxx">
  </div>
          <div class="form-group">
    <label for="studentAge">Age</label>
    <input type="text" runat="server" class="form-control" id="studentAge" placeholder="XX"/>
   <asp:CompareValidator ID="CompareValidator1" runat="server" ControlToValidate="studentAge" Type="Integer" Operator="DataTypeCheck" ErrorMessage="Age must be round up numbers" ForeColor="Red" Display="Dynamic"></asp:CompareValidator>

  </div>
          <div class="form-group">
    <label for="studentAddress">Address</label>
    <input type="text" runat="server" class="form-control" id="studentAddress" placeholder="1234 Main St">
  </div>
        <asp:Button ID="saveButton" class="btn btn-primary" runat="server" Text="Save" OnClick="saveButton_Click" />
        <asp:Label ID="saveLabel" runat="server" Text=""></asp:Label>
  </div> 
    </div>

    <div>
        <asp:GridView ID="studentGridView" runat="server"></asp:GridView>
    </div>
</asp:Content>
