namespace Mastering_Design_Patterns_in_Csharp.DesignPatterns.Creational.Builder;

public interface IVirtualMachineBuilder
{
    IVirtualMachineBuilder WithCpu(string cpu);
    IVirtualMachineBuilder WithRam(string ram);
    IVirtualMachineBuilder WithStorage(string storage);
    IVirtualMachineBuilder WithGraphicsCard(string graphicsCard);
    IVirtualMachineBuilder WithOperatingSystem(string operatingSystem);
    IVirtualMachineBuilder AddPeripheral(string peripheral);
    VirtualMachine Build();
}