using HotelBookinApplication.DAL;
using HotelBookingApplication.DATA;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelBookingApplication.BLL
{
    public class Connection
    {
        Context db = new Context();
        public bool IsUserNameAvailable(string username)
        {
            foreach (AppUser item in db.AppUsers.ToList())
            {
                if (item.UserName == username)
                    return false;
            }
            return true;
        }
        public bool IsThisAlreadyCustomer()
        {
            foreach(Customer item db.Customers.ToList())
            {
                if (item.TCNo == )
            }
        }
    }
}
