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
        // properties
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column("id")]
        public int Id { get; set; }

        [Column("room_number")]
        public string RoomNumber { get; set; }

        [Column("room_type_id")]
        public int RoomTypeId { get; set; }

        [ForeignKey("RoomTypeId")]
        public RoomType? RoomType { get; set; }

        [Column("price_per_night")]
        public double PricePerNight { get; set; }

        [Column("availability")]
        public bool Availability { get; set; }

        [Column("max_occupancy_person")]
        public byte MaxOccupancyPersons { get; set; }

        // contructor
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