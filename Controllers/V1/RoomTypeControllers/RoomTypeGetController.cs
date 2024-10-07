using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ApiHotel.Models;
using ApiHotel.Repositories;
using Microsoft.AspNetCore.Mvc;
using Swashbuckle.AspNetCore.Annotations;

namespace ApiHotel.Controllers.V1.RoomTypeControllers
{
    [ApiController] // Indicates that this class is an API controller
    [Route("api/v1/room_type_get")] // Sets the route for room type retrieval operations
    [ApiExplorerSettings(GroupName = "v1")] // Groups the API for versioning in Swagger
    public class RoomTypeGetController : RoomTypeController
    {
        // Constructor to inject the room type repository
        public RoomTypeGetController(IRoomTypeRepository roomTypeRepository) : base(roomTypeRepository)
        {
        }

        [HttpGet("/api/v1/room_types/{id}")] // Specifies the HTTP GET method for retrieving a room type by ID
        [SwaggerOperation(
            Summary = "Get room type by ID",
            Description = "Retrieves a room type record based on the provided room type ID."
        )]
        public async Task<ActionResult<RoomType>> GetById(int id)
        {
            // Call the repository to get the room type by the specified ID
            var roomType = await _roomTypeRepository.GetById(id);
            if (roomType == null)
            {
                return NotFound(); // Return NotFound if the room type does not exist
            }
            return roomType; // Return the room type record
        }

        [HttpGet("/api/v1/room_types")] // Specifies the HTTP GET method for retrieving all room types
        [SwaggerOperation(
            Summary = "Get all room types",
            Description = "Retrieves a list of all available room types."
        )]
        public async Task<ActionResult<IEnumerable<RoomType>>> GetAll()
        {
            // Call the repository to get all room types
            var roomTypes = await _roomTypeRepository.GetAll();
            return Ok(roomTypes); // Return the list of room types as a response
        }
    }
}
