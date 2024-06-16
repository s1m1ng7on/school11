using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EFCore_Task3.Data.Entities
{
    public class Employee
    {
        [Key] public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public decimal Salary { get; set; }
        public DateTime HireDate { get; set; }
        [ForeignKey(nameof(Department))] public int DepartmentId { get; set; }

        public Department Department { get; set; }

        public List<EmployeeProject> EmployeeProjects { get; set; }
    }
}
