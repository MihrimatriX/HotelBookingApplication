using HotelBookingApplication.DATA;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelBookingApplication.DAL
{
    public class UserMapping : EntityTypeConfiguration<User>
    {
        public UserMapping()
        {
            ToTable("Users");
            HasKey(x => x.UserID);
            Property(x => x.UserName).IsRequired();
            Property(x => x.Password).IsRequired();
            Property(x => x.TcNo).IsRequired();

        }
    }
}
