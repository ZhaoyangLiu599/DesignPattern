namespace DesignPattern.MediatorPattern;

public interface IChatMediator
{
    void SendMessage(string message, Player sender);
    void AddPlayer(Player player);
}