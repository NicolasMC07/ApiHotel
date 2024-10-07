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
        protected readonly AppDbContext _context;

        public RoomTypeServices(AppDbContext context)
        {
            _context = context;
        }
        public async Task<IEnumerable<RoomType>> GetAll()
        {
            return await _context.RoomTypes.ToListAsync();
        }

        public async Task<RoomType?> GetById(int id)
        {
            return await _context.RoomTypes.FindAsync(id);
        }
    }
}