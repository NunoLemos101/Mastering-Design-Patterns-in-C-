using Mastering_Design_Patterns_in_Csharp.DesignPatterns.Creational.Factory.Shapes;

namespace Mastering_Design_Patterns_in_Csharp.DesignPatterns.Creational.Factory.Factories;

public class RectangleFactory : IShapeFactory<Rectangle>
{
    public IShape Create() => CreateInternal();

    public Rectangle CreateAsObject() => CreateInternal();
    private Rectangle CreateInternal() => new Rectangle();
}