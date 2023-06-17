using Decorator.Domain;
using Decorator.Domain.Condiments;
using Decorator.Domain.Enums;
using Decorator.Domain.Main;

Beverage beverage = new HouseBlend("HouseBlend#1"); 
beverage.SetBeverageSize(Size.Grande);

beverage = new Milk(beverage);
beverage = new Milk(beverage);
beverage = new Mocha(beverage);

Console.WriteLine($"This coffee type {beverage.Size}");
Console.WriteLine($"This coffee contains {beverage.GetDescription()}");
Console.WriteLine($"This coffee costs {beverage.Cost()}");
Console.ReadKey();

