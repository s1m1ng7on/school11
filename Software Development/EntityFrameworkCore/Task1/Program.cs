using Task1.Data.Entities;

namespace Task1
{
    public class Program
    {
        public static void Main(string[] args)
        {
            DatabaseHelper databaseHelper = new DatabaseHelper();

            string[] commandArgs;
            while ((commandArgs = Console.ReadLine().Split(' '))[0].ToLower() != "end")
            {
                switch (commandArgs[0].ToLower())
                {
                    case "Add-Employee":
                        databaseHelper.Add<Employee>(new Employee()
                        {
                            Name = commandArgs[1],
                            Salary = decimal.Parse(commandArgs[2]),
                            Age = int.Parse(commandArgs[3]),
                            DepartmentId = int.Parse(commandArgs[4])
                        });
                        break;
                    case "Add-Department":
                        databaseHelper.Add<Department>(new Department()
                        {
                            Name = commandArgs[1],
                            Description = commandArgs[2]
                        });
                        break;
                }
            }
        }
    }
}