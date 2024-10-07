using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ApiHotel.DTOs;
using ApiHotel.Models;
using ApiHotel.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace ApiHotel.Controllers.V1.GuestControllers
{
    [ApiController]
    [Route("api/v1/guest_create")]
    [ApiExplorerSettings(GroupName = "v1")]
    public class GuestCreateController : GuestController
    {
        public GuestCreateController(IGuestRepository guestRepository) : base(guestRepository)
        {            
        }

        [HttpPost("/api/v1/guest")]
        public async Task<IActionResult> CreateBooking(GuestDto guestDto)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var newGuest = new Guest(guestDto.FirstName, guestDto.LastName, guestDto.Email, guestDto.IdentificationNumber, guestDto.PhoneNumber, guestDto.Birthdate);

            await _guestRepository.Register(newGuest);

            return Ok(newGuest);
        }
    }
}