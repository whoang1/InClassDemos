using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

#region Additional NameSpaces
using eRestaurantSystem.DAL.Entities;
using eRestaurantSystem.DAL;
using System.ComponentModel;
using eRestaurantSystem.DAL.DTOs;
using eRestaurantSystem.DAL.POCOs; //Used for ODS access
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
                //return context.SpecialEvents.OrderBy(x => x.Description).ToList();

                //query syntax 
                var results = from item in context.SpecialEvents
                              orderby item.Description
                              select item;
                return results.ToList();
            }
        }

        [DataObjectMethod(DataObjectMethodType.Select, false)]
        public List<Reservation> GetReservationsByEventCode(string eventcode)
        {
            using (var context = new eRestaurantContext())
            {
          
                //query syntax 
                var results = from item in context.Reservations 
                              where item.EventCode.Equals(eventcode)
                              orderby item.CustomerName, item.ReservationDate
                              select item; 
                return results.ToList();
            }
        }
        
        [DataObjectMethod(DataObjectMethodType.Select, false)]
        public List<ReservationByDate> GetReservationByDate(string reservationdate)
        {
            using (var context = new eRestaurantContext())
            {
                //remember Linq does not like using DateTime casting
                int theYear = (DateTime.Parse(reservationdate)).Year;
                int theMonth = (DateTime.Parse(reservationdate)).Month;
                int theDay = (DateTime.Parse(reservationdate)).Day;

                //query status
                var results = from item in context.SpecialEvents
                              orderby item.Description
                              select new ReservationByDate() //DTO
                              {
                                  Description = item.Description,
                                  Reservations = from row in item.Reservations //Collection of navigated rows of ICollection in SpecialEvents entity
                                                 where row.ReservationDate.Year == theYear 
                                                 && row.ReservationDate.Month == theMonth
                                                 && row.ReservationDate.Day == theDay
                                                 select new ReservationDetail() //POCO
                                                 {
                                                     CustomerName = row.CustomerName,
                                                     ReservationDate = row.ReservationDate,
                                                     NumberInParty = row.NumberInParty,
                                                     ContactPhone = row.ContactPhone,
                                                     ReservationStatus = row.ReservationStatus.ToString()
                                                 }
                              };
                return results.ToList();
            }
        }

        [DataObjectMethod(DataObjectMethodType.Select, false)]
        public List<CategoryMenuItems> CategoryMenuItems_List()
        {
            using (var context = new eRestaurantContext())
            {
       

                //query status
                var results = from category in context.MenuCategories
                              orderby category.Description
                              select new CategoryMenuItems() //DTO
                              {
                                  Description = category.Description,
                                  MenuItems = from row in category.MenuItems//Collection of navigated rows of ICollection in SpecialEvents entity
                                              select new MenuItem()
                                              {
                                                  Description = row.Description,
                                                  Price = row.CurrentPrice,
                                                  Calories = row.Calories,
                                                  Comment = row.Comment
                                              }

                              };
                return results.ToList();
            }
        }
    }
}
