using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator
{
    internal class Soy : AddOnDecorator
    {
        private Beverage Beverage { get; set; }

        public override string Description { get => Beverage.Description + ", Soy"; }

        public Soy(Beverage beverage)
        {
            this.Beverage = beverage;
        }
        public override double Cost()
        {
            return this.Beverage.Cost() + 0.15;
        }
    }
}
