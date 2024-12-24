namespace Mastering_Design_Patterns_in_Csharp.SOLID.I;

public class Robot : IWorker
{
    public void Work()
    {
        Console.WriteLine("Robot is working.");
    }
}