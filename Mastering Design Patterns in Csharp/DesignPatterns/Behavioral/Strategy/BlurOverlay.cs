namespace Mastering_Design_Patterns_in_Csharp.DesignPatterns.Behavioral.Strategy;

public class BlurOverlay : IOverlay
{
    public void Apply()
    {
        Console.WriteLine("Applying blur overlay.");
    }
}