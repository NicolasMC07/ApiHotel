using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ApiHotel.DTOs
{
    public class BookingDto
    {
        [Required]
        public int RoomId { get; set; }

        [Required]
        public int GuestId { get; set; }

        [Required]
        public int EmployeeId { get; set; }

        [Required]
        public DateTime StartDate { get; set; }

        public DateTime EndDate { get; set; }

        [Required]
        public double TotalCost { get; set; }
    }
}