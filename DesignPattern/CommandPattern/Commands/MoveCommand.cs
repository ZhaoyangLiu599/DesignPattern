namespace DesignPattern.CommandPattern.Commands;

public class MoveCommand : ICommand
{
    private Player _player;
    private float _x;
    private float _y;
    
    public MoveCommand(Player player, float x, float y)
    {
        _player = player;
        _x = x;
        _y = y;
    }

    public void Execute()
    {
        _player.Move(_x, _y);
    }

    public ICommand Undo()
    {
        Console.WriteLine("Undo move");
        return this;
    }
}