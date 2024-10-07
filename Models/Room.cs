using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace ApiHotel.Models
{   
    [Table("rooms")]
    public class Room
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column("id")]
        public int Id { get; set; }

        [Required]
        [StringLength(10)]
        [Column("room_number")]
        public string RoomNumber { get; set; }

        [Required]
        [Column("room_type_id")]
        public int RoomTypeId { get; set; }

        [ForeignKey("RoomTypeId")]
        public RoomType? RoomType { get; set; }

        [Required]
        [Column("price_per_night")]
        public double PricePerNight { get; set; }

        [Required]
        [Column("availability")]
        public bool Availability { get; set; }

        [Required]
        [Column("max_occupancy_person")]
        public byte MaxOccupancyPersons { get; set; }

         public Room(string roomNumber, int roomTypeId, double pricePerNight, bool availability, byte maxOccupancyPersons)
        {
            RoomNumber = roomNumber.Trim();
            RoomTypeId = roomTypeId;
            PricePerNight = pricePerNight;
            Availability = availability;
            MaxOccupancyPersons = maxOccupancyPersons;
        }

        public Room()
        {
        }
    }
}