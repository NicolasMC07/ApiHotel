using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace ApiHotel.Models
{   
    [Table("bokings")]
    public class Booking
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column("id")]
        public int Id { get; set; }

        [Required]
        [Column("room_id")]
        public int RoomId { get; set; }

        [ForeignKey("RoomId")]
        public Room? Room { get; set; }

        [Required]
        [Column("guest_id")]
        public int GuestId { get; set; }

        [ForeignKey("GuestId")]
        public Guest? Guest { get; set; }

        [Required]
        [Column("employee_id")]
        public int EmployeeId { get; set; }

        [ForeignKey("EmployeeId")]
        public Employe? Employee { get; set; }

        [Required]
        [Column("start_date")]
        public DateTime StartDate { get; set; }

        
        [Column("end_date")]
        public DateTime? EndDate { get; set; }

        [Required]
        [Column("total_cost")]
        public double TotalCost { get; set; }


        public Booking(int roomId, int guestId, int employeeId, DateTime startDate,  DateTime endDate, double totalCost)
        {
            RoomId = roomId;
            GuestId = guestId;
            EmployeeId = employeeId;
            StartDate = startDate;
            EndDate  = endDate;
            TotalCost = totalCost;
        }

        public Booking()
        {
        }
    }
}