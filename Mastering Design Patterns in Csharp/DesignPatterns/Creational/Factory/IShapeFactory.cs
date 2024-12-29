namespace Mastering_Design_Patterns_in_Csharp.DesignPatterns.Creational.Factory;

public interface IShapeFactory
{
    IShape Create();
}

public interface IShapeFactory<out T> : IShapeFactory where T : IShape
{
    T CreateAsObject();
}