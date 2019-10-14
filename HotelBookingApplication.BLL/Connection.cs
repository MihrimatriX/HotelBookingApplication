using HotelBookinApplication.DAL;
using HotelBookingApplication.DATA;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelBookingApplication.BLL
{
    public static class Connection
    {
        static Context db = new Context();
        public static bool IsUserNameAvailable(string username)
        {
            foreach (AppUser item in db.AppUsers.ToList())
            {
                if (item.UserName == username)
                    return false;
            }
            return true;
        }
        //public static int TcNoSearch(string tcNo)
        //{
        //    foreach (Customer item in db.Customers.ToList())
        //    {
        //        if (item.TCNo == tcNo)
        //        {
        //            return item.CustomerID;
        //        }
        //    }
        //    return -1;
        //}

        public static void AddCustomer(string firstName, string lastName, string tcNo)
        {
            Customer customer = new Customer()
            {
                FirstName = firstName,
                LastName = lastName,
                TCNo = tcNo
            };
            db.Customers.Add(customer);
            db.SaveChanges();
        }


        public static int CustomerSearch(string tcNo)
        {
            foreach (Customer item in db.Customers.ToList())
            {
                if (item.TCNo == tcNo)
                    return item.CustomerID;
            }
            return -1;
        }

        public static bool IsAppUser(int customerID)
        {
            foreach (AppUser item in db.AppUsers)
            {
                if (item.CustomerID == customerID)
                    return true;
            }
            return false;
        }

        public static void AddAppUser(int customerId, string username, string password)
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

        public static void AddRoom(int numberOfRoom)
        {
            if (db.Rooms.ToList().Count != numberOfRoom)
            {
                for (int i = db.Rooms.ToList().Count; i < numberOfRoom; i++)
                {
                    Room room = new Room();
                    db.Rooms.Add(room);
                }
                db.SaveChanges();
            }
        }
        public static void AddReservation(DateTime arrivalDate, DateTime departureDate, int optionId, int customerId, int numberOfCustomers)
        {
            Reservation reservation = new Reservation()
            {
                ArrivalDate = arrivalDate,
                DepartureDate = departureDate,
                OptionID = optionId,
                CustomerID = customerId,
                Price = CalculatePrice(numberOfCustomers, optionId)

            };
            db.Reservations.Add(reservation);
        }

        private static decimal CalculatePrice(int numberOfCustomer, int optionId)
        {
            return 0;
        }

    }

}
