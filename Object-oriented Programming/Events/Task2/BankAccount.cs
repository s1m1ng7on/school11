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
        public decimal Balance { get; private set; }

        public BankAccount()
        {
            Balance = 0;
        }

        public void Update(BankAccount bankAccount, Transaction transaction)
        {
            if (bankAccount == this)
                transaction.Proceed();
        }
    }
}
