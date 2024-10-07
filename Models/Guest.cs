using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace ApiHotel.Models
{   
    [Table("guests")]
    public class Guest
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column("id")]
        public int Id { get; set; }

        [Column("first_name")]
        public string? FirstName { get; set; }

        [Column("last_name")]
        public string? LastName { get; set; }


        [Column("email")]
        public string? Email { get; set; }

        [Column("identification_number")]
        public string? IdentificationNumber { get; set; }

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