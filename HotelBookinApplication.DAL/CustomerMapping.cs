using HotelBookingApplication.DATA;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelBookinApplication.DAL
{
    public class CustomerMapping : EntityTypeConfiguration<Customer>
    {
        public CustomerMapping()
        {
            HasKey(x => x.CustomerID);
            HasRequired(x => x.AppUser).WithRequiredPrincipal(x => x.Customer);
            Property(x => x.FirstName).IsRequired().HasMaxLength(50);
            Property(x => x.LastName).IsRequired().HasMaxLength(30);
            Property(x => x.TCNo).IsRequired().HasMaxLength(11);
        }
    }
}
