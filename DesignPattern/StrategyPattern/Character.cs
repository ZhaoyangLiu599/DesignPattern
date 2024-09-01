namespace DesignPattern.StrategyPattern;

public class Character
{
    private IAttackStrategy _attackStrategy;

    public Character(IAttackStrategy attackStrategy)
    {
        _attackStrategy = attackStrategy;
    }

    public void SetAttackStrategy(IAttackStrategy attackStrategy)
    {
        _attackStrategy = attackStrategy;
    }

    public void PerformAttack()
    {
        _attackStrategy.Attack();
    }
}