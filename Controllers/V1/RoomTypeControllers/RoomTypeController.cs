using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ApiHotel.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace ApiHotel.Controllers.V1.RoomTypeControllers
{
    [ApiController]
    [Route("api/[controller]")]
    // Main RoomTypeController
    public class RoomTypeController : ControllerBase
    {
        protected readonly IRoomTypeRepository _roomTypeRepository;

        public RoomTypeController(IRoomTypeRepository roomTypeRepository)
        {
            _roomTypeRepository = roomTypeRepository;
        }
    }
}