<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="SaveMobileInfo.aspx.cs" Inherits="MobileInformationKeeper.SaveMobileInfo" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">

    <form>
        <div>
            &nbsp;
        </div>
  <div class="form-group row">
    <label for="modelId" class="col-sm-2 col-form-label">Model Name</label>
    <div class="col-sm-10">
      <input type="text" runat="server" class="form-control" id="modelId" required>
    </div>
  </div>
  <div class="form-group row">
    <label for="imeiId" class="col-sm-2 col-form-label">IMEI</label>
    <div class="col-sm-10">
      <input type="text" runat="server" class="form-control" id="imeiId" maxlength="15" minlength="15" required>
    </div>
  </div>
  <div class="form-group row">
    <label for="priceId" class="col-sm-2 col-form-label">Price</label>
    <div class="col-sm-10">
      <input type="text" runat="server" class="form-control" id="priceId" required>
    </div>
  </div>
<div>
<asp:Button ID="Button1" class="btn btn-primary" runat="server" Text="save" OnClick="Button1_Click" />
    <asp:Label ID="saveButtonLabel" runat="server" Text=""></asp:Label>
</div>


</form>
</asp:Content>
