namespace DesignPattern.TemplateMethodPattern.Characters;

public class Warrior : Character
{
    protected override void Prepare()
    {
        Console.WriteLine("Warrior prepares for battle.");
    }

    protected override void ExecuteAction()
    {
        Console.WriteLine("Warrior attacks with a sword!");
    }

    protected override void CleanUp()
    {
        Console.WriteLine("Warrior cleans up after battle.");
    }
}