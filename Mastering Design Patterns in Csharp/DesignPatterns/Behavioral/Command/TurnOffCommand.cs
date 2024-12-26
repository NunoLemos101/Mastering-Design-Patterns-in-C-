namespace Mastering_Design_Patterns_in_Csharp.DesignPatterns.Behavioral.Command;

public class TurnOffCommand : ICommand
{
    private Light _light;

    public TurnOffCommand(Light light)
    {
        _light = light;
    }
    public void Execute()
    {
        _light.TurnOff();
    }
}