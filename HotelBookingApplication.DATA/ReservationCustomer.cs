using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelBookingApplication.DATA
{
    public class ReservationCustomer
    {
        public int ReservationCustomerID { get; set; }
        public int CustomerID { get; set; }
        public int ReservationID { get; set; }
        public virtual Customer Customer { get; set; }
        public virtual Reservation Reservation { get; set; }
    }
}
