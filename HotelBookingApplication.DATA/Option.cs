using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelBookingApplication.DATA
{
    public class Option
    {
        public int OptionID { get; set; }
        public string OptionName { get; set; }
        public string Description { get; set; }
        public virtual List<Reservation> Reservations { get; set; }
    }
}
