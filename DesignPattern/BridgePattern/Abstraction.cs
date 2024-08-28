using DesignPattern.BridgePattern.Implementors;

namespace DesignPattern.BridgePattern;

public abstract class Abstraction
{
    protected IImplementor Implementor;

    public Abstraction(IImplementor implementor)
    {
        Implementor = implementor;
    }
    
    public abstract void Operation();
}