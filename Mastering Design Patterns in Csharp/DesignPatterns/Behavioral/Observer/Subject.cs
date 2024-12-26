namespace Mastering_Design_Patterns_in_Csharp.DesignPatterns.Behavioral.Observer;

public class Subject
{
    private List<IObserver> _observers = new List<IObserver>();

    public void AddObserver(IObserver observer)
    {
        _observers.Add(observer);
    }

    public void RemoveObserver(IObserver observer)
    {
        _observers.Remove(observer);
    }

    public void NotifyObservers()
    {
        foreach (IObserver observer in _observers)
        {
            observer.Update();
        }
    }
}