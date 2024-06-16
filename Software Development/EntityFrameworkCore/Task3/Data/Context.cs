using Microsoft.EntityFrameworkCore;
using Task3.Data.Entities;

namespace Task3.Data
{
    public class Task3Context : DbContext
    {
        public DbSet<Employee> Employees { get; set; }
        public DbSet<Department> Departments { get; set; }
        public DbSet<Project> Projects { get; set; }
        public DbSet<EmployeeProject> EmployeesProjects { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=GUNEVI-LAPTOP\\SQLEXPRESS;Initial Catalog=EFCore/Task3;Integrated Security=True;Encrypt=False");
        }

        public Task3Context() { }
    }
}