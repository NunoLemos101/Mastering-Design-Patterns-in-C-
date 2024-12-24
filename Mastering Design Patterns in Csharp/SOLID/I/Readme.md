# Interface Segregation Principle

The Interface Segregation Principle states that a client should not be forced to implement an interface that it doesn't use. This principle is about breaking down large interfaces into smaller and more specific ones so that clients will only have to know about the methods that are of interest to them.

One bad example of violating the Interface Segregation Principle is the following:

```csharp
public interface IWorker
{
    void Work();
    void Eat();
    void Sleep();
}

public class Person : IWorker
{
    public void Work()
    {
        Console.WriteLine("Working");
    }

    public void Eat()
    {
        Console.WriteLine("Eating");
    }

    public void Sleep()
    {
        Console.WriteLine("Sleeping");
    }
}

public class Robot : IWorker
{
    public void Work()
    {
        Console.WriteLine("Working");
    }

    public void Eat()
    {
        throw new NotImplementedException();
    }

    public void Sleep()
    {
        throw new NotImplementedException();
    }
}
```

In this example, the `Worker` class implements the `IWorker` interface. The problem with this is that not all workers need to eat or sleep. For example, a `Robot` worker doesn't need to eat or sleep. So we should break down the `IWorker` interface into smaller interfaces.

A better way to implement this would be to break down the `IWorker` interface into smaller interfaces like this:
```csharp
public interface IWorker
{
    void Work();
}

public interface IEater
{
    void Eat();
}

public interface ISleeper
{
    void Sleep();
}

public class Worker : IWorker, IEater, ISleeper
{
    public void Work()
    {
        Console.WriteLine("Working");
    }

    public void Eat()
    {
        Console.WriteLine("Eating");
    }

    public void Sleep()
    {
        Console.WriteLine("Sleeping");
    }
}

public class Robot : IWorker
{
    public void Work()
    {
        Console.WriteLine("Working");
    }
}
```