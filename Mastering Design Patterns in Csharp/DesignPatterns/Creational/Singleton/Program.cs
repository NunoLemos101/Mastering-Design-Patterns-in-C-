namespace Mastering_Design_Patterns_in_Csharp.DesignPatterns.Creational.Singleton;

public class Program
{
    public static void Main(string[] args)
    {
        var logger = Logger.Instance;
        logger.Log("Hello World!");
    }
}