using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EFCore_Task3.Data.Entities
{
    public class EmployeeProject
    {
        [Key] public int Id { get; set; }
        [ForeignKey(nameof(Employee))] public int EmployeeId { get; set; }
        [ForeignKey(nameof(Project))] public int ProjectId { get; set; }

        public Employee Employee { get; set; }
        public Project Project { get; set; }
    }
}
