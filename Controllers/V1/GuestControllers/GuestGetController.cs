using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ApiHotel.Models;
using ApiHotel.Repositories;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Swashbuckle.AspNetCore.Annotations;

namespace ApiHotel.Controllers.V1.GuestControllers
{
    [ApiController] // Indicates that this class is an API controller
    [Route("api/v1/guest_get")] // Sets the route for guest retrieval operations
    [ApiExplorerSettings(GroupName = "v1")] // Groups the API for versioning in Swagger
    public class GuestGetController : GuestController
    {
        // Constructor to inject the guest repository
        public GuestGetController(IGuestRepository guestRepository) : base(guestRepository)
        {
        }

        [HttpGet("/api/v1/guests/{id}")] // Specifies the HTTP GET method for retrieving a guest by ID
        [Authorize] // Requires authentication to access this endpoint
        [SwaggerOperation(
            Summary = "Get guest by ID",
            Description = "Retrieves a guest record based on the provided guest ID."
        )]
        public async Task<ActionResult<Guest>> GetById(int id)
        {
            // Call the repository to get the guest by the specified ID
            var guest = await _guestRepository.GetById(id);
            if (guest == null)
            {
                return NotFound(); // Return NotFound if the guest does not exist
            }
            return guest; // Return the guest record
        }

        [HttpGet("/api/v1/guests")] // Specifies the HTTP GET method for retrieving all guests
        [Authorize] // Requires authentication to access this endpoint
        [SwaggerOperation(
            Summary = "Get all guests",
            Description = "Retrieves a list of all registered guests."
        )]
        public async Task<ActionResult<IEnumerable<Guest>>> GetAll()
        {
            // Call the repository to get all guests
            var guests = await _guestRepository.GetAll();
            return Ok(guests); // Return the list of guests as a response
        }

        [HttpGet("/api/v1/guests/search/{keyword}")] // Specifies the HTTP GET method for searching guests by keyword
        [Authorize] // Requires authentication to access this endpoint
        [SwaggerOperation(
            Summary = "Search guests by keyword",
            Description = "Retrieves a list of guests matching the provided search keyword."
        )]
        public async Task<ActionResult<IEnumerable<Guest>>> SearchByKeyword(string keyword)
        {
            // Call the repository to find guests by the specified keyword
            var guests = await _guestRepository.GetByKeyword(keyword);
            return Ok(guests); // Return the list of matching guests
        }
    }
}
