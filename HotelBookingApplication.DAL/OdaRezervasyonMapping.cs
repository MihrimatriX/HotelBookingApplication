using HotelBookingApplication.DATA;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelBookingApplication.DAL
{
    public class OdaRezervasyonMapping : EntityTypeConfiguration<OdaRezervasyon>
    {
        public OdaRezervasyonMapping()
        {
            ToTable("OdaRezervasyon");
            HasRequired(x => x.Rezervasyon).WithMany(x => x.OdaRezervasyonları).HasForeignKey(x => x.RezervasyonID);
            HasRequired(x => x.Oda).WithMany(x => x.OdaRezervasyonları).HasForeignKey(x => x.OdaID);
        }
    }
}
