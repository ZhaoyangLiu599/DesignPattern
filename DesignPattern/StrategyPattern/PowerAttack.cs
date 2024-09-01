namespace DesignPattern.StrategyPattern;

public class PowerAttack : IAttackStrategy
{
    public void Attack()
    {
        Console.WriteLine("Performing a power attack!");
    }
}