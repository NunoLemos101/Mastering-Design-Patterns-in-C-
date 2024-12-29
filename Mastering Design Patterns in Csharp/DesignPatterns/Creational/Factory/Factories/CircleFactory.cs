using Mastering_Design_Patterns_in_Csharp.DesignPatterns.Creational.Factory.Shapes;

namespace Mastering_Design_Patterns_in_Csharp.DesignPatterns.Creational.Factory.Factories;

public class CircleFactory : IShapeFactory<Circle>
{
    public IShape Create() => CreateInternal();

    public Circle CreateAsObject() => CreateInternal();
    private Circle CreateInternal() => new Circle();
}