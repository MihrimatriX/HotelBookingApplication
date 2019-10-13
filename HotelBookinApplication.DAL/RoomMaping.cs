using HotelBookingApplication.DATA;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelBookinApplication.DAL
{
    class RoomMaping : EntityTypeConfiguration<Room>
    {
        public RoomMaping()
        {
            HasKey(x => x.RoomID);
        }

    }
}
