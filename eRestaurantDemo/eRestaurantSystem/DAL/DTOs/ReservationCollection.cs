<<<<<<< HEAD
﻿
using System;
=======
﻿using System;
>>>>>>> origin/master
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

<<<<<<< HEAD
#region Additional Namespaces
using eRestaurantSystem.DAL.POCOs;
#endregion 
=======
#region "Addiontional namespaces"
using eRestaurantSystem.DAL.POCOs;

#endregion
>>>>>>> origin/master

namespace eRestaurantSystem.DAL.DTOs
{
    public class ReservationCollection
    {
        //data properties
        public int Hour { get; set; }
<<<<<<< HEAD
        public virtual ICollection<ReservationSummary> Reservations { get; set; }
  
        //read only property
        public TimeSpan SeatingTime { get { return new TimeSpan(Hour, 0, 0); } } 
=======
        public TimeSpan SeatingTime { get { return new TimeSpan(Hour, 0, 0); } }

        //ready only property 
        public virtual ICollection<ReservationSummary> Reservations { get; set; }
>>>>>>> origin/master
    }
}
