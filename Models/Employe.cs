using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace ApiHotel.Models
{   
    [Table("employe")]
    public class Employe
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

        [Required]
        [StringLength(255)]
        [Column("password")]
        public string? Password { get; set; }


        public Employe(string id, string firstName, string lastName,  string email, string identificationNumber, string password)
        {
            FirstName  = firstName.ToLower().Trim();
            LastName  = lastName.ToLower().Trim();
            Email  = email.Trim();
            IdentificationNumber  = identificationNumber.Trim();
            Password  = password.Trim();
        }

        public Employe()
        {
        }
    }
}