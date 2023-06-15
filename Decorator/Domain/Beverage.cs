namespace Decorator.Domain;

public abstract class Beverage
{
    protected string Description;

    public Beverage()
    {
        Description = "Unknown coffee";
    }
    
    public Beverage(string description)
    {
        Description = description;
    }

    public virtual string GetDescription()
    {
        return Description;
    }

    public abstract decimal Cost();
}