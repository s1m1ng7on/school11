using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace School.Core
{
    public class Singleton<T>
    {
        private readonly T _instance;

        public T Instance
        {
            get => _instance;
        }
    }
}
