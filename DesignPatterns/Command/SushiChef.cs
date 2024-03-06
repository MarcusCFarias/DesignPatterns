using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Command
{
    internal class SushiChef
    {
        public void PrepareSushi(string type)
        {
            Console.WriteLine($"Prepare {type} sushi!");
        }

        public void UndoSushiPreparation(string type)
        {
            Console.WriteLine($"Undoing preparation of {type} sushi");
        }
    }
}
