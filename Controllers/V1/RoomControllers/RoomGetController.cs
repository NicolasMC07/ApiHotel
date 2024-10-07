using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ApiHotel.Models;
using ApiHotel.Repositories;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace ApiHotel.Controllers.V1.RoomControllers
{
    [ApiController]
    [Route("api/v1/rooms_get")]
    [ApiExplorerSettings(GroupName = "v1")]
    public class RoomGetController : RoomController
    {
        public RoomGetController(IRoomRepository roomRepository) : base(roomRepository)
        {
        }

        [HttpGet("/api/v1/rooms/{id}")]
        [Authorize]
        public async Task<ActionResult<Room>> GetById(int id)
        {
            var room = await _roomRepository.GetById(id);
            if (room == null)
            {
                return NotFound();
            }
            return room;
        }

        [HttpGet("/api/v1/rooms")]
        [Authorize]
        public async Task<ActionResult<IEnumerable<Room>>> GetAll()
        {
            var rooms = await _roomRepository.GetAll();
            return Ok(rooms);
        }

        [HttpGet("/api/v1/rooms/status")]
        public async Task<ActionResult<object>> GetRoomStatus()
        {

            var status = await _roomRepository.GetRoomStatus();
            if (status == null)
            {
                return NotFound("No hay habitaciones");
            }
            return Ok(status);
        }

        [HttpGet("/api/v1/rooms/available")]
        public async Task<ActionResult<IEnumerable<Room>>> GetAvailable()
        {
            var rooms = await _roomRepository.GetAvailable();
            return Ok(rooms);
        }

        [HttpGet("/api/v1/rooms/occupied")]
        [Authorize]
        public async Task<ActionResult<IEnumerable<Room>>> GetOccupied()
        {
            var rooms = await _roomRepository.GetOccupied();
            return Ok(rooms);
        }

    }
}