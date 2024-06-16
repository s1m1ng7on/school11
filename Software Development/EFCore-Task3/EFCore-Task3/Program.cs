namespace EFCore_Task3
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Controller controller = new Controller();

            Console.WriteLine("\n", controller.GetEmployeesBySalary(500));
        }
    }
}