using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

#region Extra namespaces
using eRestaurantSystem.DAL.Entities.Security;
using Microsoft.AspNet.Identity.EntityFramework;
#endregion
namespace eRestaurantSystem.DAL.Security
{
    internal class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        public ApplicationDbContext()
            : base("DefaultConnection")
        {
        }
    }
}
