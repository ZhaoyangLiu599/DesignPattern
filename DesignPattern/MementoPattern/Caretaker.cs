namespace DesignPattern.MementoPattern;

public class Caretaker
{
    private Stack<PlayerMemento> _mementoStack = new Stack<PlayerMemento>();

    public void SaveState(Player player)
    {
        _mementoStack.Push(player.SaveState());
    }

    public void RestoreState(Player player)
    {
        if (_mementoStack.Count > 0)
        {
            var memento = _mementoStack.Pop();
            player.RestoreState(memento);
        }
    }
}