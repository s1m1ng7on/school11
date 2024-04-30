using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
    public class Publisher
    {
        private List<IEmployee> observers;

        public Publisher()
        {
            observers = new List<IEmployee>();
        }

        public void AddObserver(IEmployee observer)
        {
            observers.Add(observer);
        }

        public void Notify()
        {
            observers.ForEach(o => o.Update());
        }
    }
}
