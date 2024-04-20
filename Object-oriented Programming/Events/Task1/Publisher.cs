namespace Task1
{
    public static class Publisher
    {
        private static List<IObserver> observers = new List<IObserver>();

        public static void AddObserver(IObserver observer)
        {
            observers.Add(observer);
        }

        public static void Notify(Student student, string subject, int grade)
        {
            foreach (IObserver observer in observers)
            {
                observer.Update(student, subject, grade);
            }
        }
    }
}
