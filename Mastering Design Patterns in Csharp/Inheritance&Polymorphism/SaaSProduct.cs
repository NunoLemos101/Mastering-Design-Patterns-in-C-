namespace Mastering_Design_Patterns_in_Csharp.Inheritance_Polymorphism;

public class SaaSProduct : BaseProduct
{
    public override void CreateProject(string projectName)
    {
         Console.WriteLine($"Save {Name} in PostgresSQL database.");
    }

    // SaaS-specific features
    public void EnableMultiTenancy()
    {
        Console.WriteLine($"{Name} supports multi-tenancy.");
    }
}