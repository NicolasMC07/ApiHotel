using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ApiHotel.Models;
using ApiHotel.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace ApiHotel.Controllers.V1.RoomControllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class RoomGetController : RoomController
    {
        public RoomGetController(IRoomRepository roomRepository) : base(roomRepository)
        {
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Room>> GetById(int id)
        {
            var room = await _roomRepository.GetById(id);
            if (room == null)
            {
                return NotFound();
            }
            return room;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<Room>>> GetAll()
        {
            var rooms = await _roomRepository.GetAll();
            return Ok(rooms);
        }

        [HttpGet("status")]
        public async Task<ActionResult<object>> GetRoomStatus()
        {

            var status = await _roomRepository.GetRoomStatus();
            if (status == null)
            {
                return NotFound("No hay habitaciones");
            }
            return Ok(status);
        }

        [HttpGet("available")]
        public async Task<ActionResult<IEnumerable<Room>>> GetAvailable()
        {
            var rooms = await _roomRepository.GetAvailable();
            return Ok(rooms);
        }

        [HttpGet("occupied")]
        public async Task<ActionResult<IEnumerable<Room>>> GetOccupied()
        {
            var rooms = await _roomRepository.GetOccupied();
            return Ok(rooms);
        }

    }
}