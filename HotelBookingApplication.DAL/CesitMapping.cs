using HotelBookingApplication.DATA;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelBookingApplication.DAL
{
    public class CesitMapping: EntityTypeConfiguration<Cesit>
    {
        public CesitMapping()
        {
            ToTable("Cesit");
            HasKey(x => x.CesitID);
            Property(x => x.RezCesit).IsRequired().HasMaxLength(25);

        }
    }
}
