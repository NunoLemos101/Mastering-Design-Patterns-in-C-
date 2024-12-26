namespace Mastering_Design_Patterns_in_Csharp.DesignPatterns.Behavioral.Command;

public class RemoteControl
{
    private ICommand _command;

    public RemoteControl(ICommand command)
    {
        _command = command;
    }

    public void SetCommand(ICommand command)
    {
        _command = command;
    }

    public void PressButton()
    {
        _command.Execute();
    }
}