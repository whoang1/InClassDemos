using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

#region Extra namespaces
using Microsoft.AspNet.Identity.EntityFramework;

#endregion 

namespace eRestaurantSystem.DAL.Entities.Security
{
    public class ApplicationUser : IdentityUser
    {
        public int? WaiterID { get; set; }
    }
}
