using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ApiHotel.DTOs
{
    public class RoomDto
    {
        [Required]
        [StringLength(10)]
        public string? RoomNumber { get; set; }

        [Required]
        public int RoomTypeId { get; set; }

        [Required]
        public double PricePerNight { get; set; }

        [Required]
        public bool Availability { get; set; }

        [Required]
        public byte MaxOccupancyPersons { get; set; }
    }
}