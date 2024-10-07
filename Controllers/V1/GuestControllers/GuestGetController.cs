using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ApiHotel.Models;
using ApiHotel.Repositories;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace ApiHotel.Controllers.V1.GuestControllers
{
    [ApiController]
    [Route("api/v1/guest_get")]
    [ApiExplorerSettings(GroupName = "v1")]
    public class GuestGetController : GuestController
    {
        public GuestGetController(IGuestRepository guestRepository) : base(guestRepository)
        {
        }

        [HttpGet("/api/v1/guests/{id}")]
        [Authorize]
        public async Task<ActionResult<Guest>> GetById(int id)
        {
            var guest = await _guestRepository.GetById(id);
            if (guest == null)
            {
                return NotFound();
            }
            return guest;
        }

        [HttpGet("/api/v1/guests")]
        [Authorize]
        public async Task<ActionResult<IEnumerable<Guest>>> GetAll()
        {
            var guests = await _guestRepository.GetAll();
            return Ok(guests);
        }

        [HttpGet("/api/v1/guests/search/{keyword}")]
        [Authorize]
        public async Task<ActionResult<IEnumerable<Guest>>> SearchByKeyword(string keyword)
        {
            var guests = await _guestRepository.GetByKeyword(keyword);
            return Ok(guests);
        }
    }
}