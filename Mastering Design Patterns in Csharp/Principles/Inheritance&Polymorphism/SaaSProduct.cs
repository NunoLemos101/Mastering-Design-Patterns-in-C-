namespace Mastering_Design_Patterns_in_Csharp.Principles.Inheritance_Polymorphism;

public class SaaSProduct : BaseProduct
{
    public override void CreateProject(string projectName)
    {
        Console.WriteLine($"Save {Name} in PostgresSQL database.");
    }
}