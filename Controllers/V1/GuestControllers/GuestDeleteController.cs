using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ApiHotel.Repositories;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace ApiHotel.Controllers.V1.GuestControllers
{
    [ApiController]
    [Route("api/v1/guest_delete")]
    [ApiExplorerSettings(GroupName = "v1")]
    public class GuestDeleteController : GuestController
    {
        public GuestDeleteController(IGuestRepository guestRepository) : base(guestRepository)
        {
        }
        [HttpDelete("/api/v1/guests/{id}")]
        [Authorize]
        public async Task<IActionResult> DeleteBooking(int id)
        {
            await _guestRepository.Delete(id);
            return NoContent(); 
        }
    }
}