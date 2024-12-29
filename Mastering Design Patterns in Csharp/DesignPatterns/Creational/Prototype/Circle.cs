namespace Mastering_Design_Patterns_in_Csharp.DesignPatterns.Creational.Prototype;

public class Circle : Shape
{
    public int Radius { get; set; }

    public Circle(string color) : base(color) { }

    public Circle(Circle source) : base(source)
    {
        Radius = source.Radius;
    }

    public override void Draw()
    {
        Console.WriteLine($"Drawing a {Color} Circle at ({X}, {Y}) with Radius {Radius}");
    }

    public override object Clone()
    {
        return new Circle(this); // Create a new Circle instance by copying the current object
    }

    public override object DeepClone()
    {
        return new Circle(this);
    }
}