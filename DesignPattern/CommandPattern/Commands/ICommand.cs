namespace DesignPattern.CommandPattern.Commands;

public interface ICommand
{
    public void Execute();
    public ICommand Undo();
}