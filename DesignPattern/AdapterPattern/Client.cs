namespace DesignPattern.AdapterPattern;

public class Client
{
    public void Execute(ITarget target)
    {
        target.Request();
    }
}