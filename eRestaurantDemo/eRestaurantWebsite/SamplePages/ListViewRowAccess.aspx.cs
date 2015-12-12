using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class SamplePages_ListViewRowAccess : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void ListView1_ItemCommand(object sender, ListViewCommandEventArgs e)
    {
        //get data passed from the button control using CommandArgument
        Label1.Text = "button press " + e.CommandArgument.ToString();

        //getting data from controls on the select ListView row by pressing the button

        //get the row
        ListViewDataItem rowcontents = e.Item as ListViewDataItem;

        //get the contents of a textbox called CapacityTextBox on the ListView
        Label1.Text += " capacity is " + (rowcontents.FindControl("CapacityTextBox") as TextBox).Text.ToString();

        //get the contents of a visible=false label called TableIDLabel on the ListView
        Label1.Text += " tableid is " + (rowcontents.FindControl("TableIDLabel") as Label).Text.ToString();
    }

     //<asp:ListView ID="ListView1" runat="server" DataSourceID="ObjectDataSource1"
     //    OnItemCommand="ListView1_ItemCommand">

    //the layout of the ItemTemplate is the same as AlternatingItemTemplate

     //   <AlternatingItemTemplate>
     //       <tr style="background-color:#FFF8DC;">
     //           <td>
     //               <asp:Button ID="selectButton" runat="server" CommandName="Add" CommandArgument='<%# "alt " + Eval("TableNumber") %>' Text="Add" />
                
     //           </td>
     //           <td>
     //               <asp:Label ID="TableIDLabel" runat="server" Text='<%# Eval("TableID") %>' visible="false" />
     //           </td>
     //           <td>
     //               <asp:TextBox ID="TableNumberTextBox" runat="server" Text='<%# Bind("TableNumber") %>' />
     //           </td>
     //           <td>
     //               <asp:CheckBox ID="SmokingCheckBox" runat="server" Checked='<%# Eval("Smoking") %>' Enabled="false" />
     //           </td>
     //           <td>
     //               <asp:TextBox ID="CapacityTextBox" runat="server" Text='<%# Bind("Capacity") %>' />
     //           </td>
     //           <td>
     //               <asp:CheckBox ID="AvailableCheckBox" runat="server" Checked='<%# Eval("Available") %>' Enabled="false" />
     //           </td>

     //       </tr>
     //   </AlternatingItemTemplate>

      //<LayoutTemplate>
      //      <table runat="server">
      //          <tr runat="server">
      //              <td runat="server">
      //                  <table id="itemPlaceholderContainer" runat="server" border="1" style="background-color: #FFFFFF;border-collapse: collapse;border-color: #999999;border-style:none;border-width:1px;font-family: Verdana, Arial, Helvetica, sans-serif;">
      //                      <tr runat="server" style="background-color:#DCDCDC;color: #000000;">
      //                          <th runat="server"></th>
                              
      //                          <th runat="server"></th>
      //                          <th runat="server">TableNumber</th>
      //                          <th runat="server">Smoking</th>
      //                          <th runat="server">Capacity</th>
      //                          <th runat="server">Available</th>

      //                      </tr>
      //                      <tr id="itemPlaceholder" runat="server">
      //                      </tr>
      //                  </table>
      //              </td>
      //          </tr>
      //          <tr runat="server">
      //              <td runat="server" style="text-align: center;background-color: #CCCCCC;font-family: Verdana, Arial, Helvetica, sans-serif;color: #000000;"></td>
      //          </tr>
      //      </table>
      //  </LayoutTemplate>
}