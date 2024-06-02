using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2.Data.Entities
{
    public class ClientBooking
    {
        [Key]
        public string Id { get; set; }

        [Required]
        [ForeignKey(nameof(Client))]
        public string ClientId { get; set; }
        public Client Client { get; set; }
        
        [Required]
        [ForeignKey(nameof(Booking))]
        public string BookingId { get; set; }
        public Booking Booking { get; set; }
    }
}
