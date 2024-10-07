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
        protected readonly AppDbContext _context; // Database context for accessing guests

        public GuestServices(AppDbContext context)
        {
            _context = context; // Initialize context
        }

        // Method to delete a guest by ID
        public async Task Delete(int id)
        {
            var guest = await _context.Guests.FindAsync(id); // Find the guest by ID
            if (guest != null) // If guest exists
            {
                _context.Guests.Remove(guest); // Remove guest from context
                await _context.SaveChangesAsync(); // Save changes to the database
            }
        }

        // Method to get all guests
        public async Task<IEnumerable<Guest>> GetAll()
        {
            return await _context.Guests.ToListAsync(); // Return list of all guests
        }

        // Method to get a guest by ID
        public async Task<Guest?> GetById(int id)
        {
            return await _context.Guests.FindAsync(id); // Return the guest if found
        }

        // Method to get a guest by keyword (needs improvement)
        public async Task<Guest?> GetByKeyword(string keyword)
        {
            return await _context.Guests.FindAsync(keyword); // Find guest by keyword (this may need a query change)
        }

        // Method to register a new guest
        public async Task Register(Guest guest)
        {
            if (guest == null)
            {
                throw new ArgumentNullException(nameof(guest), "The guest cannot be null."); // Ensure guest is not null
            }

            try
            {
                await _context.Guests.AddAsync(guest); // Add guest to the context
                await _context.SaveChangesAsync(); // Save changes to the database
            }
            catch (DbUpdateException dbEx)
            {
                throw new Exception("Error while adding the guest to the database.", dbEx); // Handle database update exceptions
            }
            catch (Exception ex)
            {
                throw new Exception("An unexpected error occurred while adding the guest.", ex); // Handle other exceptions
            }
        }

        // Method to update an existing guest
        public async Task Update(Guest guest)
        {
            if (guest == null)
            {
                throw new ArgumentNullException(nameof(guest), "The guest cannot be null."); // Ensure guest is not null
            }

            try
            {
                _context.Entry(guest).State = EntityState.Modified; // Mark guest as modified
                await _context.SaveChangesAsync(); // Save changes to the database
            }
            catch (DbUpdateException dbEx)
            {
                throw new Exception("Error while updating the guest in the database.", dbEx); // Handle database update exceptions
            }
            catch (Exception ex)
            {
                throw new Exception("An unexpected error occurred while updating the guest.", ex); // Handle other exceptions
            }
        }
    }
}
