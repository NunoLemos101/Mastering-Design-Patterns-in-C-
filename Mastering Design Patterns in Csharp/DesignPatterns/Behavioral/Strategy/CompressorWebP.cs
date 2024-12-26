namespace Mastering_Design_Patterns_in_Csharp.DesignPatterns.Behavioral.Strategy;

public class CompressorWebP : ICompressor
{
    public void Compress()
    {
        Console.WriteLine("Compressing video using WebP.");
    }
}