using Decorator.Domain.Enums;

namespace Decorator.Domain;

public abstract class Beverage
{
    private string Description;  

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
    
    public void SetBeverageSize(Size size)
    {
        Size = size;
    } 
     
    public Size Size { get; private set; } 
    
    public abstract decimal Cost();
} 