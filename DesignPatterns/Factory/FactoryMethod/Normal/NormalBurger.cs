using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod
{
    internal class NormalBurger : Burguer
    {
        internal override string Prepare()
        {
            return string.Concat("Preparing beef burguer!");
        }
    }
}
