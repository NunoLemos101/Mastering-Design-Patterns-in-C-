namespace Mastering_Design_Patterns_in_Csharp.DesignPatterns.Structural.Decorator;

public abstract class DataDecorator : IData
{
    protected IData _data;

    public DataDecorator(IData data)
    {
        _data = data;
    }

    public abstract void Save(string data);
}