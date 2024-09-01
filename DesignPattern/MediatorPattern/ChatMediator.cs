namespace DesignPattern.MediatorPattern;

public class ChatMediator : IChatMediator
{
    private List<Player> _players = new List<Player>();

    public void AddPlayer(Player player)
    {
        _players.Add(player);
    }

    public void SendMessage(string message, Player sender)
    {
        foreach (var player in _players)
        {
            if (player != sender)
            {
                player.ReceiveMessage(message);
            }
        }
    }
}