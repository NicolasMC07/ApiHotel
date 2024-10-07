using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ApiHotel.Repositories;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Swashbuckle.AspNetCore.Annotations;

namespace ApiHotel.Controllers.V1.GuestControllers
{
    [ApiController] // Indicates that this class is an API controller
    [Route("api/v1/guest_delete")] // Sets the route for guest deletion
    [ApiExplorerSettings(GroupName = "v1")] // Groups the API for versioning in Swagger
    public class GuestDeleteController : GuestController
    {
        // Constructor to inject the guest repository
        public GuestDeleteController(IGuestRepository guestRepository) : base(guestRepository)
        {
        }

        [HttpDelete("/api/v1/guests/{id}")] // Specifies the HTTP DELETE method for deleting a guest
        [Authorize] // Requires authentication to access this endpoint
        [SwaggerOperation(
            Summary = "Delete a guest",
            Description = "Deletes a guest record identified by the provided ID."
        )]
        public async Task<IActionResult> DeleteBooking(int id)
        {
            // Call the repository to delete the guest with the specified ID
            await _guestRepository.Delete(id);
            return NoContent(); // Return a NoContent status to indicate successful deletion
        }
    }
}
