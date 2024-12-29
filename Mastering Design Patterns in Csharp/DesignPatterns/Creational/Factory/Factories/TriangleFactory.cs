using Mastering_Design_Patterns_in_Csharp.DesignPatterns.Creational.Factory.Shapes;

namespace Mastering_Design_Patterns_in_Csharp.DesignPatterns.Creational.Factory.Factories;

public class TriangleFactory : IShapeFactory<Triangle>
{
    public IShape Create() => CreateInternal();

    public Triangle CreateAsObject() => CreateInternal();
    private Triangle CreateInternal() => new Triangle();
}