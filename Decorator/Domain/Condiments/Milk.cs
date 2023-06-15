namespace Decorator.Domain.Condiments;

public class Milk : CondimentDecorator
{
    private readonly decimal _cost;
    private readonly string _description;

    public Milk(Beverage beverage, 
        decimal cost = 0.89m, string description = " ,Milk") : base(beverage)
    {
        _cost = cost;
        _description = description; 
    }

    public override decimal Cost()
    {
        return _beverage.Cost() + _cost;
    }

    public override string GetDescription()
    {
        return _beverage.GetDescription() + _description;
    }
}