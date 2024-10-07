using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ApiHotel.Models;
using ApiHotel.Seeders;
using Microsoft.EntityFrameworkCore;

namespace ApiHotel.Data
{
    public class AppDbContext : DbContext
    {   
        public DbSet<Booking> Bookings { get; set; }
        public DbSet<Room> Rooms { get; set; }
        public DbSet<Guest> Guests  { get; set; }
        public  DbSet<RoomType> RoomTypes { get; set; }
        public DbSet<Employe> Employes { get; set; }

        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            //Seeders
            RoomTypeSeeder.Seed(modelBuilder);
            RoomSeeder.Seed(modelBuilder);
            
        }

    }
}
