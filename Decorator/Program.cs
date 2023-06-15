using Decorator.Domain;
using Decorator.Domain.Condiments;
using Decorator.Domain.Main;

Beverage beverage = new HouseBlend("HouseBlend#1");

beverage = new Milk(beverage);
beverage = new Milk(beverage);
beverage = new Mocha(beverage);

Console.WriteLine($"This coffee contains {beverage.GetDescription()}");
Console.WriteLine($"This coffee costs {beverage.Cost()}");
Console.ReadKey();

