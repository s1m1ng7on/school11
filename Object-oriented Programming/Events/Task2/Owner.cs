using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;

namespace Task2
{
    public class Owner : IObserver
    {
        private static int identity = 1;

        public int Id { get; private set; }
        public string Name { get; private set; }
        public int Age { get; private set; }
        public List<BankAccount> BankAccounts { get; private set; }

        public Owner(string name, int age)
        {
            Id = identity;
            Name = name;
            Age = age;
            BankAccounts = new List<BankAccount>();

            identity++;
        }

        public void Update(BankAccount bankAccount, Transaction transaction)
        {
            if (BankAccounts.Contains(bankAccount))
                Console.WriteLine($"{Name} made a transaction with bank account {bankAccount.Address}: {(transaction.Type == TransactionType.Deposit ? "+" : "-")}{transaction.Amount}\t\t{transaction.CompletionDate}");
        }
    }
}
