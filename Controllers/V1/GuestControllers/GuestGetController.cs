using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ApiHotel.Models;
using ApiHotel.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace ApiHotel.Controllers.V1.GuestControllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class GuestGetController : GuestController
    {
        public GuestGetController(IGuestRepository guestRepository) : base(guestRepository)
        {
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Guest>> GetById(int id)
        {
            var guest = await _guestRepository.GetById(id);
            if (guest == null)
            {
                return NotFound();
            }
            return guest;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<Guest>>> GetAll()
        {
            var guests = await _guestRepository.GetAll();
            return Ok(guests);
        }

        [HttpGet("search/{keyword}")]
        public async Task<ActionResult<IEnumerable<Guest>>> SearchByKeyword(string keyword)
        {
            var guests = await _guestRepository.GetByKeyword(keyword);
            return Ok(guests);
        }
    }
}