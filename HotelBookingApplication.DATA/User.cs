using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelBookingApplication.DATA
{
    public class User
    {
        public int UserID { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public string TcNo { get; set; }

        public virtual Musteri Musteri { get; set; }

        public virtual List<OdaRezervasyon> OdaRezervasyonları { get; set; }



    }
}
