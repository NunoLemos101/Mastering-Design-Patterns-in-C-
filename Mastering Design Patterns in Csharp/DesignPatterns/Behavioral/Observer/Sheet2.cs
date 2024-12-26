namespace Mastering_Design_Patterns_in_Csharp.DesignPatterns.Behavioral.Observer;

public class Sheet2 : IObserver
{
    private int _total;
    private DataSource _dataSource;

    public Sheet2(DataSource dataSource)
    {
        _dataSource = dataSource;
    }

    public int GetTotal()
    {
        return _total;
    }

    public void Update()
    {
        var sum = CalculateTotal(_dataSource.GetValues());
        System.Console.WriteLine("Total: " + sum);
        _total = sum;
    }

    private int CalculateTotal(List<int> values)
    {
        var sum = 0;
        foreach (var value in values)
        {
            sum += value;
        }
        return sum;
    }
}