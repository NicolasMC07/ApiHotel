using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ApiHotel.DTOs;
using ApiHotel.Models;
using ApiHotel.Repositories;
using Microsoft.AspNetCore.Mvc;
using Swashbuckle.AspNetCore.Annotations;

namespace ApiHotel.Controllers.V1.GuestControllers
{
    [ApiController] // Indicates that this class is an API controller
    [Route("api/v1/guest_create")] // Sets the route for guest creation
    [ApiExplorerSettings(GroupName = "v1")] // Groups the API for versioning in Swagger
    public class GuestCreateController : GuestController
    {
        // Constructor to inject the guest repository
        public GuestCreateController(IGuestRepository guestRepository) : base(guestRepository)
        {            
        }

        [HttpPost("/api/v1/guest")] // Specifies the HTTP POST method for creating a guest
        [SwaggerOperation(
            Summary = "Create a new guest",
            Description = "Registers a new guest with the provided details."
        )]
        public async Task<IActionResult> CreateBooking(GuestDto guestDto)
        {
            // Validate the model state; return BadRequest if invalid
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            // Create a new guest object from the provided GuestDto
            var newGuest = new Guest(
                guestDto.FirstName,
                guestDto.LastName,
                guestDto.Email,
                guestDto.IdentificationNumber,
                guestDto.PhoneNumber,
                guestDto.Birthdate
            );

            // Call the repository to register the new guest
            await _guestRepository.Register(newGuest);

            // Return the created guest object as a response
            return Ok(newGuest);
        }
    }
}
