using DesignPattern.DecoratorPattern.Components;

namespace DesignPattern.DecoratorPattern.Decorator;

public class ConcreteDecorator : Decorator
{
    private IComponent _component;
    public ConcreteDecorator(IComponent component)
    {
        _component = component;
    }

    public override void Operation()
    {
        Console.WriteLine("Concrete Decorator");
    }   
}