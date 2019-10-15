using HotelBookingApplication.DATA;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelBookinApplication.DAL
{
    class ReservationMapping : EntityTypeConfiguration<Reservation>
    {
        public ReservationMapping()
        {
            HasKey(x => x.RezervationID);
            HasRequired(x => x.Option).WithMany(x => x.Reservations).HasForeignKey(x => x.OptionID);
            HasRequired(x => x.AppUser).WithMany(x => x.Reservations).HasForeignKey(x => x.CustomerID);

            Property(x => x.ArrivalDate).HasColumnType("datetime2");
            Property(x => x.DepartureDate).HasColumnType("datetime2");
            Property(x => x.Price).HasColumnType("money");
        }
        
    }
}
