namespace Mastering_Design_Patterns_in_Csharp.Principles.Coupling;

public class LooseCoupledCar
{
    private readonly IEngine _engine;

    public LooseCoupledCar(IEngine engine)
    {
        _engine = engine;
    }
    
    public void Start()
    {
        _engine.Start();
    }
}