
using Command;


SushiChef sushiChef = new SushiChef();
var orderNigiri = new SushiOrderCommand(sushiChef, "Nigiri");
var orderSashimi = new SushiOrderCommand(sushiChef, "Sashimi");

Customer customer = new Customer();
customer.PlaceOrder(orderNigiri);
customer.PlaceOrder(orderSashimi);

customer.UndoLastOrder();

customer.SubmitOrders();

customer.UndoLastOrder();