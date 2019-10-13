using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelBookingApplication.DATA
{
    public class Rezervasyon
    {
        public int RezervasyonID { get; set; }
        public DateTime GirisTarihi { get; set; }
        public DateTime CikisTarihi { get; set; }
        public int CesitID { get; set; }
        public virtual List<OdaRezervasyon> OdaRezervasyonları { get; set; }
        public virtual List<RezervasyonMusteri> RezervasyonMüsterileri { get; set; }
        public virtual Cesit Cesit { get; set; }




    }
}
