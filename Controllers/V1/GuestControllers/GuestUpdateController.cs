using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ApiHotel.DTOs;
using ApiHotel.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace ApiHotel.Controllers.V1.GuestControllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class GuestUpdateController : GuestController
    {
        public GuestUpdateController(IGuestRepository guestRepository) : base(guestRepository)
        {
        }

         [HttpPut("{id}")]
        public async Task<IActionResult> Update(int id, GuestDto guestDto)
        {   


            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }


            var existGuest = await _guestRepository.GetById(id);
            if (existGuest == null)
            {
                return NotFound();
            }

            existGuest.FirstName = guestDto.FirstName;
            existGuest.LastName = guestDto.LastName;
            existGuest.Email = guestDto.Email;
            existGuest.IdentificationNumber = guestDto.IdentificationNumber;
            existGuest.PhoneNumber = guestDto.PhoneNumber;
            existGuest.Birthdate = guestDto.Birthdate;


            await _guestRepository.Update(existGuest);

            return NoContent();
        }
    }
}