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
    [Route("api/v1/booking_filter")]
    [ApiExplorerSettings(GroupName = "v1")]
    public class BookingFilterController : BookingController
    {
        // Constructor to inject the booking repository
        public BookingFilterController(IBookingRepository bookingRepository) : base(bookingRepository)
        {
        }

        [HttpGet("/api/v1/bookings/search/{identification_number}")]
        [Authorize] // Requires authentication to access this endpoint
        [SwaggerOperation(
            Summary = "Find bookings by identification number",
            Description = "Retrieves a list of bookings associated with the provided identification number."
        )]
        public async Task<ActionResult<IEnumerable<Booking>>> FindByIdentification(string identificationNumber)
        {
            // Call the repository to find bookings by the given identification number
            var bookings = await _bookingRepository.FindByIdentification(identificationNumber);
            return Ok(bookings); // Return the list of bookings as a response
        }
    }
}
