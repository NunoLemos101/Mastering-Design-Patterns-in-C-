namespace Mastering_Design_Patterns_in_Csharp.DesignPatterns.Creational.Prototype;

public class Rectangle : Shape
{
    public int Width { get; set; }
    public int Height { get; set; }
    
    public Rectangle(string color) : base(color) { }

    public Rectangle(Rectangle source) : base(source)
    {
        Width = source.Width;
        Height = source.Height;
    }
    public override void Draw()
    {
        Console.WriteLine($"Drawing a {Color} Rectangle at ({X}, {Y}) with Width {Width} and Height {Height}");
    }

    public override object Clone()
    {
        return new Rectangle(this); // Create a new Rectangle instance by copying the current object
    }

    public override object DeepClone()
    {
        return new Rectangle(this);
    }
}