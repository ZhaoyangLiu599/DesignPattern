using DesignPattern.DecoratorPattern.Components;

namespace DesignPattern.DecoratorPattern.Decorator;

public abstract class Decorator : IComponent
{
    public virtual void Operation()
    {
        Console.WriteLine("Decorator");
    }
}