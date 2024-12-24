namespace Mastering_Design_Patterns_in_Csharp.DesignPatterns.Behavioral.Memento;

// Caretaker
public class History
{
    private readonly List<EditorState> _states = new();
    private Editor _editor;

    public History(Editor editor)
    {
        _editor = editor;
    }

    public void BackUp()
    {
        _states.Add(_editor.CreateState());
    }

    public void Undo()
    {
        if (_states.Count > 0) return;
        
        var lastState = _states.Last();
        _states.Remove(lastState);
        _editor.Restore(lastState);
    }
}