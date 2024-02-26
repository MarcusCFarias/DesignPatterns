

using FactoryMethod;

var normalRestaurant = new NormalRestaurant();
var status = normalRestaurant.PrepareBurguer().Prepare();

Console.WriteLine(status);

var veggieRestaurant = new VeggieRestaurant();
status = veggieRestaurant.PrepareBurguer().Prepare();

Console.WriteLine(status);