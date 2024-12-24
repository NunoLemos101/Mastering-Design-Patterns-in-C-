using Mastering_Design_Patterns_in_Csharp.DesignPatterns.Behavioral.State.BadSolution;

namespace Mastering_Design_Patterns_in_Csharp.DesignPatterns.Behavioral.State.GoodSolution;

public class DraftState : IState
{
    private Document _document;

    public DraftState(Document document)
    {
        _document = document;
    }
    
    public void Publish()
    {
        _document.State = new ModerationState(_document);
    }
}