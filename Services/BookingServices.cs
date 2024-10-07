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
    public class BookingServices : IBookingRepository
    {
        protected readonly AppDbContext _context;

        public BookingServices(AppDbContext context)
        {
            _context = context;
        }

        public async Task Create(Booking booking)
        {
            if (booking == null)
            {
                throw new ArgumentNullException(nameof(booking), "La reserva no puede ser nulo.");
            }

            try
            {
                await _context.Bookings.AddAsync(booking);
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException dbEx)
            {
                throw new Exception("Error al agregar la reserva a la base de datos.", dbEx);
            }
            catch (Exception ex)
            {
                throw new Exception("Ocurrió un error inesperado al agregar la reserva.", ex);
            }
        }

        public async Task Delete(int id)
        {
            var booking = await _context.Bookings.FindAsync(id);
            if (booking != null)
            {
                _context.Bookings.Remove(booking);
                await _context.SaveChangesAsync();
            }
        }

        public async Task<IEnumerable<Booking>> FindByIdentification(string identificationNumber)
        {
            return await _context.Bookings
                .Include(b => b.Guest)
                .Include(b => b.Room)
                .Where(b => b.Guest.IdentificationNumber == identificationNumber)
                .ToListAsync();
        }

        public async Task<Booking?> GetById(int id)
        {
            return await _context.Bookings.FindAsync(id);
        }
    }
}