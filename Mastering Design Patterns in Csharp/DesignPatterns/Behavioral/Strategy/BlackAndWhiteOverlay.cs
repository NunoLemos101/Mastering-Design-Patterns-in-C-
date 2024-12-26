namespace Mastering_Design_Patterns_in_Csharp.DesignPatterns.Behavioral.Strategy;

public class BlackAndWhiteOverlay : IOverlay
{
    public void Apply()
    {
        Console.WriteLine("Applying black and white overlay.");
    }
}