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
    [Route("api/v1/booking_filter")]
    [ApiExplorerSettings(GroupName = "v1")]
    public class BookingFilterController : BookingController
    {
        public BookingFilterController(IBookingRepository bookingRepository) : base(bookingRepository)
        {
        }

        [HttpGet("/api/v1/bookings/search/{identification_number}")]
        [Authorize]
        public async Task<ActionResult<IEnumerable<Booking>>> FindByIdentification(string identificationNumber)
        {
            var bookings = await _bookingRepository.FindByIdentification(identificationNumber);
            return Ok(bookings);
        }
    }
}