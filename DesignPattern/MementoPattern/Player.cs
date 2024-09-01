namespace DesignPattern.MementoPattern;

public class Player
{
    public int Health { get; set; }
    public int Mana { get; set; }
    public int Position { get; set; }

    public void SetState(int health, int mana, int position)
    {
        Health = health;
        Mana = mana;
        Position = position;
    }

    public PlayerMemento SaveState()
    {
        return new PlayerMemento(Health, Mana, Position);
    }

    public void RestoreState(PlayerMemento memento)
    {
        Health = memento.Health;
        Mana = memento.Mana;
        Position = memento.Position;
    }

    public void DisplayState()
    {
        Console.WriteLine($"Player State: Health={Health}, Mana={Mana}, Position={Position}");
    }
}