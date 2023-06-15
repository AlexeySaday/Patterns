namespace Decorator.Domain.Main;

public class HouseBlend : Beverage
{
    public HouseBlend(string description) : base(description) { }
    
    public HouseBlend() : base() { }

    public override decimal Cost()
    {
        return 1.99m;
    }
}