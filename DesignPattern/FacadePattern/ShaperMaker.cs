using DesignPattern.FacadePattern.Shapes;

namespace DesignPattern.FacadePattern;

public class ShaperMaker
{
    private Circle _circle;
    private Triangle _triangle;

    public ShaperMaker()
    {
        _circle = new Circle();
        _triangle = new Triangle();
    }

    public void DrawCircle()
    {
        _circle.Draw();
    }

    public void DrawTriangle()
    {
        _triangle.Draw();
    }
}