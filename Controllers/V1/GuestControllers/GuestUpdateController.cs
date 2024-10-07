using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ApiHotel.DTOs;
using ApiHotel.Repositories;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Swashbuckle.AspNetCore.Annotations;

namespace ApiHotel.Controllers.V1.GuestControllers
{
    [ApiController] // Indicates that this class is an API controller
    [Route("api/v1/guest_update")] // Sets the route for guest update operations
    [ApiExplorerSettings(GroupName = "v1")] // Groups the API for versioning in Swagger
    public class GuestUpdateController : GuestController
    {
        // Constructor to inject the guest repository
        public GuestUpdateController(IGuestRepository guestRepository) : base(guestRepository)
        {
        }

        [HttpPut("/api/v1/guests/{id}")] // Specifies the HTTP PUT method for updating a guest by ID
        [Authorize] // Requires authentication to access this endpoint
        [SwaggerOperation(
            Summary = "Update guest information",
            Description = "Updates the details of an existing guest identified by the provided ID."
        )]
        public async Task<IActionResult> Update(int id, GuestDto guestDto)
        {
            // Validate the model state; return BadRequest if invalid
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            // Retrieve the existing guest by ID
            var existGuest = await _guestRepository.GetById(id);
            if (existGuest == null)
            {
                return NotFound(); // Return NotFound if the guest does not exist
            }

            // Update guest properties with the new data from guestDto
            existGuest.FirstName = guestDto.FirstName;
            existGuest.LastName = guestDto.LastName;
            existGuest.Email = guestDto.Email;
            existGuest.IdentificationNumber = guestDto.IdentificationNumber;
            existGuest.PhoneNumber = guestDto.PhoneNumber;
            existGuest.Birthdate = guestDto.Birthdate;

            // Call the repository to update the guest record
            await _guestRepository.Update(existGuest);

            return NoContent(); // Return NoContent to indicate successful update
        }
    }
}
