using DesignPattern.AbstractFactory.Cpus;
using DesignPattern.AbstractFactory.Factories;
using DesignPattern.AbstractFactory.Graphics;
using DesignPattern.AdapterPattern;
using DesignPattern.BridgePattern;
using DesignPattern.BridgePattern.Implementors;
using DesignPattern.BuilderPattern;
using DesignPattern.BuilderPattern.Cookers;
using DesignPattern.DecoratorPattern.Components;
using DesignPattern.DecoratorPattern.Decorator;
using DesignPattern.FacadePattern;
using DesignPattern.FlyweightPattern;

Console.WriteLine("Hello, World!");

/*IComputerFactory amdFactory = new AmdFactory();
IGraphic amdGraphic = amdFactory.CreateGraphic();
ICpu amdCpu = amdFactory.CreateCpu();

Console.WriteLine($"amd products are { amdGraphic.GetProductName() }, { amdCpu.GetProductName() }");*/

/*ICooker burgerCooker = new BurgerCooker();
CookerDirector cookerDirector = new CookerDirector(burgerCooker);
Meal burger = cookerDirector.GetMeal();
Console.WriteLine(burger.CheckMeal());*/

/*Client client = new Client();
Adapter adapter = new Adapter(new Adaptee());
client.Execute(adapter);*/

/*RefinedAbstraction refinedAbstraction = new RefinedAbstraction(new ConcreteImplementorA());
refinedAbstraction.Operation();*/

/*IComponent component = new ConcreteComponent();
IComponent decorate = new ConcreteDecorator(component);
decorate.Operation();*/

/*ShaperMaker shaperMaker = new ShaperMaker();
shaperMaker.DrawCircle();*/
