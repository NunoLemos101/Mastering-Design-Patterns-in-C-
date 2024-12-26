namespace Mastering_Design_Patterns_in_Csharp.DesignPatterns.Behavioral.Strategy;

public class CompressorMov : ICompressor
{
    public void Compress()
    {
        Console.WriteLine("Compressing video using MOV.");
    }
}