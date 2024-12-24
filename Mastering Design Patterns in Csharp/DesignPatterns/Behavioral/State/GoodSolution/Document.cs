using Mastering_Design_Patterns_in_Csharp.DesignPatterns.Behavioral.State.BadSolution;

namespace Mastering_Design_Patterns_in_Csharp.DesignPatterns.Behavioral.State.GoodSolution;

public class Document
{
    public IState State { get; set; }
    public UserRole CurrentUserRole { get; set; }

    public Document(UserRole currentUserRole)
    {
        State = new DraftState(this);
        CurrentUserRole = currentUserRole;
    }

    public void Publish()
    {
        State.Publish();
    }
}