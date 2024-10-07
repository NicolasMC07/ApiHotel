using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ApiHotel.DTOs
{
    public class RoomTypeDto
    {
        [Required]
        [StringLength(50)]
        public string? Name { get; set; }

        [StringLength(255)]
        public string? Description { get; set; }
    }
}