using System;
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
    public class Table
    {
        [Key]
        public int TableID { get; set; }
        [Required(ErrorMessage = "Table Number is required")]
        [Range(1, 25, ErrorMessage = "Table Number must be a positive number")]
        public byte TableNumber { get; set; }
        public bool Smoking { get; set; }
        public int Capacity { get; set; }
        public bool Available { get; set; }

        //Navigation properties
        //the reservations table is a many to many relationship
        //to tables table
        //The sql ReservationsTable resolves this problem
        //However ReservationsTable holds only a compound primary key
        //We will NOT Creat a ReservationsTable entity in our project
        //  but handle it via navigation mapping
        //Therefore we will place a Icollection properties in 
        //  this entity refering to the Reservations table
        public virtual ICollection<Reservation> Reservations { get; set; }

        public Table()
        {
            Available = true;
        }
    }
}
