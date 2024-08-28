using DesignPattern.AbstractFactory.Cpus;
using DesignPattern.AbstractFactory.Graphics;

namespace DesignPattern.AbstractFactory.Factories;

public interface IComputerFactory
{
    public IGraphic CreateGraphic();
    public ICpu CreateCpu();
}