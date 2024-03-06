using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Command
{
    internal class SushiOrderCommand : ICommand
    {
        private SushiChef Chef { get; set; }
        private string SushiType { get; set; }

        public SushiOrderCommand(SushiChef chef, string sushiType)
        {
            this.Chef = chef;
            this.SushiType = sushiType;
        }
        public void Execute()
        {
            this.Chef.PrepareSushi(SushiType);
        }

        public void Undo()
        {
            this.Chef.UndoSushiPreparation(SushiType);
        }
    }
}
