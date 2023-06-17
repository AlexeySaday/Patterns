using Decorator.Domain.Enums;

namespace Decorator.Domain.Condiments;

public class Milk : CondimentDecorator
{
    private readonly decimal _ownCost;
    private readonly string _description;

    public Milk(Beverage beverage, 
        decimal ownCost = 0.89m, string description = ", Milk") : base(beverage)
    {
        _ownCost = ownCost;
        _description = description; 
    }

    public override decimal Cost()
    {
        return _beverage.Cost() + CalculateAdditionalCost() + _ownCost;
    }

    public override string GetDescription()
    {
        return _beverage.GetDescription() + _description;
    }

    public override decimal CalculateAdditionalCost()
    {
        switch (_beverage.Size)
        {
            case Size.Tall:
                return 0.1m;
            case Size.Grande:
                return 0.4m;
            case Size.Venti:
                return 0.6m;
            case Size.Unknown:
                throw new NotImplementedException("Size was not configured for the Beverage subclass");
            default:
                throw new NotImplementedException();
        }  
    }
}