using System;

namespace Task3
{
    public class Program
    {
        static void Main(string[] args)
        {
            WriteInstructions();
            ReadInput();
        }

        static void WriteInstructions()
        {
            Console.WriteLine("WorkForce\n" +
                "\n" +
                "Command\t\t\t\t\t\t\t\tFunction\n" +
                "Job <name> <required work hours> <employee name>\t\tCreates a job\n" +
                "StandartEmployee <name>\t\t\t\t\t\tCreates a standart employee\n" +
                "PartTimeEmployee <name>\t\t\t\t\t\tCreates a part-time employee\n" +
                "Pass Week\t\t\t\t\t\t\tUpdates the status of each job\n" +
                "Status\t\t\t\t\t\t\t\tPrints the status of each job");
        }

        static void ReadInput()
        {
            string[] inputArgs;
            while ((inputArgs = Console.ReadLine().Split(' '))[0] != "end")
            {
                if (inputArgs[0].ToLower() == "job")

            }
        }
    }
}