using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

#region additional Namespace
using eRestaurantSystem.BLL; //controller
using eRestaurantSystem.DAL.Entities; //entity
using EatIn.UI;
#endregion
public partial class CommandPages_WaiterAdmin : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        DateHired.Text = DateTime.Today.ToShortDateString();
    }
    protected void FetchWaiter_Click(object sender, EventArgs e)
    {
        if (WaiterList.SelectedIndex == 0)
        {
            MessageUserControl.ShowInfo("Please select a waiter before clicking Fetch Waiter");
        }
        else
        {
            //We will use a tryrun() from the MessageUserControl
            //this will capture error messges when/if they happne 
            //and properly display in the user control.
            //GetWaiterInfor is you rmethod for accessing BLL and query
            MessageUserControl.TryRun((ProcessRequest)GetWaiterInfo);
        }
    }
    public void GetWaiterInfo()
    {
        //a standard lookup sequence
        AdminController sysmgr = new AdminController();

        var waiter = sysmgr.GetWaiterByID(int.Parse(WaiterList.SelectedValue));
        WaiterID.Text = waiter.WaiterID.ToString();
        FirstName.Text = waiter.FirstName;
        LastName.Text = waiter.LastName;
        Phone.Text = waiter.Phone;
        Address.Text = waiter.Address;
        DateHired.Text = waiter.HireDate.ToShortDateString();
        if(waiter.ReleaseDate.HasValue)
        {
            DateReleased.Text = waiter.ReleaseDate.ToShortDateString();
        }
    }
}