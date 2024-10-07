using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ApiHotel.Models;

namespace ApiHotel.Repositories
{
    public interface IGuestRepository
    {
        Task Register(Guest guest);
        Task<IEnumerable<Guest>> GetAll();
        Task<Guest?> GetById(int id);
        Task Update(Guest guest);
        Task Delete(int id);
        Task<IEnumerable<Guest>> GetByKeyword(string keyword);
    }
}