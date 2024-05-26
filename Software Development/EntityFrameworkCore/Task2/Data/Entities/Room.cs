using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2.Data.Entities
{
    public class Room
    {
        [Key]
        public string Id { get; set; }

        [Required]
        public string Number { get; set; }

        [Required]
        public int RoomTypeId { get; set; }

        public RoomType RoomType { get; set; }

        public Room(string number, RoomType roomType)
        {
            Id = Guid.NewGuid().ToString();
            Number = number;
            RoomTypeId = roomType.Id;
        }
    }
}
