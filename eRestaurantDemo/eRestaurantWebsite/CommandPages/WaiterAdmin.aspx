<%@ Page Title="" Language="C#" MasterPageFile="~/Site.master" AutoEventWireup="true" CodeFile="WaiterAdmin.aspx.cs" Inherits="CommandPages_WaiterAdmin" %>

<%@ Register Src="../UserControl/MessageUserControl.ascx" TagName="MessageUserControl" TagPrefix="uc1" %>
<%@ Register Src="~/UserControl/MessageUserControl.ascx" TagPrefix="uc2" TagName="MessageUserControl" %>


<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="Server">
    <h1>Waiter Admin</h1>
    <p></p>
    <uc2:MessageUserControl runat="server" ID="MessageUserControl" />
    <asp:Label ID="label1" runat="server" Text="Select Waiter for update">

    </asp:Label><asp:DropDownList ID="WaiterList" runat="server" AppendDataBoundItems="True" DataSourceID="ObjectDataSource1" DataTextField="FullName" DataValueField="WaiterID">
        <asp:ListItem>[Select Waiter]</asp:ListItem>
    </asp:DropDownList>
    <asp:LinkButton ID="FetchWaiter" runat="server" OnClick="FetchWaiter_Click">Fench Waiter</asp:LinkButton>
    <br />
    <table align="center" style="width: 70%">
        <tr>
            <td style="width: 375px">&nbsp;</td>
            <td>
                &nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td style="width: 375px">ID:</td>
            <td>
                <asp:Label ID="WaiterID" runat="server" Text=""></asp:Label>
            </td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td style="width: 375px; height: 24px">First Name:</td>
            <td>
                <asp:TextBox ID="FirstName" runat="server"></asp:TextBox>
            </td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td style="width: 375px">Last Name:</td>
            <td style="height: 24px">
                <asp:TextBox ID="LastName" runat="server"></asp:TextBox>
            </td>
            <td style="height: 24px"></td>
        </tr>
        <tr>
            <td style="width: 375px">Phone:</td>
            <td>
                <asp:TextBox ID="Phone" runat="server"></asp:TextBox>
            </td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td style="width: 375px">Address:</td>
            <td>
                <asp:TextBox ID="Address" runat="server"></asp:TextBox>
            </td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td style="width: 375px">Date Hired (mm/dd/yyyy)</td>
            <td>
                <asp:TextBox ID="DateHired" runat="server"></asp:TextBox>
            </td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td style="width: 375px">Date Released (mm/dd/yyy)</td>
            <td>
                <asp:TextBox ID="DateReleased" runat="server"></asp:TextBox>
            </td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td style="width: 375px; height: 22px"></td>
            <td style="height: 22px"></td>
            <td style="height: 22px"></td>
        </tr>
        <tr>
            <td style="width: 375px">
                <asp:LinkButton ID="InsertWaiter" runat="server">Insert</asp:LinkButton>
            </td>
            <td>
                <asp:LinkButton ID="UpdateWaiter" runat="server">Update</asp:LinkButton>
            </td>
            <td>&nbsp;</td>
        </tr>
    </table>
    <br />
    <asp:ObjectDataSource ID="ObjectDataSource1" runat="server" DataObjectTypeName="eRestaurantSystem.DAL.Entities.Waiter" DeleteMethod="Waiters_Delete" InsertMethod="Waiters_Add" OldValuesParameterFormatString="original_{0}" SelectMethod="Waiters_List" TypeName="eRestaurantSystem.BLL.AdminController" UpdateMethod="Waitesr_Update"></asp:ObjectDataSource>
</asp:Content>

