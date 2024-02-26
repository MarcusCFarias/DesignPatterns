using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy
{
    internal class MallardDuck : Duck
    {
        public MallardDuck()
        {
            this.SetQuackBehavior(new QuackNormal());
            this.SetFlyBehavior(new FlyWithWings());
        }
        public override void Display()
        {
            Console.WriteLine("I am a mallard duck!");
        }
    }
}
