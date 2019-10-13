using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelBookingApplication.DATA
{
    public class Cesit
    {
        public int CesitID { get; set; }
        public string RezCesit { get; set; }
        public virtual List<Rezervasyon> Rezervasyonlar { get; set; }


    }
}
