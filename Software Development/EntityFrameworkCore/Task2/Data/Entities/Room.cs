using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
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
        [ForeignKey(nameof(RoomType))]
        public string RoomTypeId { get; set; }
        public RoomType RoomType { get; set; }
    }
}
