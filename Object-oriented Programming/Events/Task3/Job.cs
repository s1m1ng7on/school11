using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
    public class Job
    {
        public string Name { get; private set; }
        public int RequiredWorkHours { get; private set; }
        public IEmployee Employee { get; private set; }

        public Job(string name, int requiredWorkHours, IEmployee employee)
        {
            Name = name;
            RequiredWorkHours = requiredWorkHours;
            Employee = employee;
        }

        public void Update()
        {
            Employee.WorkHours -= RequiredWorkHours;

            if (Employee.WorkHours <= 0)
                Console.WriteLine($"Job {Name} done!");
        }
    }
}