using Mastering_Design_Patterns_in_Csharp.DesignPatterns.Behavioral.State.BadSolution;

namespace Mastering_Design_Patterns_in_Csharp.DesignPatterns.Behavioral.State.GoodSolution;

public class ModerationState : IState
{
    private Document _document;
    
    public ModerationState(Document document)
    {
        _document = document;
    }
    
    public void Publish()
    {
        if (_document.CurrentUserRole == UserRole.Admin)
        {
            _document.State = new PublishedState(_document);
        }
    }
}