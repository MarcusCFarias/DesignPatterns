using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory.Normal
{
    internal class NormalFrenchFries : FrenchFries
    {
        internal override string Prepare()
        {
            return "Preparing normal french fries!\n";
        }
    }
}
