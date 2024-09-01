using DesignPattern.FlyweightPattern.Shapes;

namespace DesignPattern.FlyweightPattern;

public class ShapeFactory
{
    private static Dictionary<string, IShape> _dictionary;

    public static IShape GetCircle(string color)
    {
        if (!_dictionary.ContainsKey(color))
        {
            _dictionary[color] = new Circle(color);
        }

        return _dictionary[color];
    }
}