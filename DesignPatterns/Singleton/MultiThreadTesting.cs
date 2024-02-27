using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Singleton
{
    internal static class MultiThreadTesting
    {
        public static void Test0()
        {
            Singleton singleton0 = Singleton.GetInstance();
            singleton0.Message("Singleton 0");

        }
        public static void Test1()
        {
            Singleton singleton1 = Singleton.GetInstance();
            singleton1.Message("Singleton 1");
        }
        public static void Test2()
        {
            SingletonSafeThread singleton0 = SingletonSafeThread.GetInstance();
            singleton0.Message("Singleton 2");

        }
        public static void Test3()
        {
            SingletonSafeThread singleton1 = SingletonSafeThread.GetInstance();
            singleton1.Message("Singleton 3");
        }
    }
}
