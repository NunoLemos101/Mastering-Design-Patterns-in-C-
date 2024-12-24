namespace Mastering_Design_Patterns_in_Csharp.SOLID.I;

public class Worker : IWorker, IEater, ISleeper
{
    public void Work()
    {
        Console.WriteLine("Worker is working.");
    }

    public void Eat()
    {
        Console.WriteLine("Worker is eating.");
    }

    public void Sleep()
    {
        Console.WriteLine("Worker is sleeping.");
    }
}