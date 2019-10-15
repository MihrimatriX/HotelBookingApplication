using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelBookingApplication.DATA
{
    public class ReservationRoom
    {
        public int ReservationRoomID { get; set; }
        public int ReservationID { get; set; }
        public int RoomID { get; set; }
        public virtual Room Room { get; set; }
        public virtual Reservation Reservation { get; set; }
    }
}
