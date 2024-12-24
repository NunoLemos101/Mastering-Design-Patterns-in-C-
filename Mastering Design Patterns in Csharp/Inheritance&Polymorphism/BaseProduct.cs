namespace Mastering_Design_Patterns_in_Csharp.Inheritance_Polymorphism;

public abstract class BaseProduct
{ 
    public string Name { get; set; }

    public void AddUser(string username)
    {
        Console.WriteLine($"User '{username}' added to {Name}.");
    }

    public abstract void CreateProject(string projectName);
}