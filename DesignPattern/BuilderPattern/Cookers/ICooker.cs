namespace DesignPattern.BuilderPattern.Cookers;

public interface ICooker
{
    public void AddItem();
    public void AddPacking();
    
    public Meal GetMeal();
}