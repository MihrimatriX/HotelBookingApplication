using HotelBookingApplication.DATA;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelBookingApplication.DAL
{
    public class RezervasyonMapping : EntityTypeConfiguration<Rezervasyon>
    {
        public RezervasyonMapping()
        {
            ToTable("Rezervasyonlar");
            HasKey(x => x.RezervasyonID);
            HasRequired(x => x.Cesit).WithMany(x => x.Rezervasyonlar).HasForeignKey(x => x.CesitID);

            Property(x => x.GirisTarihi).HasColumnType("datetime2").IsRequired();
            Property(x => x.CikisTarihi).HasColumnType("datetime2").IsRequired();
        }
    }
}
