using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2.Data.Entities
{
    public class Client
    {
        [Key]
        public string Id { get; set; }

        [Required]
        public string FirstName { get; set; }

        [Required]
        public string LastName { get; set; }

        [Required]
        public string Email { get; set; }

        public Client(string fullName, string email)
        {
            string[] fullNameArr = fullName.Split(' ');

            Id = Guid.NewGuid().ToString();
            FirstName = fullNameArr[0];
            LastName = fullNameArr[1];
            Email = email;
        }
    }
}
