using DesignPattern.BuilderPattern.Items;
using DesignPattern.BuilderPattern.Packings;

namespace DesignPattern.BuilderPattern;

public class Meal
{
    public IItem? Item;
    public IPacking? Packing;

    public string CheckMeal() => $" item is {Item?.GetItemName()}, packing is {Packing?.GetPackingName()}";
}