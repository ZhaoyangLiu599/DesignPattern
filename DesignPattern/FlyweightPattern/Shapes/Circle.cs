namespace DesignPattern.FlyweightPattern.Shapes;

public class Circle : IShape
{
    public string Color;

    public Circle(string color)
    {
        this.Color = color;
    }

    public void Draw()
    {
        Console.WriteLine($"{Color} of Circle");
    }
}