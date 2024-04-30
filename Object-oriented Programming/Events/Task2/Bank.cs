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

        public List<Owner> Clients { get; private set; }
        public List<BankAccount> BankAccounts { get; private set; }

        public Bank()
        {
            Clients = new List<Owner>();
            BankAccounts = new List<BankAccount>();
            publisher = new Publisher();
        }

        public void AddClient(string name, int age)
        {
            Owner newClient = new Owner(name, age);
            Clients.Add(newClient);
        }

        public void AddBankAccount(string address, int clientId)
        {
            BankAccount newBankAccount = new BankAccount(address);
            Owner bankAccountOwner = SelectClient(clientId);

            BankAccounts.Add(newBankAccount);
            bankAccountOwner.BankAccounts.Add(newBankAccount);
        }

        public void MakeTransaction(string bankAccountIdentifier, decimal transactionAmount, TransactionType transactionType)
        {
            BankAccount selectedBankAccount = SelectBankAccount(bankAccountIdentifier);
            Transaction transaction = new Transaction(selectedBankAccount, transactionAmount, transactionType);

            publisher.Notify(selectedBankAccount, transaction);
        }

        private Owner SelectClient(int clientId)
        {
            Owner selectedClient = Clients.Where(c => c.Id == clientId).FirstOrDefault();

            if (selectedClient == null)
                throw new ArgumentException("No Client was selected.");

            return selectedClient;
        }

        private BankAccount SelectBankAccount(string identification)
        {
            BankAccount selectedBankAccount = BankAccounts.Where(b => b.Id.ToString() == identification || b.Address == identification).FirstOrDefault();

            if (selectedBankAccount == null)
                throw new ArgumentException("No Bank Account was selected.");

            return selectedBankAccount;
        }
    }
}
