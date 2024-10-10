using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingletonExample
{
    public sealed class Singleton2
    {
        Singleton2() { }
        private static readonly object _lock = new object ();
        private static Singleton2 instance = null;
        public static Singleton2 Instance
        {
            get
            {
                lock (_lock)
                    {
                        if (instance == null)
                        {
                            instance = new Singleton2();
                        }
                        return instance;
                    }
            }
        }
    }
}
