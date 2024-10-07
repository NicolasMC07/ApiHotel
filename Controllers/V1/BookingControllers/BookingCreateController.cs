using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ApiHotel.DTOs;
using ApiHotel.Models;
using ApiHotel.Repositories;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace ApiHotel.Controllers.V1.BookingControllers
{
    [ApiController]
    [Route("api/v1/booking_create")]
    [ApiExplorerSettings(GroupName = "v1")]
    public class BookingCreateController : BookingController
    {
        public BookingCreateController(IBookingRepository bookingRepository) : base(bookingRepository)
        {
        }

        [HttpPost("/api/v1/bookings")]
        [Authorize]
        public async Task<IActionResult> CreateBooking(BookingDto bookingDto)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var newBooking = new Booking(bookingDto.RoomId, bookingDto.GuestId, bookingDto.EmployeeId, bookingDto.StartDate, bookingDto.EndDate, bookingDto.TotalCost);

            await _bookingRepository.Create(newBooking);

            return Ok(newBooking);
        }
    }
}