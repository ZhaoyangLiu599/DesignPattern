using DesignPattern.CommandPattern.Commands;

namespace DesignPattern.CommandPattern;

public class CommandController
{
    private Stack<ICommand> _commandHistories = new Stack<ICommand>();

    public void ExecuteCommand(ICommand command)
    {
        command.Execute();
        _commandHistories.Push(command);   
    }

    public void UndoLastCommand()
    {
        ICommand command = _commandHistories.Pop();
        command.Undo();
    }
}