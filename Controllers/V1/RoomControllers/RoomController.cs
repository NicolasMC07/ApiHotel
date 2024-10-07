using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ApiHotel.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace ApiHotel.Controllers.V1.RoomControllers
{
    [ApiController]
    [Route("api/[controller]")]
    // Main RoomController
    public class RoomController : ControllerBase
    {
        protected readonly IRoomRepository _roomRepository;

        public RoomController(IRoomRepository roomRepository)
        {
            _roomRepository = roomRepository;
        }
    }
}