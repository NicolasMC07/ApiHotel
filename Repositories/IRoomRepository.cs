using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ApiHotel.Models;

namespace ApiHotel.Repositories
{   
    //interface
    public interface IRoomRepository
    {
        Task<IEnumerable<Room>> GetAll();
        Task<Room?> GetById(int id);
        Task<IEnumerable<Room>> GetAvailable();
        Task<IEnumerable<Room>> GetOccupied();
        Task<object> GetRoomStatus();
        
    }
}