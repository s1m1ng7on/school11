using System.ComponentModel.DataAnnotations;

namespace Task3.Data.Entities
{
    public class Department
    {
        [Key] public int Id { get; set; }
        public string Name { get; set; }

        public List<Employee> Employees { get; set; }
    }
}
