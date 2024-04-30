using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
    public interface IEmployee
    {
        string Name { get; set; }
        int WorkHours { get; set; }
        void Update();
    }

    public class StandartEmployee : IEmployee
    {
        public string Name { get; set; }
        public int WorkHours { get; set; }

        public StandartEmployee(string name)
        {
            Name = name;
            WorkHours = 40;
        }
    }

    public class PartTimeEmployee : IEmployee
    {
        public string Name { get; set; }
        public int WorkHours { get; set; }

        public PartTimeEmployee(string name)
        {
            Name = name;
            WorkHours = 20;
        }
    }
}
