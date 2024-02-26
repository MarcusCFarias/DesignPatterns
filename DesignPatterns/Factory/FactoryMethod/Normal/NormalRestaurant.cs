using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod
{
    internal class NormalRestaurant : Restaurant
    {
        internal override Burguer PrepareBurguer()
        {
            return new NormalBurger();
        }
    }
}
