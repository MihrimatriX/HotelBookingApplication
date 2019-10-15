using HotelBookingApplication.DATA;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelBookinApplication.DAL
{
    public class AppUserMapping : EntityTypeConfiguration<AppUser>
    {
        public AppUserMapping()
        {
            HasKey(x => x.CustomerID);
            Property(x => x.UserName).IsRequired().HasMaxLength(30);
            Property(x => x.Password).IsRequired().HasMaxLength(60);
        }
    }
}
