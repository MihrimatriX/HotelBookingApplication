using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelBookingApplication.DATA
{
    public class OdaRezervasyon
    {
        public int OdaRezervasyonID { get; set; }
        public int RezervasyonID { get; set; }
        public int OdaID { get; set; }
        public int UserID { get; set; }
        
        public virtual User User { get; set; }
        public virtual Oda Oda { get; set; }

        public virtual Rezervasyon Rezervasyon { get; set; }


    }
}
