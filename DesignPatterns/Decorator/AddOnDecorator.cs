using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator
{
    internal abstract class AddOnDecorator : Beverage
    {
        public abstract override string Description { get; }
    }
}
