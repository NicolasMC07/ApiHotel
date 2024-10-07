using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ApiHotel.DTOs
{
    public class EmployeeDto
    {
        [Required]
        [StringLength(50)]
        public string? FirstName { get; set; }

        [Required]
        [StringLength(50)]
        public string? LastName { get; set; }

        [Required]
        [DataType(DataType.EmailAddress)]
        [EmailAddress]
        [StringLength(255)]
        public string? Email { get; set; }

        [Required]
        [StringLength(20)]
        public string? IdentificationNumber { get; set; }
    }
}