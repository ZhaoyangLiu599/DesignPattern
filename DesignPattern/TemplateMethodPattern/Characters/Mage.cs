namespace DesignPattern.TemplateMethodPattern.Characters;

public class Mage : Character
{
    protected override void Prepare()
    {
        Console.WriteLine("Mage prepares magical spells.");
    }

    protected override void ExecuteAction()
    {
        Console.WriteLine("Mage casts a fireball spell!");
    }

    protected override void CleanUp()
    {
        Console.WriteLine("Mage restores mana.");
    }
}