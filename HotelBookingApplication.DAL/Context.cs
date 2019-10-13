using HotelBookingApplication.DATA;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelBookingApplication.DAL
{
    public class Context : DbContext
    {
        public Context()
        {
            Database.Connection.ConnectionString = "server = .; database = OtellDb; uid = sa; pwd = 123";
        }



        public DbSet<Cesit> CesitTablosu { get; set; }
        public DbSet<Musteri> MusteriTablosu { get; set; }
        public DbSet<Oda> OdaTablosu { get; set; }
        public DbSet<OdaRezervasyon> OdaRezervasyonTablosu { get; set; }
        public DbSet<Rezervasyon > RezervasyonTablosu { get; set; }
        public DbSet<RezervasyonMusteri> RezervasyonMusteriTablosu { get; set; }
        public DbSet<User> UserTablosu { get; set; }


        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new CesitMapping());
            modelBuilder.Configurations.Add(new MusteriMapping());
            modelBuilder.Configurations.Add(new OdaMapping());
            modelBuilder.Configurations.Add(new OdaRezervasyonMapping());
            modelBuilder.Configurations.Add(new RezervasyonMapping());
            modelBuilder.Configurations.Add(new RezervasyonMusteriMapping());
            modelBuilder.Configurations.Add(new UserMapping());

            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();

            base.OnModelCreating(modelBuilder);
        }
    }
}
