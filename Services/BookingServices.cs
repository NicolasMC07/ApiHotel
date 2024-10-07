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
        protected readonly AppDbContext _context; // Database context for accessing bookings

        public BookingServices(AppDbContext context)
        {
            _context = context; // Initialize context
        }

        // Method to create a new booking
        public async Task Create(Booking booking)
        {
            if (booking == null)
            {
                throw new ArgumentNullException(nameof(booking), "The booking cannot be null."); // Ensure booking is not null
            }

            try
            {
                await _context.Bookings.AddAsync(booking); // Add booking to the context
                await _context.SaveChangesAsync(); // Save changes to the database
            }
            catch (DbUpdateException dbEx)
            {
                throw new Exception("Error while adding the booking to the database.", dbEx); // Handle database update exceptions
            }
            catch (Exception ex)
            {
                throw new Exception("An unexpected error occurred while adding the booking.", ex); // Handle other exceptions
            }
        }

        // Method to delete a booking by ID
        public async Task Delete(int id)
        {
            var booking = await _context.Bookings.FindAsync(id); // Find the booking by ID
            if (booking != null) // If booking exists
            {
                _context.Bookings.Remove(booking); // Remove booking from context
                await _context.SaveChangesAsync(); // Save changes to the database
            }
        }

        // Method to find bookings by guest identification number
        public async Task<IEnumerable<Booking>> FindByIdentification(string identificationNumber)
        {
            return await _context.Bookings
                .Include(b => b.Guest) // Include related guest data
                .Include(b => b.Room) // Include related room data
                .Where(b => b.Guest.IdentificationNumber == identificationNumber) // Filter by identification number
                .ToListAsync(); // Return the list of bookings
        }

        // Method to get a booking by ID
        public async Task<Booking?> GetById(int id)
        {
            return await _context.Bookings.FindAsync(id); // Return the booking if found
        }
    }
}
