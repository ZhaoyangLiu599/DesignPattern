namespace DesignPattern.BuilderPattern.Cookers;

public class CookerDirector
{
    private ICooker _cooker;
    public CookerDirector(ICooker cooker)
    {
        _cooker = cooker;
    }

    public Meal GetMeal()
    {
        _cooker.AddItem();
        _cooker.AddPacking();
        return _cooker.GetMeal();
    }
}