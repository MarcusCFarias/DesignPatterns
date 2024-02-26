using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory.Veggie
{
    internal class VeggieBurguer : Burguer
    {
        internal override string Prepare()
        {
            return "Preparing veggie burguer!\n";
        }
    }
}
