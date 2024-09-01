namespace DesignPattern.StrategyPattern;

public class NormalAttack : IAttackStrategy
{
    public void Attack()
    {
        Console.WriteLine("Performing a normal attack!");
    }
}