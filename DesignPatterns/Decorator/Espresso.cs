﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator
{
    internal class Espresso : Beverage
    {
        public Espresso()
        {
            _description = "Espresso";
        }
        public override string Description => _description;

        public override double Cost()
        {
            return 1.99;
        }
    }
}
