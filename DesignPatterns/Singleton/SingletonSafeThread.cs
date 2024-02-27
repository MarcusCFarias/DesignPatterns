using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Singleton
{
    internal sealed class SingletonSafeThread
    {
        private static int count = 0;
        private static readonly Lazy<SingletonSafeThread> instance = new Lazy<SingletonSafeThread>(() => new SingletonSafeThread());
        private SingletonSafeThread()
        {
            count++;
            Console.WriteLine(string.Concat("Singleton was created ", count, " times"));
        }
        public static SingletonSafeThread GetInstance()
        {
            return instance.Value;
        }

        public void Message(string message)
        {
            Console.WriteLine(message);
        }

    }
}
