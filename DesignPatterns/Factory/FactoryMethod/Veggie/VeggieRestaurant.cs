using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod
{
    internal class VeggieRestaurant : Restaurant
    {
        internal override Burguer PrepareBurguer()
        {
            return new VeggieBurger();
        }
    }
}
