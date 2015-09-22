using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

#region Additional NameSpaces
using eRestaurantSystem.DAL.Entities;
using eRestaurantSystem.DAL;
using System.ComponentModel; //Used for ODS access
#endregion
namespace eRestaurantSystem.BLL
{
    [DataObject]
    public class AdminController
    {
        [DataObjectMethod(DataObjectMethodType.Select,false)]
        public List<SpecialEvent> SpecialEvents_List()
        {
            using (var context = new eRestaurantContext())
            {
                //Retrieve the data from the SpecialEvents table
                //to do so we will use the DbSet in eRestaurantContext
                //      call SpecialEvents (done by mapping)
            
                //method syntax
                return context.SpecialEvents.OrderBy(x => x.Description).ToList();
            }
        }
    }
}
