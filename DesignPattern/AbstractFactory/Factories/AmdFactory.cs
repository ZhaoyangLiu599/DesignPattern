using DesignPattern.AbstractFactory.Cpus;
using DesignPattern.AbstractFactory.Graphics;

namespace DesignPattern.AbstractFactory.Factories;

public class AmdFactory : IComputerFactory
{
    public IGraphic CreateGraphic() => new AmdGraphic();

    public ICpu CreateCpu() => new AmdCpu();
}