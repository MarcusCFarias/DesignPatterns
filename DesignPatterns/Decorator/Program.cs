// See https://aka.ms/new-console-template for more information
using Decorator;

Console.WriteLine("Decorator Pattern!!!");

Beverage darkRoast = new DarkRoast();
Console.WriteLine(darkRoast.Description + "\n" + darkRoast.Cost());

var darkRoastWithSoy = new Soy(darkRoast);
Console.WriteLine(darkRoastWithSoy.Description + "\n" + darkRoastWithSoy.Cost());

var darkRoastWithSoyAndWhip = new Whip(darkRoastWithSoy);
Console.WriteLine(darkRoastWithSoyAndWhip.Description + "\n" + darkRoastWithSoyAndWhip.Cost());