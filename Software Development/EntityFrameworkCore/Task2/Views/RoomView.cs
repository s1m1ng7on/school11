using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2.Views
{
    public class RoomView
    {
        public string Number { get; private set; }

        public RoomView()
        {
            Number = GetNumber();
        }

        public string GetNumber()
        {
            Console.Write("Enter room number: ");
            return Console.ReadLine();
        }
    }
}
