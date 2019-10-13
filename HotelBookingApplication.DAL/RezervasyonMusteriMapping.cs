using HotelBookingApplication.DATA;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelBookingApplication.DAL
{
    public class RezervasyonMusteriMapping:EntityTypeConfiguration<RezervasyonMusteri>
    {
        public RezervasyonMusteriMapping()
        {
            ToTable("RezervasyonMusteri");
            HasRequired(x => x.Rezervasyon).WithMany(x => x.RezervasyonMüsterileri).HasForeignKey(x => x.RezervasyonID);
            HasRequired(x => x.Musteri).WithMany(x => x.RezervasyonMusterileri).HasForeignKey(x => x.MusteriID);
        }
    }
}
