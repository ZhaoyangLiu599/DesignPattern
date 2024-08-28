using DesignPattern.AbstractFactory.Cpus;
using DesignPattern.AbstractFactory.Graphics;

namespace DesignPattern.AbstractFactory.Factories;

public class IntelFactory : IComputerFactory
{
    public IGraphic CreateGraphic() => new IntelGraphic();

    public ICpu CreateCpu() => new IntelCpu();
}