using System.ComponentModel.DataAnnotations;

namespace Task1.Data.Entities
{
    public class EmployeesProjects
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public int EmployeeId { get; set; }

        [Required]
        public int ProjectId { get; set; }

        public List<Employee> Employees { get; set; }
        public List<Project> Projects { get; set; }
    }
}
