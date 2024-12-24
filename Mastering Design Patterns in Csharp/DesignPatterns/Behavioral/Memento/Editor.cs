namespace Mastering_Design_Patterns_in_Csharp.DesignPatterns.Behavioral.Memento;

// Originator
public class Editor
{
    public string Title { get; set; }
    public string Content { get; set; }
    
    public EditorState CreateState() => new EditorState(Title, Content);

    public void Restore(EditorState state)
    {
        Title = state.GetTitle();
        Content = state.GetContent();
    }
}