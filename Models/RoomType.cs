using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace ApiHotel.Models
{   
    [Table("room_types")]
    public class RoomType
    {

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column("id")]
        public int Id { get; set; }

        [Required]
        [StringLength(50)]
        [Column("name")]
        public required string Name { get; set; }

        [StringLength(255)]
        [Column("description")]
        public string? Description { get; set; }
        public RoomType(string name, string description)
        {
            Name = name.ToLower().Trim();
            Description = description.Trim();
        }

        public RoomType()
        {
        }
    }
}