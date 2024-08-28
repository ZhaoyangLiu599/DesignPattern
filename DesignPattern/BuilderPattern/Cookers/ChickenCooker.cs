using DesignPattern.BuilderPattern.Items;
using DesignPattern.BuilderPattern.Packings;

namespace DesignPattern.BuilderPattern.Cookers;

public class ChickenCooker : ICooker
{
    private Meal _meal = new Meal();
    public void AddItem()
    {
        _meal.Item = new Chicken();
    }

    public void AddPacking()
    {
        _meal.Packing = new Bottle();
    }

    public Meal GetMeal()
    {
        return _meal;
    }
}