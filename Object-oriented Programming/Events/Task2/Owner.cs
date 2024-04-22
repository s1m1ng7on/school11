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
        public string Name { get; private set; }
        public int Age { get; private set; }
        public List<BankAccount> BankAccounts { get; private set; }

        public Owner(string name, int age)
        {
            Name = name;
            Age = age;
            BankAccounts = new List<BankAccount>();
        }

        public void Update(BankAccount bankAccount, Transaction transaction)
        {
            if (BankAccounts.Contains(bankAccount))
                Console.WriteLine($"Transaction made.");
        }
    }
}
