using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ApiHotel.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace ApiHotel.Controllers.V1.BookingControllers
{
    [ApiController]
    [Route("api/[controller]")]
    [ApiExplorerSettings(GroupName = "v1")]

    // main BookingController
    public class BookingController : ControllerBase
    {
        protected readonly IBookingRepository _bookingRepository;

        public BookingController(IBookingRepository bookingRepository)
        {
            _bookingRepository = bookingRepository;
        }
    }
}