<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="SearchByPriceRange.aspx.cs" Inherits="MobileInformationKeeper.SearchByPriceRange" %>
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
                <asp:Label ID="Label1" runat="server" Text="Price Between"></asp:Label>
            </td>
            <td>

                <input type="text" runat="server" class="form-control" id="price1Id" required>
            </td>
            <td class="text-center" style="width: 399px">
                <asp:Label ID="Label2" runat="server" Text="and"></asp:Label>
            </td>
            <td>
                <input type="text" runat="server" class="form-control" id="price2Id" required>

            </td>
            <td class="text-center">
                <asp:Button ID="searchButtonId" runat="server" Text="Search" OnClick="searchButtonId_Click" />
            </td>
        </tr>
        <tr>
            <td class="modal-sm" style="width: 108px">&nbsp;</td>
            <td>&nbsp;</td>
            <td style="width: 399px">&nbsp;</td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
    </table>
    <asp:GridView ID="MobileGrirdView" runat="server" AutoGenerateColumns="False" CellPadding="4" ForeColor="#333333" GridLines="None">
        <AlternatingRowStyle BackColor="White" />
        <Columns>
            <asp:TemplateField HeaderText="sl#">
                <ItemTemplate>
                    <%#Eval("MobileId") %>
                </ItemTemplate>
            </asp:TemplateField>
            <asp:TemplateField HeaderText="Model Name">
                <ItemTemplate>
                    <%#Eval("ModelName") %>
                </ItemTemplate>
            </asp:TemplateField>
            <asp:TemplateField HeaderText="IMEI">
                <ItemTemplate>
                    <%#Eval("Imei") %>
                </ItemTemplate>
            </asp:TemplateField>
            <asp:TemplateField HeaderText="Price">
                <ItemTemplate>
                    <%#Eval("Price") %>
                </ItemTemplate>
            </asp:TemplateField>       
        </Columns>
        <EditRowStyle BackColor="#2461BF" />
        <FooterStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White" />
        <HeaderStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White" />
        <PagerStyle BackColor="#2461BF" ForeColor="White" HorizontalAlign="Center" />
        <RowStyle BackColor="#EFF3FB" />
        <SelectedRowStyle BackColor="#D1DDF1" Font-Bold="True" ForeColor="#333333" />
        <SortedAscendingCellStyle BackColor="#F5F7FB" />
        <SortedAscendingHeaderStyle BackColor="#6D95E1" />
        <SortedDescendingCellStyle BackColor="#E9EBEF" />
        <SortedDescendingHeaderStyle BackColor="#4870BE" />
    </asp:GridView>



</asp:Content>
