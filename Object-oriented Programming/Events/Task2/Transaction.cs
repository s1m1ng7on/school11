using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    public class Transaction
    {
        public BankAccount BankAccount { get; private set; }
        public decimal Amount { get; private set; }
        public TransactionType Type { get; private set; }
        public DateTime CompletionDate { get; private set; }

        public Transaction(BankAccount bankAccount, decimal amount, TransactionType type)
        {
            BankAccount = bankAccount;
            Amount = amount;
            Type = type;
        }

        public void Complete()
        {
            switch (Type)
            {
                case TransactionType.Deposit:
                    BankAccount.Balance += Amount;
                    break;
                case TransactionType.Withdrawal:
                    if (BankAccount.Balance >= Amount)
                        BankAccount.Balance -= Amount;
                    else
                        throw new ArgumentException("Not Enough Bank Account Balance.");
                    break;
            }

            CompletionDate = DateTime.Now;
        }
    }

    public enum TransactionType
    { 
        Deposit,
        Withdrawal
    }
}
