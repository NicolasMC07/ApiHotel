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
        //properties
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column("id")]
        public int Id { get; set; }

        [Column("name")]
        public required string Name { get; set; }

        [Column("description")]
        public string? Description { get; set; }

        //constructor
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