namespace Mastering_Design_Patterns_in_Csharp.DesignPatterns.Behavioral.Observer;

public class DataSource : Subject
{
    private List<int> _values = new List<int>();

    public List<int> GetValues()
    {
        return _values;
    }

    public void SetValues(List<int> values)
    {
        _values = values;

        NotifyObservers();
    }
}