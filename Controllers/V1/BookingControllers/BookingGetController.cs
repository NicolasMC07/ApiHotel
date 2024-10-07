using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ApiHotel.Models;
using ApiHotel.Repositories;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace ApiHotel.Controllers.V1.BookingControllers
{
    [ApiController]
    [Route("api/v1/boooking_get")]
    [ApiExplorerSettings(GroupName = "v1")]
    public class BookingGetController : BookingController
    {
        public BookingGetController(IBookingRepository bookingRepository) : base(bookingRepository)
        {
        }

        [HttpGet("/api/v1/bookings/{id}")]
        [Authorize]
        public async Task<ActionResult<Booking>> GetById(int id)
        {
            var booking = await _bookingRepository.GetById(id);
            if (booking == null)
            {
                return NotFound();
            }
            return booking;
        }
    }
}