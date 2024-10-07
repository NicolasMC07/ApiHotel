using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace ApiHotel.Models
{   
    [Table("guest")]
    public class Guest
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column("id")]
        public int Id { get; set; }

        [Required]
        [StringLength(255)]
        [Column("first_name")]
        public string? FirstName { get; set; }

        [Required]
        [StringLength(255)]
        [Column("last_name")]
        public string? LastName { get; set; }

        [Required]
        [DataType(DataType.EmailAddress)] 
        [EmailAddress]
        [StringLength(255)]
        [Column("email")]
        public string? Email { get; set; }

        [Required]
        [StringLength(20)]
        [Column("identification_number")]
        public string? IdentificationNumber { get; set; }

        [Required]
        [Phone]
        [StringLength(20)]
        [Column("phone_number")]
        public required string PhoneNumber { get; set; }

        
        [DataType(DataType.Date)]
        [Column("birthdate")]
        public DateTime? Birthdate { get; set; }

        public Guest(string firstName, string lastName, string  email, string identificationNumber, string phoneNumber, DateTime birthdate)
        {
            FirstName  = firstName.ToLower().Trim();
            LastName  = lastName.ToLower().Trim();
            Email  = email.ToLower().Trim();
            IdentificationNumber = identificationNumber.Trim();
            PhoneNumber = phoneNumber.Trim();
            Birthdate = birthdate;
        }

        public Guest()
        {
        }
    }
}