using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelBookingApplication.DATA
{
    public class RezervasyonMusteri
    {
        public int RezervasyonMusteriID { get; set; }
        public int RezervasyonID { get; set; }
        public int MusteriID { get; set; }
        public virtual Rezervasyon Rezervasyon { get; set; }
        public virtual Musteri Musteri { get; set; }

    }
}