namespace Mastering_Design_Patterns_in_Csharp.DesignPatterns.Behavioral.State.BadSolution;

public class Document
{
    public DocumentState State { get; set; }
    public UserRole CurrentUserRole { get; set; }

    public void Publish()
    {
        if (State == DocumentState.Draft)
        {
            State = DocumentState.Moderation;
        } else if (State == DocumentState.Moderation)
        {
            if (CurrentUserRole == UserRole.Admin)
            {
                State = DocumentState.Published;
            }
        }
    }
}