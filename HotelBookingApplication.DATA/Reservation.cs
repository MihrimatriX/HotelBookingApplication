using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelBookingApplication.DATA
{
    public class Reservation
    {
        public int RezervationID { get; set; }
        public DateTime ArrivalDate { get; set; }
        public DateTime DepartureDate { get; set; }
        public int OptionID { get; set; }
        public int CustomerID { get; set; }
        public decimal Price { get; set; }
        public virtual Option Option { get; set; }
        public List<ReservationCustomer> ReservationCustomers { get; set; }
        public List<ReservationRoom> ReservationRooms { get; set; }
        public virtual AppUser AppUser { get; set; }
    }
}
