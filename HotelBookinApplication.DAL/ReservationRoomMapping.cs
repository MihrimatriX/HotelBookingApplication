using HotelBookingApplication.DATA;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelBookinApplication.DAL
{
    class ReservationRoomMapping : EntityTypeConfiguration<ReservationRoom>
    {
        public ReservationRoomMapping()
        {
            HasRequired(x => x.Reservation).WithMany(x => x.ReservationRooms).HasForeignKey(x => x.ReservationID);
            HasRequired(x => x.Room).WithMany(x => x.ReservationRooms).HasForeignKey(x => x.RoomID);
        }
    }
}
