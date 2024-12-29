namespace Mastering_Design_Patterns_in_Csharp.DesignPatterns.Creational.Builder;

public class VirtualMachineBuilder : IVirtualMachineBuilder
{
    private VirtualMachine _virtualMachine = new VirtualMachine();
    
    public IVirtualMachineBuilder WithCpu(string cpu)
    {
        _virtualMachine.Cpu = cpu;
        return this;
    }

    public IVirtualMachineBuilder WithRam(string ram)
    {
        _virtualMachine.Ram = ram;
        return this;
    }

    public IVirtualMachineBuilder WithStorage(string storage)
    {
        _virtualMachine.Storage = storage;
        return this;
    }

    public IVirtualMachineBuilder WithGraphicsCard(string graphicsCard)
    {
        _virtualMachine.GraphicsCard = graphicsCard;
        return this;
    }

    public IVirtualMachineBuilder WithOperatingSystem(string operatingSystem)
    {
        _virtualMachine.OperatingSystem = operatingSystem;
        return this;
    } 

    public IVirtualMachineBuilder AddPeripheral(string peripheral)
    {
        _virtualMachine.Peripherals.Add(peripheral);
        return this;
    }

    public VirtualMachine Build()
    {
        // Makes the builder reusable
        var clone = (VirtualMachine)_virtualMachine.Clone();
        _virtualMachine = new VirtualMachine();
        return clone;
    }
}