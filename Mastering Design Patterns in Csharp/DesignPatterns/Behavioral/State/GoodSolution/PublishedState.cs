using Mastering_Design_Patterns_in_Csharp.DesignPatterns.Behavioral.State.BadSolution;

namespace Mastering_Design_Patterns_in_Csharp.DesignPatterns.Behavioral.State.GoodSolution;

public class PublishedState : IState
{
    private Document _document;
    
    public PublishedState(Document document)
    {
        _document = document;
    }
    
    public void Publish()
    {
        // Do nothing
    }
}