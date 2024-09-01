namespace DesignPattern.CommandPattern;

public class Player
{
    public void Attack()
    {
        Console.WriteLine("Attack");
    }

    public void Move(float x, float y)
    {
        Console.WriteLine($"Move to ({x}, {y})");
    }
}