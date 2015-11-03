using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

#region Additional Namespaces
using eRestaurantSystem.DAL;
using eRestaurantSystem.DAL.Entities;
using eRestaurantSystem.DAL.DTOs;
using eRestaurantSystem.DAL.POCOs;

#endregion

namespace eRestaurantSystem.BLL
{
    [DataObject]
    public class SeatingController
    {
        [DataObjectMethod(DataObjectMethodType.Select)]
        public List<ReservationCollection> ReservationsByTime(DateTime date)
        {
            using (var context = new eRestaurantContext())
            {
                var result = (from data in context.Reservations
                              where data.ReservationDate.Year == date.Year
                              && data.ReservationDate.Month == date.Month
                              && data.ReservationDate.Day == date.Day
                                  // && data.ReservationDate.Hour == timeSlot.Hours
                              && data.ReservationStatus == Reservation.Booked
                              select new ReservationSummary()
                              {
                                  ID = data.ReservationID,
                                  Name = data.CustomerName,
                                  Date = data.ReservationDate,
                                  NumberInParty = data.NumberInParty,
                                  Status = data.ReservationStatus,
                                  Event = data.Event.Description,
                                  Contact = data.ContactPhone
                              }).ToList();
                //The second part of this method uses the results of the 
                //first linq query.
                //Linq to Entity will only execute the query when it deems
                //necessary for having the result in memory.
                //
                //To get your query to execute and have the resulting data
                //inside memory for further use, you can attach the .ToList()
                //to the previous query.

                //Note: the second query is NOT using an Entity
                //it is using the results from a previous 

                //itemGroup is a temporary in memory data collection
                //this collection can be used in selecting your final 
                //data collect.
                var finalResult = from item in result
                                  orderby item.NumberInParty
                                  group item by item.Date.Hour into itemGroup
                                  select new ReservationCollection()
                                  {
                                      Hour = itemGroup.Key,
                                      Reservations = itemGroup.ToList()
                                  };
                return finalResult.OrderBy(x => x.Hour).ToList();
            }
        }
    }
}
