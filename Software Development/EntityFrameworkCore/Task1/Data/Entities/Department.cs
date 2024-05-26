using System.ComponentModel.DataAnnotations;

namespace Task1.Data.Entities
{
    public class Department
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [StringLength(50)]
        public string Name { get; set; }

        [Required]
        [StringLength(200)]
        public string Description { get; set; }

        public List<Employee> Employees { get; set; }
    }
}
