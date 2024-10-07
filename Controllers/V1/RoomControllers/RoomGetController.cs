using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ApiHotel.Models;
using ApiHotel.Repositories;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Swashbuckle.AspNetCore.Annotations;

namespace ApiHotel.Controllers.V1.RoomControllers
{
    [ApiController] // Indicates that this class is an API controller
    [Route("api/v1/rooms_get")] // Sets the route for room retrieval operations
    [ApiExplorerSettings(GroupName = "v1")] // Groups the API for versioning in Swagger
    public class RoomGetController : RoomController
    {
        // Constructor to inject the room repository
        public RoomGetController(IRoomRepository roomRepository) : base(roomRepository)
        {
        }

        [HttpGet("/api/v1/rooms/{id}")] // Specifies the HTTP GET method for retrieving a room by ID
        [Authorize] // Requires authentication to access this endpoint
        [SwaggerOperation(
            Summary = "Get room by ID",
            Description = "Retrieves a room record based on the provided room ID."
        )]
        public async Task<ActionResult<Room>> GetById(int id)
        {
            // Call the repository to get the room by the specified ID
            var room = await _roomRepository.GetById(id);
            if (room == null)
            {
                return NotFound(); // Return NotFound if the room does not exist
            }
            return room; // Return the room record
        }

        [HttpGet("/api/v1/rooms")] // Specifies the HTTP GET method for retrieving all rooms
        [Authorize] // Requires authentication to access this endpoint
        [SwaggerOperation(
            Summary = "Get all rooms",
            Description = "Retrieves a list of all available rooms."
        )]
        public async Task<ActionResult<IEnumerable<Room>>> GetAll()
        {
            // Call the repository to get all rooms
            var rooms = await _roomRepository.GetAll();
            return Ok(rooms); // Return the list of rooms as a response
        }

        [HttpGet("/api/v1/rooms/status")] // Specifies the HTTP GET method for retrieving room status
        [SwaggerOperation(
            Summary = "Get room status",
            Description = "Retrieves the current status of all rooms."
        )]
        public async Task<ActionResult<object>> GetRoomStatus()
        {
            // Call the repository to get room status
            var status = await _roomRepository.GetRoomStatus();
            if (status == null)
            {
                return NotFound("No hay habitaciones"); // Return NotFound if no rooms are available
            }
            return Ok(status); // Return the status of the rooms
        }

        [HttpGet("/api/v1/rooms/available")] // Specifies the HTTP GET method for retrieving available rooms
        [SwaggerOperation(
            Summary = "Get available rooms",
            Description = "Retrieves a list of all currently available rooms."
        )]
        public async Task<ActionResult<IEnumerable<Room>>> GetAvailable()
        {
            // Call the repository to get available rooms
            var rooms = await _roomRepository.GetAvailable();
            return Ok(rooms); // Return the list of available rooms
        }

        [HttpGet("/api/v1/rooms/occupied")] // Specifies the HTTP GET method for retrieving occupied rooms
        [Authorize] // Requires authentication to access this endpoint
        [SwaggerOperation(
            Summary = "Get occupied rooms",
            Description = "Retrieves a list of all currently occupied rooms."
        )]
        public async Task<ActionResult<IEnumerable<Room>>> GetOccupied()
        {
            // Call the repository to get occupied rooms
            var rooms = await _roomRepository.GetOccupied();
            return Ok(rooms); // Return the list of occupied rooms
        }
    }
}
