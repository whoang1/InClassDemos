<%@ Page Title="" Language="C#" MasterPageFile="~/Site.master" AutoEventWireup="true" CodeFile="SpecialEventsAdmin.aspx.cs" Inherits="SamplePages_SpecialEventsAdmin" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" Runat="Server">
    <h1>Special Events Administration</h1>
    <table align="center" style="width: 80%">
        <tr>
            <td align="right" style="width:50%">Select an Event:&nbsp;&nbsp;</td>
            <td>
                <asp:DropDownList ID="SpecialEventList" runat="server" Width="200px" DataSourceID="ODSSpecialEvents" DataTextField="Description" DataValueField="EventCode" AppendDataBoundItems="True">
                <asp:ListItem Value="z">[Select Event]</asp:ListItem>
                </asp:DropDownList>&nbsp;&nbsp;
                <asp:LinkButton ID="FetchReservations" runat="server">Fetch Reservations</asp:LinkButton>
            </td>
        </tr>
        <tr>
            <td colspan="2" style="height: 22px">
                <asp:GridView ID="FetchReservation" runat="server" AllowPaging="True" AutoGenerateColumns="False" DataSourceID="ODSReservations" PageSize="20">
                    <AlternatingRowStyle BackColor="#CCCCCC" />
                    <Columns>
                        <asp:BoundField DataField="CustomerName" HeaderText="Name" SortExpression="CustomerName" />
                        <asp:BoundField DataField="ReservationDate" DataFormatString="{0:MMMM dd, yyyy}" HeaderText="Date" SortExpression="ReservationDate" />
                        <asp:BoundField DataField="NumberInParty" HeaderText="Size" SortExpression="NumberInParty" />
                        <asp:BoundField DataField="ContactPhone" HeaderText="Phone" SortExpression="ContactPhone" />
                        <asp:BoundField DataField="ReservationStatus" HeaderText="Status" SortExpression="ReservationStatus" />
                    </Columns>
                    <EmptyDataTemplate>
                        No data to display at this time.
                    </EmptyDataTemplate>
                    <HeaderStyle BackColor="Gray" Font-Size="Larger" />
                    <PagerSettings FirstPageText="Start" LastPageText="End" Mode="NumericFirstLast" PageButtonCount="5" Position="TopAndBottom" />
                </asp:GridView>
            </td>
        </tr>
        <tr>
            <td align="center">
                <asp:DetailsView ID="ReservationListDV" runat="server" Height="50px" Width="125px" AllowPaging="True" DataSourceID="ODSReservations">
                    <EmptyDataTemplate>
                        No data at this time
                    </EmptyDataTemplate>
                </asp:DetailsView>
            </td>
            
        </tr>
        <tr>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
    </table>
    <asp:ObjectDataSource ID="ODSSpecialEvents" runat="server" 
        OldValuesParameterFormatString="original_{0}" 
        SelectMethod="SpecialEvents_List" 
        TypeName="eRestaurantSystem.BLL.AdminController"></asp:ObjectDataSource>
    <asp:ObjectDataSource ID="ODSReservations" runat="server" 
        OldValuesParameterFormatString="original_{0}" 
        SelectMethod="GetReservationsByEventCode" 
        TypeName="eRestaurantSystem.BLL.AdminController">
        <SelectParameters>
            <asp:ControlParameter ControlID="SpecialEventList" Name="eventcode" PropertyName="SelectedValue" Type="String" />
        </SelectParameters>
    </asp:ObjectDataSource>

</asp:Content>

