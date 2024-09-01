namespace DesignPattern.MediatorPattern;

public class Player
{
    private string _name;
    private IChatMediator _chatMediator;

    public Player(string name, IChatMediator chatMediator)
    {
        _name = name;
        _chatMediator = chatMediator;
    }

    public void SendMessage(string message)
    {
        Console.WriteLine($"{_name} sends: {message}");
        _chatMediator.SendMessage(message, this);
    }

    public void ReceiveMessage(string message)
    {
        Console.WriteLine($"{_name} receives: {message}");
    }
}