namespace Mastering_Design_Patterns_in_Csharp.DesignPatterns.Behavioral.Command;

public class TurnOnCommand : ICommand
{
    private Light _light;

    public TurnOnCommand(Light light)
    {
        _light = light;
    }
    public void Execute()
    {
        _light.TurnOn();
    }
}