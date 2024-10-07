using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ApiHotel.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace ApiHotel.Controllers.V1.BookingControllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class BookingDeleteController : BookingController
    {
        public BookingDeleteController(IBookingRepository bookingRepository) : base(bookingRepository)
        {
        }

        [HttpDelete]
        public async Task<IActionResult> DeleteBooking(int id)
        {
            await _bookingRepository.Delete(id);
            return NoContent(); 
        }
    }
}