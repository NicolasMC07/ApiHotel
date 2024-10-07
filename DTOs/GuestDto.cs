using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ApiHotel.DTOs
{
    public class GuestDto
    {
        [Required]
        [StringLength(255)]
        public string? FirstName { get; set; }

        [Required]
        [StringLength(255)]
        public string? LastName { get; set; }

        [Required]
        [DataType(DataType.EmailAddress)] 
        [EmailAddress]
        [StringLength(255)]
        public string? Email { get; set; }

        [Required]
        [StringLength(20)]
        public string? IdentificationNumber { get; set; }

        [Required]
        [Phone]
        [StringLength(20)]
        public string? PhoneNumber { get; set; }

        [DataType(DataType.Date)]
        public DateTime Birthdate { get; set; }
    }
}