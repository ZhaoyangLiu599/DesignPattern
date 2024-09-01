namespace DesignPattern.MementoPattern;

public class PlayerMemento
{
    public int Health { get; private set; }
    public int Mana { get; private set; }
    public int Position { get; private set; }

    public PlayerMemento(int health, int mana, int position)
    {
        Health = health;
        Mana = mana;
        Position = position;
    }
}