using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ApiHotel.Data;
using ApiHotel.Models;
using ApiHotel.Repositories;
using Microsoft.EntityFrameworkCore;

namespace ApiHotel.Services
{
    public class RoomServices : IRoomRepository
    {   
        protected readonly AppDbContext _context; // Database context for accessing rooms

        public RoomServices(AppDbContext context)
        {
            _context = context; // Initialize context
        }

        // Method to get all rooms
        public async Task<IEnumerable<Room>> GetAll()
        {
            return await _context.Rooms.ToListAsync(); // Return list of all rooms
        }

        // Method to get available rooms
        public async Task<IEnumerable<Room>> GetAvailable()
        {
            return await _context.Rooms.Where(r => r.Availability == true).ToListAsync(); // Return list of available rooms
        }

        // Method to get a room by ID
        public async Task<Room?> GetById(int id)
        {
            return await _context.Rooms.FindAsync(id); // Return the room if found
        }

        // Method to get occupied rooms
        public async Task<IEnumerable<Room>> GetOccupied()
        {
            return await _context.Rooms.Where(r => r.Availability == false).ToListAsync(); // Return list of occupied rooms
        }

        // Method to get the status of rooms (total, occupied, available)
        public async Task<object> GetRoomStatus()
        {
            var rooms = await _context.Rooms.ToListAsync(); // Get all rooms
            var occupiedCount = rooms.Count(r => !r.Availability); // Count occupied rooms
            var availableCount = rooms.Count(r => r.Availability); // Count available rooms

            var count = new
            {
                TotalRooms = rooms.Count, // Total number of rooms
                OccupiedRooms = occupiedCount, // Total number of occupied rooms
                AvailableRooms = availableCount // Total number of available rooms
            };
            return count; // Return the room status count
        }
    }
}
