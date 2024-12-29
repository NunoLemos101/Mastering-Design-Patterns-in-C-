using Mastering_Design_Patterns_in_Csharp.DesignPatterns.Creational.Factory.Factories;
using Mastering_Design_Patterns_in_Csharp.DesignPatterns.Creational.Factory.Shapes;

namespace Mastering_Design_Patterns_in_Csharp.DesignPatterns.Creational.Factory;

public static class ShapeFactoryProvider
{
    private static readonly Dictionary<Type, IShapeFactory> Factories = new Dictionary<Type, IShapeFactory>();

    static ShapeFactoryProvider()
    {
        RegisterFactory<Circle>(new CircleFactory());
        RegisterFactory<Rectangle>(new RectangleFactory());
        RegisterFactory<Triangle>(new TriangleFactory());
    }
    
    public static IShapeFactory<T> GetFactory<T>() where T : IShape
    {
        if (TryGetFactory<T>(out var factory))
        {
            if (factory is IShapeFactory<T> specificFactory)
            {
                return specificFactory;
            }
            throw new InvalidCastException($"Factory registered for type {typeof(T).Name} does not implement IShapeFactory<T>");
        }
        throw new ArgumentException($"No factory registered for type {typeof(T).Name}");
    }
    
    private static void RegisterFactory<T>(IShapeFactory<IShape> factory)
    {
        Factories[typeof(T)] = factory;
    }
    
    private static bool TryGetFactory<T>(out IShapeFactory factory) where T : IShape
    {
        return Factories.TryGetValue(typeof(T), out factory);
    }
}