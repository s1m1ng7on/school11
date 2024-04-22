using System.Transactions;

namespace Task2
{
    public class Publisher
    {
        private List<IObserver> observers;

        public Publisher()
        {
            observers = new List<IObserver>();
        }

        public void AddObserver(IObserver observer)
        {
            observers.Add(observer);
        }

        public void Notify(BankAccount bankAccount, Transaction transaction)
        {
            observers.ForEach(o => o.Update(bankAccount, transaction));
        }
    }

    public interface IObserver
    {
        void Update(BankAccount bankAccount, Transaction transaction);
    }
}
