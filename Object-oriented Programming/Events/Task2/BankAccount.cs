using System;
using System.Buffers;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;

namespace Task2
{
    public class BankAccount : IObserver
    {
        private static int identity = 1;

        public int Id { get; private set; }
        public string Address { get; private set; }
        public decimal Balance { get; set; }

        public BankAccount(string address)
        {
            Id = identity;
            Address = address;
            Balance = 0;

            identity++;
        }

        public void Update(BankAccount bankAccount, Transaction transaction)
        {
            if (bankAccount == this)
                transaction.Complete();
        }
    }
}
