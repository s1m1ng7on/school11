using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Task2.Data.Entities
{
    public class RoomBooking
    {
        [Key]
        public string Id { get; set; }

        [Required]
        [ForeignKey(nameof(Room))]
        public string RoomId { get; set; }
        public Room Room { get; set; }

        [Required]
        [ForeignKey(nameof(Booking))]
        public string BookingId { get; set; }
        public Booking Booking { get; set; }
    }
}
