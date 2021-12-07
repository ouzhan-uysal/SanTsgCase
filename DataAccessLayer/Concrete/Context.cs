using EntityLayer.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Concrete
{
    public class Context : DbContext  // DbContext class'ından miras alarak bağlantı adresinin tanımlanacak. 
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=.;Initial Catalog=SanProjectDB;Integrated Security=True");
        }
        // Tables to be created in the database
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Flight> Flights { get; set; }
        public DbSet<Hotel> Hotels { get; set; }
        public DbSet<Location> Locations { get; set; }
        public DbSet<Reservation> Reservations { get; set; }
        public DbSet<Reservation_Customer> Reservation_Customers { get; set; }
        public DbSet<Reservation_Service> Reservation_Services { get; set; }
        public DbSet<User> Users { get; set; }
    }
}
