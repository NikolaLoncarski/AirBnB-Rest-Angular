using AirBnB.Domain.Domain;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AirBnB.Domain.AppContext
{
    public class AppDbContext:DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }

        public DbSet<Adress> Adresses { get; set; }
        public DbSet<Amenitie> Amenities { get; set; }
        public DbSet<Image> Images { get; set; }
        public DbSet<Location> Locations { get; set; }
        public DbSet<RealEstate> RealEstates { get; set; }
        public DbSet<Reservation> Reservations { get; set; }
        public DbSet<Review> Reviews { get; set; }
        public DbSet<User> Users { get; set; }
        
    }
}
