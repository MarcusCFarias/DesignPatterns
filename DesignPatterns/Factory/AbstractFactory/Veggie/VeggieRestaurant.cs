using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory.Veggie
{
    internal class VeggieRestaurant : Restaurant
    {
        internal override Burguer Burguer()
        {
            return new VeggieBurguer();
        }

        internal override FrenchFries FrenchFries()
        {
            return new VeggieFrenchFries();
        }
    }
}
