using HotelBookingApplication.DATA;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelBookingApplication.DAL
{
    public class OdaMapping :EntityTypeConfiguration<Oda>
    {
        public OdaMapping()
        {
            ToTable("Oda");
            
        }
    }
}
