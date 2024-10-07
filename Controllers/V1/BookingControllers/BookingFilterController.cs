using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ApiHotel.Models;
using ApiHotel.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace ApiHotel.Controllers.V1.BookingControllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class BookingFilterController : BookingController
    {
        public BookingFilterController(IBookingRepository bookingRepository) : base(bookingRepository)
        {
        }

        [HttpGet("search/")]
        public async Task<ActionResult<IEnumerable<Booking>>> FindByIdentification(string identificationNumber)
        {
            var bookings = await _bookingRepository.FindByIdentification(identificationNumber);
            return Ok(bookings);
        }
    }
}