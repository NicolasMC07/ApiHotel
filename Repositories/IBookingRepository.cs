using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ApiHotel.Models;

namespace ApiHotel.Repositories
{   
    //interface
    public interface IBookingRepository
    {
        Task<IEnumerable<Booking>> FindByIdentification(string identificationNumber);
        Task<Booking?> GetById(int id);
        Task Create(Booking booking);
        Task Delete(int id);
    }
}