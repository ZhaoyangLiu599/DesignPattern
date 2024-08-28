namespace DesignPattern.FilterPattern;

public class Person
{
    public int Old { get; set; }
    public string Name { get; set; }
    public string Gender { get; set; }

    public Person(int old, string name, string gender)
    {
        Old = old;
        Name = name;
        Gender = gender;
    }

    public override string ToString()
    {
        return $"Person : [ Name: {Name}, Gender: {Gender}, Marital Status: {Old} ]";
    }
}