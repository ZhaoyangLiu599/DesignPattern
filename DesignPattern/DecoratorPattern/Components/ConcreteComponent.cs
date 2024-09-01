namespace DesignPattern.DecoratorPattern.Components;

public class ConcreteComponent : IComponent
{
    public void Operation()
    {
        Console.WriteLine("Concrete Component");
    }
}