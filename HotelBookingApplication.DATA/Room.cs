using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelBookingApplication.DATA
{
    public class Room
    {
        public int RoomID { get; set; }
        public virtual List<ReservationRoom> ReservationRooms { get; set; }
    }
}
