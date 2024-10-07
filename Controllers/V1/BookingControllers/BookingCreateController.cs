using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ApiHotel.DTOs;
using ApiHotel.Models;
using ApiHotel.Repositories;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Swashbuckle.AspNetCore.Annotations;

namespace ApiHotel.Controllers.V1.BookingControllers
{
    [ApiController]
    [Route("api/v1/booking_create")]
    [ApiExplorerSettings(GroupName = "v1")]
    public class BookingCreateController : BookingController
    {
        // Constructor to inject the booking repository
        public BookingCreateController(IBookingRepository bookingRepository) : base(bookingRepository)
        {
        }

        [HttpPost("/api/v1/bookings")]
        [Authorize] // Requires authentication to access this endpoint
        [SwaggerOperation(
            Summary = "Create a new booking",
            Description = "Creates a new booking record for a specified room and guest, ensuring all provided data is valid."
        )]
        public async Task<IActionResult> CreateBooking(BookingDto bookingDto)
        {
            // Validate the model state; return BadRequest if invalid
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            // Create a new booking object from the provided BookingDto
            var newBooking = new Booking(
                bookingDto.RoomId,
                bookingDto.GuestId,
                bookingDto.EmployeeId,
                bookingDto.StartDate,
                bookingDto.EndDate,
                bookingDto.TotalCost
            );

            // Call the repository to save the new booking
            await _bookingRepository.Create(newBooking);

            // Return the created booking object as a response
            return Ok(newBooking);
        }
    }
}
