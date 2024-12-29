using Mastering_Design_Patterns_in_Csharp.DesignPatterns.Creational.Factory.Shapes;

namespace Mastering_Design_Patterns_in_Csharp.DesignPatterns.Creational.Factory;

public class Program
{
    public static void Main()
    {
        var circleFactory = ShapeFactoryProvider.GetFactory<Circle>();

        var shape = circleFactory.Create();
        var circle = circleFactory.CreateAsObject();
    }
}