using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy
{
    internal abstract class Duck
    {
        public IFlyBehavior Fly { get; private set; }
        public IQuackBehavior Quack { get; private set; }
        public abstract void Display();
        public void SetFlyBehavior(IFlyBehavior flyBehavior) => this.Fly = flyBehavior;
        public void SetQuackBehavior(IQuackBehavior quackBehavior) => this.Quack = quackBehavior;
        public void Flying() => Fly.Fly();
        public void Quacking() => Quack.Quack();
    }
}
