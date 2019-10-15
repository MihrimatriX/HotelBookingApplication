using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelBookingApplication.DATA
{
    public class AppUser
    {
        public int CustomerID { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public virtual Customer Customer { get; set; }
        public virtual List<Reservation> Reservations { get; set; }
    }
}
