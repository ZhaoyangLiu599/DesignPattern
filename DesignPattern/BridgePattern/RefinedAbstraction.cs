using DesignPattern.BridgePattern.Implementors;

namespace DesignPattern.BridgePattern;

public class RefinedAbstraction : Abstraction
{
    public RefinedAbstraction(IImplementor implementor) : base(implementor)
    {
    }

    public override void Operation()
    {
        Implementor.OperationImplementation();
    }
}