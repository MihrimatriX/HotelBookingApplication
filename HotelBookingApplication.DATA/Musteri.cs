using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelBookingApplication.DATA
{
    public class Musteri
    {
        public int MusteriID { get; set; }
        public string Ad { get; set; }
        public string Soyad { get; set; }
        public string TcNo { get; set; }
        public int UserID { get; set; }
        public virtual User User { get; set; }

        public virtual List<RezervasyonMusteri> RezervasyonMusterileri { get; set; }

    }
}
