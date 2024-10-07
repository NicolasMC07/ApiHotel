using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ApiHotel.DTOs;
using ApiHotel.Models;
using ApiHotel.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace ApiHotel.Controllers.V1.BookingControllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class BookingCreateController : BookingController
    {
        public BookingCreateController(IBookingRepository bookingRepository) : base(bookingRepository)
        {
        }

        [HttpPost]
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