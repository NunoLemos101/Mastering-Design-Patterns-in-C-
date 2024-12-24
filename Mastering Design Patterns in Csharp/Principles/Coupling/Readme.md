# Coupling

Coupling refers to the degree of depedence between different components or classes
in a program. It describes how tightly or loosely different modules are connected.

In this example we use dependency injection to reduce the coupling between the ``Engine``
and ``LooseCoupledCar`` classes.

```csharp
public class Engine
{
    public void Start()
    {
        Console.WriteLine("Engine started.");
    }
}

public class LooseCoupledCar
{
    private Engine _engine;

    public LooseCoupledCar(Engine engine)
    {
        _engine = engine;
    }

    public void Start()
    {
        _engine.Start();
    }
}
```

Below there is an example of tight coupling between the ``Engine`` and ``TightCoupledCar`` classes.

```csharp
public class TightCoupledCar
{
    private Engine _engine;

    public TightCoupledCar()
    {
        _engine = new Engine();
    }

    public void Start()
    {
        _engine.Start();
    }
}
```