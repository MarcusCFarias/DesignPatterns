using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy
{
    internal class QuackNoWay : IQuackBehavior
    {
        public void Quack()
        {
            Console.WriteLine("No quack!");
        }
    }
}
