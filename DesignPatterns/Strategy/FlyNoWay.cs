﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy
{
    internal class FlyNoWay : IFlyBehavior
    {
        public void Fly()
        {
            Console.WriteLine("No fly!");
        }
    }
}
