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
        protected readonly AppDbContext _context;

        public RoomServices(AppDbContext context)
        {
            _context = context;
        }
        public async Task<IEnumerable<Room>> GetAll()
        {
            return await _context.Rooms.ToListAsync();
        }

        public async Task<IEnumerable<Room>> GetAvailable()
        {
            return await _context.Rooms.Where(r => r.Availability == true).ToListAsync();
        }

        public async Task<Room?> GetById(int id)
        {
            return await _context.Rooms.FindAsync(id);
        }

        public async Task<IEnumerable<Room>> GetOccupied()
        {
            return await _context.Rooms.Where(r => r.Availability == false).ToListAsync();

        }

        public async Task<object> GetRoomStatus()
        {
            var rooms = await _context.Rooms.ToListAsync();
            var occupiedCount = rooms.Count(r => !r.Availability);
            var availableCount = rooms.Count(r => r.Availability);

            var count = new
            {
                TotalRooms = rooms.Count,
                OccupiedRooms = occupiedCount,
                AvailableRooms = availableCount
            };
            return count;
        }
    }
}