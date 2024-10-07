using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ApiHotel.Repositories;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Swashbuckle.AspNetCore.Annotations;

namespace ApiHotel.Controllers.V1.BookingControllers
{
    [ApiController]
    [Route("api/v1/booking_delete")]
    [ApiExplorerSettings(GroupName = "v1")]
    public class BookingDeleteController : BookingController
    {
        // Constructor to inject the booking repository
        public BookingDeleteController(IBookingRepository bookingRepository) : base(bookingRepository)
        {
        }

        [HttpDelete("/api/v1/bookings/{id}")]
        [Authorize] // Requires authentication to access this endpoint
        [SwaggerOperation(
            Summary = "Delete a booking",
            Description = "Deletes a specified booking record by its ID."
        )]
        public async Task<IActionResult> DeleteBooking(int id)
        {
            // Call the repository to delete the booking with the specified ID
            await _bookingRepository.Delete(id);
            return NoContent(); // Return a NoContent status to indicate successful deletion
        }
    }
}
