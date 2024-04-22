namespace Task1
{
    public class Publisher
    {
        private List<IObserver> observers = new List<IObserver>();

        public void AddObserver(IObserver observer)
        {
            observers.Add(observer);
        }

        public void Notify(Student student, string subject, int grade)
        {
            foreach (IObserver observer in observers)
            {
                observer.Update(student, subject, grade);
            }
        }
    }
}
