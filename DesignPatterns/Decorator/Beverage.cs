using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator
{
    internal abstract class Beverage
    {
        protected string _description = "Unkown Beverage";
        public abstract string Description { get; }
        public abstract double Cost();
    }
}
