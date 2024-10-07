using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ApiHotel.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace ApiHotel.Controllers.V1.GuestControllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class GuestDeleteController : GuestController
    {
        public GuestDeleteController(IGuestRepository guestRepository) : base(guestRepository)
        {
        }
        [HttpDelete]
        public async Task<IActionResult> DeleteBooking(int id)
        {
            await _guestRepository.Delete(id);
            return NoContent(); 
        }
    }
}