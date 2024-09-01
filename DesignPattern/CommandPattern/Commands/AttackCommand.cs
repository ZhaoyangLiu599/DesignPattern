namespace DesignPattern.CommandPattern.Commands;

public class AttackCommand : ICommand
{
    private readonly Player _player;
    
    public AttackCommand(Player player)
    {
        _player = player;
    }

    public void Execute()
    {
        _player.Attack();    
    }

    public ICommand Undo()
    {
        Console.WriteLine("Undo Attack");
        return this;
    }
}