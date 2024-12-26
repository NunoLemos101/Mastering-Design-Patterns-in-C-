namespace Mastering_Design_Patterns_in_Csharp.DesignPatterns.Behavioral.Command;

public class Light
{
    public void TurnOn()
    {
        Console.WriteLine("Light is on.");
    }

    public void TurnOff()
    {
        Console.WriteLine("Light is off.");
    }

    public void Dim()
    {
        Console.WriteLine("Light is dim.");
    }
}