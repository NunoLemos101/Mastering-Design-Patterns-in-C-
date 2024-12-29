namespace Mastering_Design_Patterns_in_Csharp.DesignPatterns.Creational.Singleton;

public sealed class Logger
{
    private static readonly Lazy<Logger> Lazy = new Lazy<Logger>(() => new Logger());
    
    public static Logger Instance => Lazy.Value;

    private Logger()
    {
        // Private constructor
    }
    
    public void Log(string message)
    {
        Console.WriteLine(message);
    }
}