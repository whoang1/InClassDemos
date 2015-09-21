﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

#region Additional Namespaces
using System.Data.Entity;
using System.ComponentModel.DataAnnotations;
#endregion

namespace eRestaurantSystem.Entities
{
    public class Reservation
    {
        [Key]
        public int ReservationID { get; set; }
        [Required]
        [StringLength(40)]
        public string CustomerName { get; set; }
        public DateTime ReservationDate { get; set; }
        [Range(1, 16, ErrorMessage="Party size is limited to 1 - 16."),]
        public int NumberInParty { get; set; }
        [StringLength(15)]
        public string ContactPhone { get; set; }
        [Required, StringLength(1, MinimumLength=1)]
        public string ReservationStatus { get; set; }
        [StringLength(1)]
        public string EventCode { get; set; }

        //Navigation properties
        public virtual SpecialEvent Event { get; set; }
        //the reservations table is a many to many relationship
        //to tables table
        //The sql ReservationsTable resolves this problem
        //However ReservationsTable holds only a compound primary key
        //We will NOT Creat a ReservationsTable entity in our project
        //  but handle it via navigation mapping
        //Therefore we will place a Icollection properties in 
        //  this entity refering to the Tables table
        public virtual ICollection<Table> Tables { get; set; }

    }
}
