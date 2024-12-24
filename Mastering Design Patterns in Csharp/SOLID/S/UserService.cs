namespace Mastering_Design_Patterns_in_Csharp.SOLID.S;

public class UserService
{
    private readonly EmailService _emailService;
    
    public UserService(EmailService emailService)
    {
        _emailService = emailService;
    }
    
    public void RegisterUser(User user)
    {
        Console.WriteLine($"{user.Username} registered.");
        _emailService.SendEmail(user);
    }
    
    public void LoginUser(User user)
    {
        Console.WriteLine($"{user.Username} logged in.");
    }
}