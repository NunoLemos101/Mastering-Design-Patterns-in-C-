namespace Mastering_Design_Patterns_in_Csharp.DesignPatterns.Behavioral.Observer;

public class BarChart : IObserver
{
    private DataSource _dataSource;

    public BarChart(DataSource dataSource)
    {
        _dataSource = dataSource;
    }

    public void Update()
    {
        System.Console.WriteLine("Rendering bar chart with new values");
    }
}