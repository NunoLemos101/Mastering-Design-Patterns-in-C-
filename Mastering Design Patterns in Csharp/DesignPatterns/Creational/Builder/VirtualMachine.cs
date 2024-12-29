namespace Mastering_Design_Patterns_in_Csharp.DesignPatterns.Creational.Builder;

public class VirtualMachine : ICloneable
{
    public string? Cpu { get; set; }
    public string? Ram { get; set; }
    public string? Storage { get; set; }
    public string? GraphicsCard { get; set; }
    public string? OperatingSystem { get; set; }
    public List<string> Peripherals { get; set; } = new List<string>();
    
    public object Clone()
    {
        return new VirtualMachine()
        {
            Cpu = Cpu,
            Ram = Ram,
            Storage = Storage,
            GraphicsCard = GraphicsCard,
            OperatingSystem = OperatingSystem,
            Peripherals = Peripherals
        };
    }
}