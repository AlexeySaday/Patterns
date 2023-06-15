namespace Decorator.Domain;

public abstract class CondimentDecorator : Beverage
{
    public Beverage _beverage;

    protected CondimentDecorator(Beverage beverage) 
    {
        _beverage = beverage;
    }  
}