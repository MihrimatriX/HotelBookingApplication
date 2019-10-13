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
        public int TcNoSearch(string tcNo)
        {
            foreach (Customer item in db.Customers.ToList())
            {
                if (item.TCNo == tcNo)
                {
                    return item.CustomerID;
                }
            }
            return -1;
        }
        public bool IsAppUser(int customerId)
        {
            foreach (AppUser item in db.AppUsers.ToList())
            {
                if (item.CustomerID == customerId)
                    return true;
            }
            return false;
        }
        public void AddUser(int customerId, string username, string password)
        {
            AppUser appUser = new AppUser()
            {
                CustomerID = customerId,
                UserName = username,
                Password = password
            };
            db.AppUsers.Add(appUser);
            db.SaveChanges();
        }
        public void AddRoom(int numberOfRoom)
        {
            if (db.Rooms.ToList().Count != 20)
            {
                for (int i = db.Rooms.ToList().Count; i < numberOfRoom; i++)
                {
                    Room room = new Room();
                    db.Rooms.Add(room);
                }
            }
        }
        public void AddReservation(DateTime arrivalDate, DateTime departureDate, int optionId, int customerId, int numberOfCustomers)
        {
            Reservation reservation = new Reservation()
            {
                ArrivalDate = arrivalDate,
                DepartureDate = departureDate,
                OptionID = optionId,
                CustomerID = customerId,
                Price = CalculatePrice(numberOfCustomers,optionId)

            };
            db.Reservations.Add(reservation);
        }

        private decimal CalculatePrice(int numberOfCustomer,int optionId)
        {
        }

    }

}
