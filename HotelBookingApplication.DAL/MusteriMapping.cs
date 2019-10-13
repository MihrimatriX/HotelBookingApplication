using HotelBookingApplication.DATA;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelBookingApplication.DAL
{
    public class MusteriMapping : EntityTypeConfiguration<Musteri>
    {
        public MusteriMapping()
        {
            ToTable("Musteriler");
            HasKey(x => x.MusteriID);
            HasRequired(x => x.User).WithRequiredPrincipal(x => x.Musteri);
            Property(x => x.Ad).IsRequired();
            Property(x => x.Soyad).IsRequired();
            Property(x => x.TcNo).IsRequired();
        }
    }
}
