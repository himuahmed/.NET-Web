<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="StudentRegistration.aspx.cs" Inherits="InformationManagement.StudentInfoUi" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <h2>Student Information Form</h2>
    <div class="form-group">
        <label for="inputStudentName">Student Name</label>
        <input type="text" class="form-control" id="inputStudentName" runat="server" placeholder="Enter Name"/>
        <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" Display="Dynamic" ControlToValidate="inputStudentName" ForeColor="red" ErrorMessage="Name Can't be empty"></asp:RequiredFieldValidator>
    </div>
    <div class="form-group">
        <label for="inputRegNo">Student Reg No</label>
        <input type="text" class="form-control" runat="server" id="inputRegNo" placeholder="Enter Reg No"/>
    </div>
    <div class="form-group">
        <label for="inputEmailAddress">Email Address</label>
        <input type="text" runat="server" class="form-control" id="inputEmailAddress" placeholder="Enter Email"/>
    </div>
    <div class="form-group">
        <label for="inputMobileNo">Mobile No</label>
        <input type="text" runat="server" class="form-control" id="inputMobileNo" placeholder="Enter Mobile No"/>
    </div>
    <div class="form-group">
        <label for="inputAge">Age</label>
        <input type="text" class="form-control" runat="server" id="inputAge" placeholder="Enter Age"/>
        <asp:CompareValidator ID="CompareValidator1" runat="server" ForeColor="red" ControlToValidate="inputAge" Display="Dynamic" Operator="DataTypeCheck" Type="Integer" ErrorMessage="Invalid Input"></asp:CompareValidator>
    </div>
    <div class="form-group">
        <label for="inputAddess">Address</label>
        <input type="text" runat="server" class="form-control" id="inputAddess" placeholder="Enter Address"/>
    </div>
    <div class="form-group">
        <label for="inputAddess">Department</label>
        <asp:DropDownList ID="ddlDepartment" CssClass="form-control" runat="server"/>
    </div>
    
    

    <asp:Button ID="saveButton" class="btn btn-primary" runat="server" Text="Save" OnClick="saveButton_Click" />
    <asp:Button ID="updateButton" class="btn btn-secondary" runat="server" Text="Update" OnClick="updateButton_OnClick" />
    <asp:Button ID="deleteButton" class="btn btn-danger" runat="server" Text="Delete" OnClick="deleteButton_OnClick" />
    
    <br/>
    <asp:Label ID="messageLabel" runat="server"></asp:Label>
    
</asp:Content>
