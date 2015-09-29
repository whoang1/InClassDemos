using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

#region Additional Namespaces
using eRestaurantSystem.DAL.Entities;
using System.Data.Entity;
#endregion

namespace eRestaurantSystem.DAL
{
    //this class should be restricted to access by ONLY by 
    //the BLL methods.
    //this class should NOT be accessable outside of the 
    //component library

    //this class inherits DbContext

    internal class eRestaurantContext : DbContext
    {
        public eRestaurantContext()
            : base("name=EatIn")
        {
            //constructor is used to pass web config string name
        }

        //setup the DBset Mappings
        //One DBSet for each entity I create.
        public DbSet<SpecialEvent> SpecialEvents { get; set; }
        public DbSet<Reservation> Reservations { get; set; }
        public DbSet<Table> Tables { get; set; }

        public DbSet<Bill> Bills { get; set; }
        public DbSet<BillItem> BillItems { get; set; }
        public DbSet<Item> Items { get; set; }
        public DbSet<MenuCategory> MenuCategories { get; set; }
        public DbSet<Waiter> Waiters { get; set; }

        //When overriding OnmodelCreating(), it is important to remember 
        //to call the base methods' implementation before you exit the method

        //The ManyToManyNavigationPropertyConfiguration.Map method lets you 
        //configure the tables and columns used for many-to-many relationships
        //It takes ManyToManyNavigationPropertyConfiguration instance in which 
        //you specify the column names by calling the MapLeftKey, MapRightKey,
        //and ToTable Methods.

        //The "left" key is the one specified in the HasMany method
        //the "right" Key is the one specified in the WithMany method

        //we have a many to many relationship between reservation and tables
        //a reservation may need many tables.
        //a table can have over time many reservations.

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder
                .Entity<Reservation>().HasMany(r => r.Tables)
                .WithMany(x => x.Reservations)
                .Map(mapping =>
                    {
                        mapping.ToTable("ReservationTables");
                        mapping.MapLeftKey("TableID");
                        mapping.MapRightKey("ReservationID");
                    });
            base.OnModelCreating(modelBuilder);
        }
    }
}
