namespace Mastering_Design_Patterns_in_Csharp.DesignPatterns.Creational.Builder;

public class Program
{
    public static void Main()
    {
        var builder = new VirtualMachineBuilder();
        
        var vm1 = builder
            .WithCpu("Intel Xeon E5-2699 v4")
            .WithRam("64GB RAM")
            .WithStorage("1TB SSD")
            .WithOperatingSystem("Windows Server 2022")
            .Build();
    }
}