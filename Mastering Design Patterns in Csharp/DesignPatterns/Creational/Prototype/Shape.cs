namespace Mastering_Design_Patterns_in_Csharp.DesignPatterns.Creational.Prototype;

public abstract class Shape : ICloneable
{
    public string Color { get; set; }
    public int X { get; set; }
    public int Y { get; set; }

    protected Shape(string color)
    {
        Color = color;
    }
    
    protected Shape(Shape source) // Copy Constructor for deep cloning
    {
        Color = source.Color;
        X = source.X;
        Y = source.Y;
    }

    public abstract void Draw();
    public abstract object Clone();

    public virtual object DeepClone()
    {
        return MemberwiseClone();
    }
}