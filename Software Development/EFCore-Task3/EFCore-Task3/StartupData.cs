using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFCore_Task3
{
    public class StartupData
    {
        private readonly Controller controller = new Controller();

        public void SetStartupData()
        {
            controller.AddProject(1, "Kinter", new DateTime(2021, 3, 2), new DateTime(2021, 5, 6));
            controller.AddProject(2, "Kinter 2", new DateTime(2021, 11, 1), new DateTime(2022, 3, 16));
            controller.AddProject(3, "Air Rush", new DateTime(2023, 1, 26), new DateTime(2023, 4, 22));
            controller.AddProject(4, "Phantom Pursuit", new DateTime(2023, 12, 20), new DateTime(2024, 2, 14));
            controller.AddProject(5, "React Application Hunting", new DateTime(2024, 5, 16), new DateTime(2024, 6, 30));
            controller.AddProject(6, "Udemy Learning Hub", new DateTime(2023, 11, 15), new DateTime(2023, 12, 20));
        }
    }
}
