using HotelBookingApplication.DATA;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelBookinApplication.DAL
{
    public class RezervationCustomerMapping : EntityTypeConfiguration<ReservationCustomer>
    {
        public RezervationCustomerMapping()
        {
            HasKey(x => x.ReservationCustomerID);
            HasRequired(x => x.Reservation).WithMany(x => x.ReservationCustomers).HasForeignKey(x => x.ReservationID);
            HasRequired(x => x.Customer).WithMany(x => x.ReservationCustomers).HasForeignKey(x => x.CustomerID);
        }
    }
}
