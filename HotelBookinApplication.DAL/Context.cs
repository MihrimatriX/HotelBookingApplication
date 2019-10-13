using HotelBookingApplication.DATA;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelBookinApplication.DAL
{
    public class Context : DbContext
    {
        public Context()
        {
            Database.Connection.ConnectionString = "server = .; database = HotelDb; uid = sa; pwd = 123";
        }


        public DbSet<AppUser> AppUsers { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Option> Options { get; set; }
        public DbSet<Reservation> Reservations { get; set; }
        public DbSet<ReservationCustomer> ReservationCustomers { get; set; }
        public DbSet<ReservationRoom> ReservationRooms { get; set; }
        public DbSet<Room> Rooms { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new AppUserMapping());
            modelBuilder.Configurations.Add(new CustomerMapping());
            modelBuilder.Configurations.Add(new OptionMapping());
            modelBuilder.Configurations.Add(new ReservationMapping());
            modelBuilder.Configurations.Add(new ReservationRoomMapping());
            modelBuilder.Configurations.Add(new RezervationCustomerMapping());
            modelBuilder.Configurations.Add(new RoomMaping());







            base.OnModelCreating(modelBuilder);
        }
    }
}
