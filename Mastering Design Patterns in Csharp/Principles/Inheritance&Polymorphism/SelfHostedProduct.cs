namespace Mastering_Design_Patterns_in_Csharp.Principles.Inheritance_Polymorphism;

public class SelfHostedProduct : BaseProduct
{
    public override void CreateProject(string projectName)
    {
        Console.WriteLine($"Save {Name} in SQLite database.");
    }
}