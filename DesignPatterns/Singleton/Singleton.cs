using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Singleton
{
    internal class Singleton
    {
        private static int count = 0;
        private static Singleton instance;
        private Singleton()
        {
            count++;
            Console.WriteLine(string.Concat("Singleton was created ", count, " times"));
        }
        public static Singleton GetInstance()
        {
            if (instance == null)
                instance = new Singleton();
            
            return instance;
        }

        public void Message(string message)
        {
            Console.WriteLine(message);
        }
    }
}
