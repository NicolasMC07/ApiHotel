using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ApiHotel.Models;

namespace ApiHotel.Repositories
{
    public interface IRoomRepository
    {
        Task<IEnumerable<Room>> GetAll();
        Task<Room?> GetById(int id);
        Task<IEnumerable<Room>> GetAvailableAsync();
        Task<IEnumerable<Room>> GetOccupiedAsync();
        Task<(int available, int occupied)> GetRoomStatusAsync();
    }
}