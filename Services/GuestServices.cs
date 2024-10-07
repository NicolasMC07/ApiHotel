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
    public class GuestServices : IGuestRepository
    {
        protected readonly AppDbContext _context;

        public GuestServices(AppDbContext context)
        {
            _context = context;
        }
        public async Task Delete(int id)
        {
            var guest = await _context.Guests.FindAsync(id);
            if (guest != null)
            {
                _context.Guests.Remove(guest);
                await _context.SaveChangesAsync();
            }
        }

        public async Task<IEnumerable<Guest>> GetAll()
        {
            return await _context.Guests.ToListAsync();
        }

        public async Task<Guest?> GetById(int id)
        {
            return await _context.Guests.FindAsync(id);
        }

        public async Task<Guest?> GetByKeyword(string keyword)
        {
            return await _context.Guests.FindAsync(keyword);

        }

        public async Task Register(Guest guest)
        {
            if (guest == null)
            {
                throw new ArgumentNullException(nameof(guest), "El huesped no puede ser nulo.");
            }

            try
            {
                await _context.Guests.AddAsync(guest);
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException dbEx)
            {
                throw new Exception("Error al agregar el huesped a la base de datos.", dbEx);
            }
            catch (Exception ex)
            {
                throw new Exception("Ocurrió un error inesperado al agregar el huesped.", ex);
            }
        }

        public async Task Update(Guest guest)
        {
            if (guest == null)
            {
                throw new ArgumentNullException(nameof(guest), "El huesped no puede ser nulo.");
            }

            try
            {
                _context.Entry(guest).State = EntityState.Modified;
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException dbEx)
            {
                throw new Exception("Error al actualizar  el huesped en la base de datos.", dbEx);
            }
            catch (Exception ex)
            {
                throw new Exception("Ocurrió un error inesperado al actualizar el huesped.", ex);
            }
        }
    }
}