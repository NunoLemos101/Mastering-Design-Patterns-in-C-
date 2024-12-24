namespace Mastering_Design_Patterns_in_Csharp.Principles.Composition;

public class Car
{
    private readonly Engine _engine;
    private readonly Wheels _wheels;
    private readonly Chassis _chassis;

    // Dependency Injection to compose the car
    // To make this more testable, we can use interfaces instead of concrete classes
    public Car(Engine engine, Wheels wheels, Chassis chassis)
    {
        _engine = engine;
        _wheels = wheels;
        _chassis = chassis;
    }

    public void Start()
    {
        _chassis.Support();
        _engine.Start();
        _wheels.Rotate();
        Console.WriteLine("Car is now running.");
    }

    public void Stop()
    {
        _engine.Stop();
        Console.WriteLine("Car has stopped.");
    }
}