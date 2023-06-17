namespace Decorator.Domain;

public abstract class CondimentDecorator : Beverage
{
    public Beverage _beverage; 

    public CondimentDecorator(Beverage beverage) 
    {
        _beverage = beverage; 
    }   
    
    public abstract decimal CalculateAdditionalCost(); 
}