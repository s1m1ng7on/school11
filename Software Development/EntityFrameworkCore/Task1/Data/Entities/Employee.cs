using System.ComponentModel.DataAnnotations;

namespace Task1.Data.Entities
{
    public class Employee
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [StringLength(50)]
        public string Name { get; set; }

        [Required]
        public decimal Salary { get; set; }

        [Required]
        public int Age { get; set; }

        [Required]
        public int DepartmentId { get; set; }

        public Department Department { get; set; }
    }
}
