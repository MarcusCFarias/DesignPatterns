using AbstractFactory.Normal;
using AbstractFactory.Veggie;
using System.Text;

var normalRestaurant = new NormalRestaurant();
string status = string.Empty;

status = string.Concat(status, normalRestaurant.Burguer().Prepare());
status = string.Concat(status, normalRestaurant.FrenchFries().Prepare());

Console.WriteLine(status);

var veggieRestaurant = new VeggieRestaurant();
status = string.Empty;

status = string.Concat(status, veggieRestaurant.Burguer().Prepare());
status = string.Concat(status, veggieRestaurant.FrenchFries().Prepare());

Console.WriteLine(status);