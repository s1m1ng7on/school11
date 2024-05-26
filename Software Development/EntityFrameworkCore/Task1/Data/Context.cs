using Microsoft.EntityFrameworkCore;
using Task1.Data.Entities;

namespace Task1.Data
{
    public class Context : DbContext
    {
        public DbSet<Employee> Employees { get; set; }
        public DbSet<Department> Departments { get; set; }
        public DbSet<Project> Projects { get; set; }
        public DbSet<EmployeesProjects> EmployeesProjects { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=GUNEVI-LAPTOP\\SQLEXPRESS;Initial Catalog=EFCore/Task1;Integrated Security=True;Encrypt=False");
        }

        public Context() { }
    }
}
