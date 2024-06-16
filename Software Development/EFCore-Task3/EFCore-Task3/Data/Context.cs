using EFCore_Task3.Data.Entities;
using Microsoft.EntityFrameworkCore;

namespace EFCore_Task3.Data
{
    public class Context : DbContext
    {
        public DbSet<Employee> Employees { get; set; }
        public DbSet<Department> Departments { get; set; }
        public DbSet<Project> Projects { get; set; }
        public DbSet<EmployeeProject> EmployeesProjects { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=GUNEVI-LAPTOP\\SQLEXPRESS;Initial Catalog=EFCore/Task3;Integrated Security=True;Encrypt=False");
        }

        public Context() { }
    }
}