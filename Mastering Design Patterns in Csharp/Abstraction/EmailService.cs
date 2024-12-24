namespace Mastering_Design_Patterns_in_Csharp.Abstraction;

public class EmailService
{
    public void SendEmail()
    {
        Connect();
        Authenticate();
        Console.WriteLine("Sending email...");
        Disconnect();
    }

    private void Connect()
    {
        Console.WriteLine("Connecting to the email server...");
    }

    private void Authenticate()
    {
        Console.WriteLine("Authenticating against the email server...");
    }

    private void Disconnect()
    {
        Console.WriteLine("Disconnecting from the email server...");
    }
}