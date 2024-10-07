using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ApiHotel.Models;
using ApiHotel.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace ApiHotel.Controllers.V1.RoomTypeControllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class RoomTypeGetController : RoomTypeController
    {
        public RoomTypeGetController(IRoomTypeRepository roomTypeRepository) : base(roomTypeRepository)
        {
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<RoomType>> GetById(int id)
        {
            var roomType = await _roomTypeRepository.GetById(id);
            if (roomType == null)
            {
                return NotFound();
            }
            return roomType;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<RoomType>>> GetAll()
        {
            var roomTypes = await _roomTypeRepository.GetAll();
            return Ok(roomTypes);
        }
    }
}