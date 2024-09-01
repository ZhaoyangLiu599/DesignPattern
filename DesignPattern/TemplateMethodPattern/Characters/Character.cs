namespace DesignPattern.TemplateMethodPattern.Characters;

public abstract class Character
{
    public void PerformAction()
    {
        Prepare();
        ExecuteAction();
        CleanUp();
    }

    protected abstract void Prepare();
    protected abstract void ExecuteAction();
    protected abstract void CleanUp();
}