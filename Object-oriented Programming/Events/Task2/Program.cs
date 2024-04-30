using System;

namespace Task2
{
    public class Program
    {
        static Bank myBank = new Bank();

        static void Main(string[] args)
        {
            WriteInstructions();
            ReadInput();
        }

        static void WriteInstructions()
        {
            Console.WriteLine("---BANK MANAGER---\n" +
                "\n" +
                "Commands:\n" +
                "   client <name> <age>\t\tCreate a client\n" +
                "   account <address> <client ID>\t\tCreate a bank account\n" +
                "   transaction <bank account ID or address> +/-<amount>\t\tMake a transaction");
        }

        static void ReadInput()
        {
            string[] inputArgs;
            while ((inputArgs = Console.ReadLine().Split(' '))[0].ToLower() != "end")
            {
                switch (inputArgs[0].ToLower())
                {
                    case "client":
                        myBank.AddClient(inputArgs[1], int.Parse(inputArgs[2]));
                        break;
                    case "account":
                        myBank.AddBankAccount(inputArgs[2], int.Parse(inputArgs[3]));
                        break;
                    case "transaction":
                        TransactionType transactionType = (inputArgs[2][0] == '+' ? TransactionType.Deposit : TransactionType.Deposit);
                        decimal transactionAmount = decimal.Parse(inputArgs[2].Substring(1));
                        myBank.MakeTransaction(inputArgs[1], transactionAmount, transactionType);
                        break;
                }
            }
        }
    }
}