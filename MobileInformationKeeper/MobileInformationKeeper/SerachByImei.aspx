<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="SerachByImei.aspx.cs" Inherits="MobileInformationKeeper.SerachByImei" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">

    <table style="width:100%;">
        <tr>
            <td class="modal-sm" style="width: 108px">&nbsp;</td>
            <td>&nbsp;</td>
            <td style="width: 399px">&nbsp;</td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
        </tr>

        <tr>
            <td class="modal-sm" style="width: 108px">
                <asp:Label ID="Label222" runat="server" Text="Imei"></asp:Label>
            </td>
            <td>

                <input type="text" runat="server" class="form-control" id="ImeiId1" required>
            </td>
            
            <td class="text-center">
                <asp:Button ID="searchButton2Id" runat="server" Text="Search" OnClick="searchButton2Id_Click" />
            </td>
        </tr>

                <tr>
            <td class="modal-sm" style="width: 108px">&nbsp;</td>
            <td>
                <asp:Label ID="NameLabel" runat="server" Text="Model Name"></asp:Label> <br />

                <asp:Label ID="ImeiLabelLabel2" runat="server" Text="IMEI"></asp:Label><br />

                <asp:Label ID="PriceLabel" runat="server" Text="Price"></asp:Label><br />
            </td>
            <td style="width: 399px">&nbsp;</td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
    </table>



</asp:Content>
