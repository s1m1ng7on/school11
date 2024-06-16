using EFCore_Task3.Data;
using EFCore_Task3.Data.Entities;

namespace EFCore_Task3
{
    public class Controller
    {
        private readonly Context context = new Context();

        public List<string> GetDepartmentNames()
        {
            return context.Departments
                .Select(d => d.Name)
                .ToList();
        }

        public List<string> GetEmployeeNames()
        {
            return context.Employees
                .Select(e => $"{e.FirstName} {e.LastName}")
                .ToList();
        }

        public List<Employee> GetEmployeesBySalary(decimal salary)
        {
            return context.Employees
                .Where(e => e.Salary == salary)
                .ToList();
        }

        public List<string> GetEmployeesByProject(int projectId)
        {
            return context.EmployeesProjects
                .Where(ep => ep.ProjectId == projectId)
                .Select(ep => $"{ep.Employee.FirstName} {ep.Employee.LastName}")
                .ToList();
        }

        public decimal GetAverageSalary(int departmentId)
        {
            return context.Employees
                .Where(e => e.DepartmentId == departmentId)
                .Select(e => e.Salary)
                .Average();
        }

        public void AddEmployeeToDepartment(string firstName, string lastName, decimal salary, int departmentId)
        {
            Employee newEmployee = new Employee()
            {
                FirstName = firstName,
                LastName = lastName,
                Salary = salary,
                HireDate = DateTime.Now,
                DepartmentId = departmentId
            };

            context.Employees.Add(newEmployee);
            context.SaveChanges();
        }

        public void UpdateEmployeeSalary(int employeeId, decimal newSalary)
        {
            Employee selectedEmployee = context.Employees.FirstOrDefault(e => e.Id == employeeId);

            if (selectedEmployee != null)
                selectedEmployee.Salary = newSalary;

            context.SaveChanges();
        }

        public void DeleteEmployeesProjects(int projectId)
        {
            var selectedEmployeeProjects = context.EmployeesProjects
                .Select(ep => ep.ProjectId == projectId);

            context.RemoveRange(selectedEmployeeProjects);
            context.SaveChanges();
        }

        public void AddProject(int id, string name, DateTime startDate, DateTime endDate)
        {
            Project newProject = new Project()
            {
                Id = id,
                Name = name,
                StartDate = startDate,
                EndDate = endDate
            };

            context.Projects.Add(newProject);
            context.SaveChanges();
        }
    }
}
