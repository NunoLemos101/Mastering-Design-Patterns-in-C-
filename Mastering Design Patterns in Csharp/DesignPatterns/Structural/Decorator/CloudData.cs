namespace Mastering_Design_Patterns_in_Csharp.DesignPatterns.Structural.Decorator;

public class CloudData : IData
{
    private readonly string _url;

    public CloudData(string url)
    {
        _url = url;
    }

    public void Save(string data)
    { 
        Console.WriteLine($"Saving data '{data}' to cloud at '{_url}'");
    }
}