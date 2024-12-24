namespace Mastering_Design_Patterns_in_Csharp.Principles.Coupling;

public class Engine : IEngine
{
    public void Start()
    {
        Console.WriteLine("Engine started.");
    }
}