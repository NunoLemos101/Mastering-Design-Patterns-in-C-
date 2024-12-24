namespace Mastering_Design_Patterns_in_Csharp.DesignPatterns.Behavioral.Memento;

// Memento object
public class EditorState
{
    private readonly string _title;
    private readonly string _content;
    
    // State metadata
    private readonly DateTime _stateCreatedOn;

    public EditorState(string title, string content)
    {
        _title = title;
        _content = content;
        _stateCreatedOn = DateTime.Now;
    }

    public string GetTitle() => _title;
    
    public string GetContent() => _content;
    
    public DateTime GetDate() => _stateCreatedOn;
}