using HotelBookingApplication.DATA;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelBookinApplication.DAL
{
    class OptionMapping :EntityTypeConfiguration<Option>
    {
        public OptionMapping()
        {
            HasKey(x => x.OptionID);
            Property(x => x.OptionName).HasMaxLength(30).IsRequired();
            Property(x => x.Description).HasMaxLength(250);
        }
    }
}
