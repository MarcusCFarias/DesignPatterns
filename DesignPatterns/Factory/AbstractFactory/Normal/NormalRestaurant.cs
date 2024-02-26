using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory.Normal
{
    internal class NormalRestaurant : Restaurant
    {
        internal override Burguer Burguer()
        {
            return new NormalBurger();
        }

        internal override FrenchFries FrenchFries()
        {
            return new NormalFrenchFries();
        }
    }
}
