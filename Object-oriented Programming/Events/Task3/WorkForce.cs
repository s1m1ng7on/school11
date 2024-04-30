using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
    public class WorkForce
    {
        private Publisher publisher;
        public List<Job> Jobs { get; private set; }
        public List<IEmployee> Employees { get; private set; }

        public WorkForce()
        {
            publisher = new Publisher();
            Jobs = new List<Job>();
            Employees = new List<IEmployee>();
        }

        public void AddJob(string name, int requiredWorkHours, string employeeName)
        {
            IEmployee employee = Employees.Where(e => e.Name == name).FirstOrDefault();

            if (employee == null)
                throw new ArgumentException($"Employee with the name {employeeName} was not found.");

            Job newJob = new Job(name, requiredWorkHours, employee);
            Jobs.Add(newJob);
        }

        public void AddEmployee(IEmployee employee)
        {
            Employees.Add(employee);
        }

        public void PassWeek()
        {
            publisher.Notify();
        }
    }
}
