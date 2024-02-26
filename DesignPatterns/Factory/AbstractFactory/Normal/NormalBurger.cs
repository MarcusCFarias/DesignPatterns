using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory.Normal
{
    internal class NormalBurger : Burguer
    {
        internal override string Prepare()
        {
            return "Preparing normal burguer!\n";
        }
    }
}
