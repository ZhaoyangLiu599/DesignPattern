using DesignPattern.BuilderPattern.Items;
using DesignPattern.BuilderPattern.Packings;

namespace DesignPattern.BuilderPattern.Cookers;

public class BurgerCooker : ICooker
{
    private Meal _meal = new Meal();
    
    public void AddItem()
    {
        _meal.Item = new Burger();
    }

    public void AddPacking()
    {
        _meal.Packing = new Wrapper();
    }

    public Meal GetMeal()
    {
        return _meal;
    }
}