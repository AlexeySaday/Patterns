using Decorator.Domain.Enums;

namespace Decorator.Domain.Condiments;

public class Mocha : CondimentDecorator
{ 
    public Mocha(Beverage beverage) : base(beverage) { }  

    public override decimal Cost()
    {
        return _beverage.Cost() + CalculateAdditionalCost() + 1.88m;
    }

    public override string GetDescription()
    {
        return _beverage.GetDescription() + ", Mocha";
    }

    public override decimal CalculateAdditionalCost()
    {
        switch (_beverage.Size)
        {
            case Size.Tall:
                return 0.3m;
            case Size.Grande:
                return 0.5m;
            case Size.Venti:
                return 0.7m;
            case Size.Unknown:
                throw new NotImplementedException("Size was not configured for the Beverage subclass");
            default:
                throw new NotImplementedException();
        }  
    }
}