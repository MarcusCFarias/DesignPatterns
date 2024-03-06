using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Command
{
    //invoker class
    internal class Customer
    {
        private readonly List<ICommand> orders = new List<ICommand>();

        //register
        public void PlaceOrder(ICommand order)
        {
            orders.Add(order);
        }

        //execute
        public void SubmitOrders()
        {
            orders.ForEach(x => x.Execute());
            orders.Clear();
        }

        public void UndoLastOrder()
        {
            if (orders.Count > 0)
            {
                var lastOrder = orders[orders.Count - 1];
                lastOrder.Undo();
                orders.RemoveAt(orders.Count - 1);
            }
        }
    }
}
