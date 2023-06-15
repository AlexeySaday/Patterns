namespace Decorator.Domain.Condiments;

public class Mocha : CondimentDecorator
{ 
    public Mocha(Beverage beverage) : base(beverage) { }  

    public override decimal Cost()
    {
        return _beverage.Cost() + 0.88m;
    }

    public override string GetDescription()
    {
        return _beverage.GetDescription() + " ,Mocha";
    }
}