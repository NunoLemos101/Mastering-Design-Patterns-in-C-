namespace Mastering_Design_Patterns_in_Csharp.Principles.Coupling;

public class TightCoupledCar
{
    public void Start()
    {
        var engine = new Engine();
        engine.Start();
    }
}