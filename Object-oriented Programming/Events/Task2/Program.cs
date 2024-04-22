using System;

namespace Task2
{
    public class Program
    {
        static Bank myBank = new Bank();

        static void Main(string[] args)
        {
            PrintInstructions();
        }

        static void PrintInstructions()
        {
            Console.WriteLine("---BANK MANAGER---\n" +
                "\n" +
                "Commands:\n" +
                "   client <name> <age>\t\tCreate a client\n" +
                "   account <client ID>\t\tCreate a bank account\n" +
                "   transaction <bank account IBAN> +/-<amount>\t\tMake a transaction");
        }
    }
}