using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingletonExample
{
    public sealed class Singleton3
    {
        Singleton3() { }
        private static readonly object _lock = new object ();
        private static Singleton3 instance = null;
        public static Singleton3 Instance
        {
            get
            {
                if (instance == null)
                {
                    lock (_lock)
                        {
                            if (instance == null)
                            {
                                instance = new Singleton3();
                            }
                        }
                }
                return instance;
            }
        }
    }
}
