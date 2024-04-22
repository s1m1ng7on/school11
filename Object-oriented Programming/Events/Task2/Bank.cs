using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;

namespace Task2
{
    public class Bank
    {
        private Publisher publisher;

        public List<BankAccount> BankAccounts { get; private set; }

        public Bank()
        {
            BankAccounts = new List<BankAccount>();
            publisher = new Publisher();
        }

        public void AddBankAccount(BankAccount bankAccount)
        {
            BankAccounts.Add(bankAccount);
            publisher.AddObserver(bankAccount);
        }

        public void MakeTransaction(BankAccount bankAccount, Transaction transaction)
        {
            publisher.Notify(bankAccount, transaction);
        }
    }
}
