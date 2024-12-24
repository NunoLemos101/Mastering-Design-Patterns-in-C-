namespace Mastering_Design_Patterns_in_Csharp.Inheritance_Polymorphism;

public class SelfHostedProduct : BaseProduct
{
    public override void CreateProject(string projectName)
    {
        Console.WriteLine($"Save {Name} in SQLite database.");
    }
    
    // Self-hosted-specific features
    public void SetupInfrastructure()
    {
        Console.WriteLine($"{Name} requires infrastructure setup.");
    }
}