using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy
{
    internal class RubberDuck : Duck
    {
        public RubberDuck()
        {
            this.SetQuackBehavior(new QuackNoWay());
            this.SetFlyBehavior(new FlyNoWay());
        }

        public override void Display()
        {
            Console.WriteLine("I am a rubber duck!");
        }
    }
}
