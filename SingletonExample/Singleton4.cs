using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingletonExample
{
    public sealed class Singleton4
    {
        private static readonly Singleton4 instance = new Singleton4();
        static Singleton4()
        {
        }
        private Singleton4()
        {
        }
        public static Singleton4 Instance
        {
            get
            {
                return instance;
            }
        }
    }
}
