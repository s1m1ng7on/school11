using System;
using System.Data.SqlClient;

namespace OnlineStoreProject
{
    public class Program
    {
        static void Main(string[] args)
        {
            PrintInstructions();
            ReadCommands();
        }

        static void PrintInstructions()
        {
            Console.WriteLine("ONLINE STORE PROJECT\n" +
                "By Simeon Gunev\n" +
                "-------------------------\n" +
                "CODE:\t\tCOMMAND:\n" +
                "(1)\t\tPrint all Products\n" +
                "(2)\t\tPrint all Sellers\n" +
                "(3)\t\tPrint all Customers\n" +
                "\n" +
                "(9) <product id> <customer id>\t\tMakes an order for the selected product." +
                "(end)\t\tClose the Application");
        }

        static void ReadCommands()
        {
            DatabaseHelper databaseHelper = new DatabaseHelper("Data Source=GUNEVI-LAPTOP\\SQLEXPRESS;Initial Catalog=OnlineStore;Integrated Security=True;Encrypt=False");

            string command;
            while ((command = Console.ReadLine()).ToLower() != "end")
            {
                int commandNumber = int.Parse(command);
                switch (commandNumber)
                {
                    case 1:
                        SqlDataReader reader1 = databaseHelper.ExecuteReader("SELECT * FROM Products");
                        while (reader1.Read())
                        {
                            Console.WriteLine(reader1["Name"]);
                            Console.WriteLine(reader1["Description"]);
                            Console.WriteLine($"{reader1["Quantity"]}x | ${reader1["Price"]:f2}");
                        }
                        break;
                    case 2:
                        SqlDataReader reader2 = databaseHelper.ExecuteReader("SELECT * FROM Sellers");
                        while (reader2.Read())
                        {
                            Console.WriteLine(reader2["Name"]);
                            Console.WriteLine(reader2["Description"]);
                            Console.WriteLine($"{reader2["Quantity"]}x | ${reader2["Price"]:f2}");
                        }
                        break;
                }
            }

            databaseHelper.Close();
        }
    }
}