using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ApiHotel.Models;
using Microsoft.EntityFrameworkCore;

namespace ApiHotel.Seeders
{   
    //seeder class
    public class RoomSeeder
    {
        public static void Seed(ModelBuilder modelBuilder)
        {   
            // seeder data
            modelBuilder.Entity<Room>().HasData(
                new Room { Id = 1, RoomNumber = "1-1", RoomTypeId = 1, PricePerNight = 50.0, Availability = true, MaxOccupancyPersons = 1 },
                new Room { Id = 2, RoomNumber = "1-2", RoomTypeId = 1, PricePerNight = 50.0, Availability = false, MaxOccupancyPersons = 1 },
                new Room { Id = 3, RoomNumber = "1-3", RoomTypeId = 2, PricePerNight = 80.0, Availability = true, MaxOccupancyPersons = 2 },
                new Room { Id = 4, RoomNumber = "1-4", RoomTypeId = 2, PricePerNight = 80.0, Availability = false, MaxOccupancyPersons = 2 },
                new Room { Id = 5, RoomNumber = "1-5", RoomTypeId = 3, PricePerNight = 150.0, Availability = true, MaxOccupancyPersons = 2 },
                new Room { Id = 6, RoomNumber = "1-6", RoomTypeId = 3, PricePerNight = 150.0, Availability = false, MaxOccupancyPersons = 2 },
                new Room { Id = 7, RoomNumber = "1-7", RoomTypeId = 4, PricePerNight = 200.0, Availability = true, MaxOccupancyPersons = 4 },
                new Room { Id = 8, RoomNumber = "1-8", RoomTypeId = 4, PricePerNight = 200.0, Availability = false, MaxOccupancyPersons = 4 },
                new Room { Id = 9, RoomNumber = "1-9", RoomTypeId = 1, PricePerNight = 50.0, Availability = true, MaxOccupancyPersons = 1 },
                new Room { Id = 10, RoomNumber = "1-10", RoomTypeId = 1, PricePerNight = 50.0, Availability = false, MaxOccupancyPersons = 1 },
                new Room { Id = 11, RoomNumber = "2-1", RoomTypeId = 2, PricePerNight = 80.0, Availability = true, MaxOccupancyPersons = 2 },
                new Room { Id = 12, RoomNumber = "2-2", RoomTypeId = 2, PricePerNight = 80.0, Availability = false, MaxOccupancyPersons = 2 },
                new Room { Id = 13, RoomNumber = "2-3", RoomTypeId = 3, PricePerNight = 150.0, Availability = true, MaxOccupancyPersons = 2 },
                new Room { Id = 14, RoomNumber = "2-4", RoomTypeId = 3, PricePerNight = 150.0, Availability = false, MaxOccupancyPersons = 2 },
                new Room { Id = 15, RoomNumber = "2-5", RoomTypeId = 4, PricePerNight = 200.0, Availability = true, MaxOccupancyPersons = 4 },
                new Room { Id = 16, RoomNumber = "2-6", RoomTypeId = 4, PricePerNight = 200.0, Availability = false, MaxOccupancyPersons = 4 },
                new Room { Id = 17, RoomNumber = "2-7", RoomTypeId = 1, PricePerNight = 50.0, Availability = true, MaxOccupancyPersons = 1 },
                new Room { Id = 18, RoomNumber = "2-8", RoomTypeId = 1, PricePerNight = 50.0, Availability = false, MaxOccupancyPersons = 1 },
                new Room { Id = 19, RoomNumber = "2-9", RoomTypeId = 2, PricePerNight = 80.0, Availability = true, MaxOccupancyPersons = 2 },
                new Room { Id = 20, RoomNumber = "2-10", RoomTypeId = 2, PricePerNight = 80.0, Availability = false, MaxOccupancyPersons = 2 },
                new Room { Id = 21, RoomNumber = "3-1", RoomTypeId = 3, PricePerNight = 150.0, Availability = true, MaxOccupancyPersons = 2 },
                new Room { Id = 22, RoomNumber = "3-2", RoomTypeId = 3, PricePerNight = 150.0, Availability = false, MaxOccupancyPersons = 2 },
                new Room { Id = 23, RoomNumber = "3-3", RoomTypeId = 4, PricePerNight = 200.0, Availability = true, MaxOccupancyPersons = 4 },
                new Room { Id = 24, RoomNumber = "3-4", RoomTypeId = 4, PricePerNight = 200.0, Availability = false, MaxOccupancyPersons = 4 },
                new Room { Id = 25, RoomNumber = "3-5", RoomTypeId = 1, PricePerNight = 50.0, Availability = true, MaxOccupancyPersons = 1 },
                new Room { Id = 26, RoomNumber = "3-6", RoomTypeId = 1, PricePerNight = 50.0, Availability = false, MaxOccupancyPersons = 1 },
                new Room { Id = 27, RoomNumber = "3-7", RoomTypeId = 2, PricePerNight = 80.0, Availability = true, MaxOccupancyPersons = 2 },
                new Room { Id = 28, RoomNumber = "3-8", RoomTypeId = 2, PricePerNight = 80.0, Availability = false, MaxOccupancyPersons = 2 },
                new Room { Id = 29, RoomNumber = "3-9", RoomTypeId = 3, PricePerNight = 150.0, Availability = true, MaxOccupancyPersons = 2 },
                new Room { Id = 30, RoomNumber = "3-10", RoomTypeId = 3, PricePerNight = 150.0, Availability = false, MaxOccupancyPersons = 2 },
                new Room { Id = 31, RoomNumber = "4-1", RoomTypeId = 4, PricePerNight = 200.0, Availability = true, MaxOccupancyPersons = 4 },
                new Room { Id = 32, RoomNumber = "4-2", RoomTypeId = 4, PricePerNight = 200.0, Availability = false, MaxOccupancyPersons = 4 },
                new Room { Id = 33, RoomNumber = "4-3", RoomTypeId = 1, PricePerNight = 50.0, Availability = true, MaxOccupancyPersons = 1 },
                new Room { Id = 34, RoomNumber = "4-4", RoomTypeId = 1, PricePerNight = 50.0, Availability = false, MaxOccupancyPersons = 1 },
                new Room { Id = 35, RoomNumber = "4-5", RoomTypeId = 2, PricePerNight = 80.0, Availability = true, MaxOccupancyPersons = 2 },
                new Room { Id = 36, RoomNumber = "4-6", RoomTypeId = 2, PricePerNight = 80.0, Availability = false, MaxOccupancyPersons = 2 },
                new Room { Id = 37, RoomNumber = "4-7", RoomTypeId = 3, PricePerNight = 150.0, Availability = true, MaxOccupancyPersons = 2 },
                new Room { Id = 38, RoomNumber = "4-8", RoomTypeId = 3, PricePerNight = 150.0, Availability = false, MaxOccupancyPersons = 2 },
                new Room { Id = 39, RoomNumber = "4-9", RoomTypeId = 4, PricePerNight = 200.0, Availability = true, MaxOccupancyPersons = 4 },
                new Room { Id = 40, RoomNumber = "4-10", RoomTypeId = 4, PricePerNight = 200.0, Availability = false, MaxOccupancyPersons = 4 },
                new Room { Id = 41, RoomNumber = "5-1", RoomTypeId = 1, PricePerNight = 50.0, Availability = true, MaxOccupancyPersons = 1 },
                new Room { Id = 42, RoomNumber = "5-2", RoomTypeId = 1, PricePerNight = 50.0, Availability = false, MaxOccupancyPersons = 1 },
                new Room { Id = 43, RoomNumber = "5-3", RoomTypeId = 2, PricePerNight = 80.0, Availability = true, MaxOccupancyPersons = 2 },
                new Room { Id = 44, RoomNumber = "5-4", RoomTypeId = 2, PricePerNight = 80.0, Availability = false, MaxOccupancyPersons = 2 },
                new Room { Id = 45, RoomNumber = "5-5", RoomTypeId = 3, PricePerNight = 150.0, Availability = true, MaxOccupancyPersons = 2 },
                new Room { Id = 46, RoomNumber = "5-6", RoomTypeId = 3, PricePerNight = 150.0, Availability = false, MaxOccupancyPersons = 2 },
                new Room { Id = 47, RoomNumber = "5-7", RoomTypeId = 4, PricePerNight = 200.0, Availability = true, MaxOccupancyPersons = 4 },
                new Room { Id = 48, RoomNumber = "5-8", RoomTypeId = 4, PricePerNight = 200.0, Availability = false, MaxOccupancyPersons = 4 },
                new Room { Id = 49, RoomNumber = "5-9", RoomTypeId = 1, PricePerNight = 50.0, Availability = true, MaxOccupancyPersons = 1 },
                new Room { Id = 50, RoomNumber = "5-10", RoomTypeId = 1, PricePerNight = 50.0, Availability = false, MaxOccupancyPersons = 1 }
            );
        }
    }
}