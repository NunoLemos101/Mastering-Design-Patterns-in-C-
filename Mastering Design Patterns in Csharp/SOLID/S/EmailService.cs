namespace Mastering_Design_Patterns_in_Csharp.SOLID.S;

public class EmailService
{
    public void SendEmail(User user)
    {
        Console.WriteLine($"Email sent to {user.Username}.");
    }
}