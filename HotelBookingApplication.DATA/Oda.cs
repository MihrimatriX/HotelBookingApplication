using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelBookingApplication.DATA
{
    public class Oda
    {
        public int OdaID { get; set; }
        public virtual List<OdaRezervasyon> OdaRezervasyonları { get; set; }

    }
}
