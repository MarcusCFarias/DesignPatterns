using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator
{
    internal class Whip : AddOnDecorator
    {
        Beverage Beverage { get; set; }

        public Whip(Beverage beverage)
        {
            Beverage = beverage;
        }
        public override string Description => this.Beverage.Description + ", Whip";
        public override double Cost()
        {
            return this.Beverage.Cost() + 0.1;
        }
    }
}
