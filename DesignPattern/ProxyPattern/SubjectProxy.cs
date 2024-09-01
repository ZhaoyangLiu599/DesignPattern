namespace DesignPattern.ProxyPattern;

public class SubjectProxy : ISubject
{
    private ISubject _subject;

    public void Request()
    {
        if (_subject is null)
        {
            _subject = new RealSubject();
        }
        
        Console.WriteLine("proxy");
        
        _subject.Request();
    }
}