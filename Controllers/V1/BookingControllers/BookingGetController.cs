using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ApiHotel.Models;
using ApiHotel.Repositories;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Swashbuckle.AspNetCore.Annotations;

namespace ApiHotel.Controllers.V1.BookingControllers
{
    [ApiController]
    [Route("api/v1/boooking_get")]
    [ApiExplorerSettings(GroupName = "v1")]
    public class BookingGetController : BookingController
    {
        // Constructor to inject the booking repository
        public BookingGetController(IBookingRepository bookingRepository) : base(bookingRepository)
        {
        }

        [HttpGet("/api/v1/bookings/{id}")]
        [Authorize] // Requires authentication to access this endpoint
        [SwaggerOperation(
            Summary = "Get booking by ID",
            Description = "Retrieves a booking record based on the provided booking ID."
        )]
        public async Task<ActionResult<Booking>> GetById(int id)
        {
            // Call the repository to get the booking by the specified ID
            var booking = await _bookingRepository.GetById(id);
            if (booking == null)
            {
                return NotFound(); // Return NotFound if the booking does not exist
            }
            return booking; // Return the booking record
        }
    }
}
