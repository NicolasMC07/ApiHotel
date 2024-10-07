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
    public class RoomTypeServices : IRoomTypeRepository
    {   
        protected readonly AppDbContext _context; // Database context for accessing room types

        public RoomTypeServices(AppDbContext context)
        {
            _context = context; // Initialize the context
        }

        // Method to get all room types
        public async Task<IEnumerable<RoomType>> GetAll()
        {
            return await _context.RoomTypes.ToListAsync(); // Return a list of all room types
        }

        // Method to get a room type by ID
        public async Task<RoomType?> GetById(int id)
        {
            return await _context.RoomTypes.FindAsync(id); // Return the room type if found
        }
    }
}
