using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory
{
    internal abstract class Restaurant
    {
        internal abstract Burguer Burguer();
        internal abstract FrenchFries FrenchFries();


    }
}
