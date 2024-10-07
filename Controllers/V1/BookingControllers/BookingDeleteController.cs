using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ApiHotel.Repositories;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace ApiHotel.Controllers.V1.BookingControllers
{
    [ApiController]
    [Route("api/v1/booking_delete")]
    [ApiExplorerSettings(GroupName = "v1")]
    public class BookingDeleteController : BookingController
    {
        public BookingDeleteController(IBookingRepository bookingRepository) : base(bookingRepository)
        {
        }

        [HttpDelete("/api/v1/bookings/{id}")]
        [Authorize]
        public async Task<IActionResult> DeleteBooking(int id)
        {
            await _bookingRepository.Delete(id);
            return NoContent(); 
        }
    }
}