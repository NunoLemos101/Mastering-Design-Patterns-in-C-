namespace Mastering_Design_Patterns_in_Csharp.DesignPatterns.Behavioral.Command;

public class DimCommand : ICommand
{
    private Light _light;

    public DimCommand(Light light)
    {
        _light = light;
    }
    public void Execute()
    {
        _light.Dim();
    }
}