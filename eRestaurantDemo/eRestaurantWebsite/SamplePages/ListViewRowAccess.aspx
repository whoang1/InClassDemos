<%@ Page Title="" Language="C#" MasterPageFile="~/Site.master" AutoEventWireup="true" CodeFile="ListViewRowAccess.aspx.cs" Inherits="SamplePages_ListViewRowAccess" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" Runat="Server">
    <asp:Label ID="Label1" runat="server" Text="Label"></asp:Label>
    <asp:ListView ID="ListView1" runat="server" DataSourceID="ObjectDataSource1"
         OnItemCommand="ListView1_ItemCommand">
        <AlternatingItemTemplate>
            <tr style="background-color:#FFF8DC;">
                <td>
                    <asp:Button ID="selectButton" runat="server" CommandName="Add" CommandArgument='<%# "alt " + Eval("TableNumber") %>' Text="Add" />
                
                </td>
                <td>
                    <asp:Label ID="TableIDLabel" runat="server" Text='<%# Eval("TableID") %>' visible="false" />
                </td>
                <td>
                    <asp:TextBox ID="TableNumberTextBox" runat="server" Text='<%# Bind("TableNumber") %>' />
                </td>
                <td>
                    <asp:CheckBox ID="SmokingCheckBox" runat="server" Checked='<%# Eval("Smoking") %>' Enabled="false" />
                </td>
                <td>
                    <asp:TextBox ID="CapacityTextBox" runat="server" Text='<%# Bind("Capacity") %>' />
                </td>
                <td>
                    <asp:CheckBox ID="AvailableCheckBox" runat="server" Checked='<%# Eval("Available") %>' Enabled="false" />
                </td>

            </tr>
        </AlternatingItemTemplate>
<%--        <EditItemTemplate>
            <tr style="background-color:#008A8C;color: #FFFFFF;">
                <td>
                    <asp:Button ID="UpdateButton" runat="server" CommandName="Update" Text="Update" />
                    <asp:Button ID="CancelButton" runat="server" CommandName="Cancel" Text="Cancel" />
                </td>
                <td>
                    <asp:TextBox ID="TableIDTextBox" runat="server" Text='<%# Bind("TableID") %>' />
                </td>
                <td>
                    <asp:TextBox ID="TableNumberTextBox" runat="server" Text='<%# Bind("TableNumber") %>' />
                </td>
                <td>
                    <asp:CheckBox ID="SmokingCheckBox" runat="server" Checked='<%# Bind("Smoking") %>' />
                </td>
                <td>
                    <asp:TextBox ID="CapacityTextBox" runat="server" Text='<%# Bind("Capacity") %>' />
                </td>
                <td>
                    <asp:CheckBox ID="AvailableCheckBox" runat="server" Checked='<%# Bind("Available") %>' />
                </td>
                <td>
                    <asp:TextBox ID="ReservationsTextBox" runat="server" Text='<%# Bind("Reservations") %>' />
                </td>
                <td>
                    <asp:TextBox ID="BillsTextBox" runat="server" Text='<%# Bind("Bills") %>' />
                </td>
            </tr>
        </EditItemTemplate>--%>
        <EmptyDataTemplate>
            <table runat="server" style="background-color: #FFFFFF;border-collapse: collapse;border-color: #999999;border-style:none;border-width:1px;">
                <tr>
                    <td>No data was returned.</td>
                </tr>
            </table>
        </EmptyDataTemplate>
<%--        <InsertItemTemplate>
            <tr style="">
                <td>
                    <asp:Button ID="InsertButton" runat="server" CommandName="Insert" Text="Insert" />
                    <asp:Button ID="CancelButton" runat="server" CommandName="Cancel" Text="Clear" />
                </td>
                <td>
                    <asp:TextBox ID="TableIDTextBox" runat="server" Text='<%# Bind("TableID") %>' />
                </td>
                <td>
                    <asp:TextBox ID="TableNumberTextBox" runat="server" Text='<%# Bind("TableNumber") %>' />
                </td>
                <td>
                    <asp:CheckBox ID="SmokingCheckBox" runat="server" Checked='<%# Bind("Smoking") %>' />
                </td>
                <td>
                    <asp:TextBox ID="CapacityTextBox" runat="server" Text='<%# Bind("Capacity") %>' />
                </td>
                <td>
                    <asp:CheckBox ID="AvailableCheckBox" runat="server" Checked='<%# Bind("Available") %>' />
                </td>

            </tr>
        </InsertItemTemplate>--%>
        <ItemTemplate>
            <tr style="background-color:#DCDCDC;color: #000000;">
                 <td>
                 <asp:Button ID="selectButton" runat="server" CommandName="Add" CommandArgument='<%# "Item " + Eval("TableNumber") %>' Text="Add" /> </td>
                <td>
                    <asp:Label ID="TableIDLabel" runat="server" Text='<%# Eval("TableID") %>' visible="false"/>
                </td>
                <td>
                    <asp:TextBox ID="TableNumberTextBox" runat="server" Text='<%# Bind("TableNumber") %>' />
                </td>
                <td>
                    <asp:CheckBox ID="SmokingCheckBox" runat="server" Checked='<%# Eval("Smoking") %>' Enabled="false" />
                </td>
                <td>
                     <asp:TextBox ID="CapacityTextBox" runat="server" Text='<%# Bind("Capacity") %>' />
                </td>
                <td>
                    <asp:CheckBox ID="AvailableCheckBox" runat="server" Checked='<%# Eval("Available") %>' Enabled="false" />
                </td>

            </tr>
        </ItemTemplate>
        <LayoutTemplate>
            <table runat="server">
                <tr runat="server">
                    <td runat="server">
                        <table id="itemPlaceholderContainer" runat="server" border="1" style="background-color: #FFFFFF;border-collapse: collapse;border-color: #999999;border-style:none;border-width:1px;font-family: Verdana, Arial, Helvetica, sans-serif;">
                            <tr runat="server" style="background-color:#DCDCDC;color: #000000;">
                                <th runat="server"></th>
                              
                                <th runat="server"></th>
                                <th runat="server">TableNumber</th>
                                <th runat="server">Smoking</th>
                                <th runat="server">Capacity</th>
                                <th runat="server">Available</th>

                            </tr>
                            <tr id="itemPlaceholder" runat="server">
                            </tr>
                        </table>
                    </td>
                </tr>
                <tr runat="server">
                    <td runat="server" style="text-align: center;background-color: #CCCCCC;font-family: Verdana, Arial, Helvetica, sans-serif;color: #000000;"></td>
                </tr>
            </table>
        </LayoutTemplate>
       <%-- <SelectedItemTemplate>
            <tr style="background-color:#008A8C;font-weight: bold;color: #FFFFFF;">
                <td>
                 <asp:Button ID="selectButton" runat="server" CommandName="Add" CommandArgument='<%# "select " + Eval("TableNumber") %>' Text="Add" />

                </td>
                <td>
                    <asp:Label ID="TableIDLabel" runat="server" Text='<%# Eval("TableID") %>' />
                </td>
                <td>
                    <asp:Label ID="TableNumberLabel" runat="server" Text='<%# Eval("TableNumber") %>' />
                </td>
                <td>
                    <asp:CheckBox ID="SmokingCheckBox" runat="server" Checked='<%# Eval("Smoking") %>' Enabled="false" />
                </td>
                <td>
                    <asp:Label ID="CapacityLabel" runat="server" Text='<%# Eval("Capacity") %>' />
                </td>
                <td>
                    <asp:CheckBox ID="AvailableCheckBox" runat="server" Checked='<%# Eval("Available") %>' Enabled="false" />
                </td>

            </tr>
        </SelectedItemTemplate>--%>
    </asp:ListView><br />
    <asp:ObjectDataSource ID="ObjectDataSource1" runat="server" OldValuesParameterFormatString="original_{0}" SelectMethod="Table_List" TypeName="eRestaurantSystem.BLL.AdminController"></asp:ObjectDataSource>
</asp:Content>

